using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb; //Access bağlantısı için gerekli kütüphane
using System.Data;

namespace Netflix.Database
{
    class DatabaseOperation
    {
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;
        private Account account;

        public List<Programs> programs = new List<Programs>();

        public DatabaseOperation()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0; Data Source=NetflixSet\NetflixDB.accdb");
            command = new OleDbCommand();
        }
        public bool passwordControl(string password, string password1)
        {
            if (password.Length != password1.Length)
                return false;
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] != password1[i])
                        return false;
                }
                return true;
            }
        }
        public bool AddAccount(string ad, string soyad, string eMail, string password, string date)
        {
            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO Kullanici (Ad,Soyad,E_Mail,Dogum_Tarihi,Sifre) VALUES ('" + ad + "','" + soyad + "','" + eMail + "','" + date + "','" + password + "')";
                command.Connection = connection;
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Kayıt başarılı", "Netflix", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Kayıt edilirken bir hata oluştu. Kayıt Başarısız.", "Netflix", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool LoginControl(string eMail, string password)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Sifre FROM Kullanici WHERE E_Mail = '" + eMail + "'";
                //command.Parameters.AddWithValue("@mail", eMail);
                reader = command.ExecuteReader();
                reader.Read();

                if (passwordControl(password, reader["Sifre"].ToString()))
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
                    
            }
            catch (Exception)
            {
                //System.Windows.Forms.MessageBox.Show("Konrol yapılırken bir hata oluştu!", "Netflix", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
        }
        public Account getAccountData(string eMail)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Kullanici WHERE E_Mail = '" + eMail + "'";
            reader = command.ExecuteReader();
            reader.Read();

            account = new Account();
            account.firstName = reader["Ad"].ToString();
            account.lastName = reader["Soyad"].ToString();
            account.eMail = reader["E_Mail"].ToString();
            account.date = reader["Dogum_Tarihi"].ToString();
            account.password = reader["Sifre"].ToString();

            connection.Close();
            return account;
        }
        public void UpdateAccount(string ad, string soyad, string eMail, string password, string date, string old_eMail)
        {
            try
            {
                connection.Open();
                command.CommandText = "UPDATE Kullanici SET Ad='" + ad + "',Soyad='" + soyad + "',E_Mail='" + eMail + "',Sifre='" + password + "',Dogum_Tarihi='" + date + "' WHERE E_Mail='" + old_eMail + "'" ;
                command.Connection = connection;
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Güncelleme başarılı", "Netflix", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Güncelleme yapılırken bir hata oluştu. Güncelleme Başarısız.", "Netflix", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void getPrograms(string type)//type: AnaSayfa - Dizi - Film - Tv Show 
        {
            programs.Clear();
            connection.Open();
            if (type == "AnaSayfa")
                command.CommandText = "SELECT * FROM Program";
            else
                command.CommandText = "SELECT * FROM Program WHERE Tipi = '" + type + "'";
            command.Connection = connection;
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                Programs p = new Programs();
                p.id = int.Parse(reader["ID"].ToString());
                p.name = reader["Adi"].ToString();
                p.programType = reader["Tipi"].ToString();
                p.numberOfEpisodes = int.Parse(reader["Bolum_Sayisi"].ToString());
                p.programLength = int.Parse(reader["Program_Uzunlugu"].ToString());
                p.bannerUrl = reader["Afis"].ToString();

                programs.Add(p);
            }
            connection.Close();
            fillProgramsKind();
            fillProgramsPuan();
        }
        public void getMyList(int userID)
        {
            programs.Clear();
            connection.Open();
            command.CommandText = "SELECT * FROM Program WHERE ID IN (SELECT Program_ID FROM Kullanici_Program WHERE Kullanici_ID = " + userID + ");";
            command.Connection = connection;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Programs p = new Programs();
                p.id = int.Parse(reader["ID"].ToString());
                p.name = reader["Adi"].ToString();
                p.programType = reader["Tipi"].ToString();
                p.numberOfEpisodes = int.Parse(reader["Bolum_Sayisi"].ToString());
                p.programLength = int.Parse(reader["Program_Uzunlugu"].ToString());
                p.bannerUrl = reader["Afis"].ToString();

                programs.Add(p);
            }
            connection.Close();
            fillProgramsKind();
            fillProgramsPuan();

            connection.Close();
        }
        public void Search(string search)
        {
            programs.Clear();
            connection.Open();
            //PROGRAMIN ADINA GÖRE ARAMA
            command.CommandText = "SELECT * FROM Program WHERE Adi LIKE '" + search + "%'";
            command.Connection = connection;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Programs p = new Programs();
                p.id = int.Parse(reader["ID"].ToString());
                p.name = reader["Adi"].ToString();
                p.programType = reader["Tipi"].ToString();
                p.numberOfEpisodes = int.Parse(reader["Bolum_Sayisi"].ToString());
                p.programLength = int.Parse(reader["Program_Uzunlugu"].ToString());
                p.bannerUrl = reader["Afis"].ToString();

                programs.Add(p);
            }

            //PROGRAMIN TİPİNE GÖRE ARAMA
            reader.Close();
            command.CommandText = "SELECT * FROM Program WHERE Tipi LIKE '" + search + "%'";
            command.Connection = connection;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Programs p = new Programs();
                p.id = int.Parse(reader["ID"].ToString());
                p.name = reader["Adi"].ToString();
                p.programType = reader["Tipi"].ToString();
                p.numberOfEpisodes = int.Parse(reader["Bolum_Sayisi"].ToString());
                p.programLength = int.Parse(reader["Program_Uzunlugu"].ToString());
                p.bannerUrl = reader["Afis"].ToString();

                programs.Add(p);
            }

            //PROGRAMIN TÜRÜNE GÖRE ARAMA
            reader.Close();
            command.CommandText = "SELECT * FROM Program WHERE ID IN (SELECT Program_ID FROM Program_Tur WHERE Tur_ID IN (SELECT ID FROM Tur WHERE Adi LIKE '" + search + "%'))";
            command.Connection = connection;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Programs p = new Programs();
                p.id = int.Parse(reader["ID"].ToString());
                p.name = reader["Adi"].ToString();
                p.programType = reader["Tipi"].ToString();
                p.numberOfEpisodes = int.Parse(reader["Bolum_Sayisi"].ToString());
                p.programLength = int.Parse(reader["Program_Uzunlugu"].ToString());
                p.bannerUrl = reader["Afis"].ToString();

                programs.Add(p);
            }

            connection.Close();
            fillProgramsKind();
            fillProgramsPuan();
        }
        public int getProgramCount()
        {
            return programs.Count;
        }
        public void AddList(int userID, int programID, int passingMinute, int lastEpisode, int puan)
        {
            DateTime dateTime = DateTime.Now;
            if (lastEpisodeControl(userID,programID))
            {
                connection.Open();
                command.CommandText = "INSERT INTO Kullanici_Program (Kullanici_ID, Program_ID, Izlenme_Tarihi, Izlenme_Suresi, Son_Bolum, Puan) VALUES ('" + userID + "','" + programID + "','" + dateTime + "','" + passingMinute + "','" + lastEpisode + "','" + puan + "')";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Open();
                command.CommandText = "UPDATE Kullanici_Program SET Izlenme_Tarihi='"+dateTime + "',Izlenme_Suresi=" + passingMinute +", Son_Bolum="+lastEpisode + ",Puan = " + puan +" WHERE Kullanici_ID="+userID+"AND Program_ID="+programID +";";
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public int getLastEpisode(int userID, int programID)
        {
            int value;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT Son_Bolum FROM Kullanici_Program WHERE Kullanici_ID = " + userID + "AND Program_ID = " + programID;
            reader = command.ExecuteReader();
            reader.Read();
            try
            {
                value = int.Parse(reader["Son_Bolum"].ToString());
            }
            catch (Exception)
            {
                value = 0;
            }
            connection.Close();
            return value;
        }
        public int getLastEpisodePassingTime(int userID, int programID)
        {
            int value;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT Izlenme_Suresi FROM Kullanici_Program WHERE Kullanici_ID = " + userID + "AND Program_ID = " + programID;
            reader = command.ExecuteReader();
            reader.Read();
            try
            {
                value = int.Parse(reader["Izlenme_Suresi"].ToString());
            }
            catch (Exception)
            {
                value = 0;
            }
            connection.Close();
            return value;
        }
        public void getUserID(string eMail)
        {
            reader.Close();
            connection.Open();
            command.CommandText = "SELECT ID FROM Kullanici WHERE E_Mail = '" + eMail + "'";
            command.Connection = connection;
            reader = command.ExecuteReader();
            reader.Read();
            FileOperation.FileOperation.saveUserID(int.Parse(reader[0].ToString()));
            connection.Close();
        }
        public void getHighScore(string kind)
        {
            List<int> data = new List<int>();
            string query = "SELECT Program.ID FROM Program, Kullanici_Program AS K";
            query += " WHERE Program.ID = K.Program_ID AND Tipi = 'Film' AND ID IN(SELECT Program_ID FROM Program_Tur WHERE Tur_ID IN(SELECT ID FROM Tur WHERE Adi = '" + kind + "'))";
            query += " GROUP BY Program.ID";
            query += " ORDER BY SUM(K.Puan)DESC";

            programs.Clear();
            connection.Open();
            command.CommandText = query;
            command.Connection = connection;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(int.Parse(reader[0].ToString()));
            }
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    reader.Close();
                    command.CommandText = "SELECT * FROM Program WHERE ID = " + data[i];
                    reader = command.ExecuteReader();
                    reader.Read();
                    Programs p = new Programs();
                    p.id = int.Parse(reader["ID"].ToString());
                    p.name = reader["Adi"].ToString();
                    p.programType = reader["Tipi"].ToString();
                    p.numberOfEpisodes = int.Parse(reader["Bolum_Sayisi"].ToString());
                    p.programLength = int.Parse(reader["Program_Uzunlugu"].ToString());
                    p.bannerUrl = reader["Afis"].ToString();

                    programs.Add(p);
                }
            }
            catch(Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private void fillProgramsKind()
        {
            connection.Open();
            foreach (var item in programs)
            {
                reader.Close();
                command.CommandText = "SELECT Adi FROM Tur WHERE ID IN (SELECT Tur_ID FROM Program_Tur WHERE Program_ID IN (SELECT ID FROM Program WHERE ID = " + item.id + "))";
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    item.programKind.Add(reader["Adi"].ToString());
                }
            }
            connection.Close();
        }
        private void fillProgramsPuan()
        {
            connection.Open();
            foreach (var item in programs)
            {
                reader.Close();
                command.CommandText = "SELECT AVG(Puan) FROM Kullanici_Program WHERE Program_ID IN (SELECT ID FROM Program WHERE ID = " + item.id + ");";
                command.Connection = connection;
                reader = command.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    item.puan = double.Parse(reader[0].ToString());
                else
                    item.puan = 0;
            }
            connection.Close();
        }
        private bool lastEpisodeControl(int userID, int programID)
        {
            int value;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Kullanici_Program WHERE Kullanici_ID = " + userID + "AND Program_ID = " + programID;
            reader = command.ExecuteReader();
            reader.Read();
            try
            { value = int.Parse(reader["Son_Bolum"].ToString()); }
            catch
            { value = 0; }
            connection.Close();
            if(value == 0)
                return true;
            return false;
        }
    }
}
