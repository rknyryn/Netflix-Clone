namespace Netflix
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_newAccount = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_eMail = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_newAccount
            // 
            this.lbl_newAccount.AutoSize = true;
            this.lbl_newAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_newAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lbl_newAccount.Location = new System.Drawing.Point(85, 439);
            this.lbl_newAccount.Name = "lbl_newAccount";
            this.lbl_newAccount.Size = new System.Drawing.Size(201, 40);
            this.lbl_newAccount.TabIndex = 6;
            this.lbl_newAccount.Text = "Henüz üye değil misiniz? \r\n       Hemen kayıt ol";
            this.lbl_newAccount.Click += new System.EventHandler(this.lbl_newAccount_Click);
            this.lbl_newAccount.MouseLeave += new System.EventHandler(this.lbl_newAccount_MouseLeave);
            this.lbl_newAccount.MouseHover += new System.EventHandler(this.lbl_newAccount_MouseHover);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lbl_exit.Location = new System.Drawing.Point(150, 504);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(79, 20);
            this.lbl_exit.TabIndex = 7;
            this.lbl_exit.Text = "Çıkış Yap";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            this.lbl_exit.MouseLeave += new System.EventHandler(this.lbl_exit_MouseLeave);
            this.lbl_exit.MouseHover += new System.EventHandler(this.lbl_exit_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Location = new System.Drawing.Point(64, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 50);
            this.panel2.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_password.Location = new System.Drawing.Point(9, 12);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(233, 23);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "Şifre";
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.txt_eMail);
            this.panel1.Location = new System.Drawing.Point(64, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 50);
            this.panel1.TabIndex = 2;
            // 
            // txt_eMail
            // 
            this.txt_eMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txt_eMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_eMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_eMail.Location = new System.Drawing.Point(9, 12);
            this.txt_eMail.Name = "txt_eMail";
            this.txt_eMail.Size = new System.Drawing.Size(233, 23);
            this.txt_eMail.TabIndex = 1;
            this.txt_eMail.Text = "Mail Adresi";
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.btn1.Location = new System.Drawing.Point(64, 377);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(253, 50);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Giriş Yap";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(377, 562);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_newAccount);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_newAccount;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_eMail;
        private System.Windows.Forms.Button btn1;
    }
}

