using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Netflix.FileOperation
{
    class FileOperation
    {
        private static FileStream file;
        private static StreamReader reader;
        private static StreamWriter writer;
        public static int userID;

        public string openingControl()
        {
            if(File.Exists(@"NetflixSet\control.txt"))
            {
                file = new FileStream(@"NetflixSet\control.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);

                string line;
                string eMail;
                line = reader.ReadLine();
                if (line == "1")
                {
                    eMail = reader.ReadLine();
                    userID = int.Parse(reader.ReadLine());
                    reader.Close();
                    file.Close();
                    return eMail;
                }
                else
                {
                    reader.Close();
                    file.Close();
                    return null;
                }
            }
            return null;
        }
        public void openingSave(string eMail)
        {
            file = new FileStream(@"NetflixSet\control.txt", FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(file);
            writer.Write("1\n");
            writer.Write(eMail);
            writer.Write("\n");
            writer.Write(userID);
            writer.Flush();
            writer.Close();
            file.Close();
        }
        public static void saveUserID(int ID)
        {
            userID = ID;
        }
        public static void closeAccount()
        {
            File.Delete(@"NetflixSet\control.txt");
            System.Windows.Forms.Application.Restart();
        }
    }
}
