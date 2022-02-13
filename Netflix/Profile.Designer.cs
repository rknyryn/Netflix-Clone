namespace Netflix
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_exitAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 12);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(122, 50);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_logo.TabIndex = 2;
            this.picBox_logo.TabStop = false;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btn_settings.Location = new System.Drawing.Point(67, 94);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(166, 50);
            this.btn_settings.TabIndex = 17;
            this.btn_settings.Text = "Profil Ayarları";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_exitAccount
            // 
            this.btn_exitAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exitAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btn_exitAccount.Location = new System.Drawing.Point(67, 150);
            this.btn_exitAccount.Name = "btn_exitAccount";
            this.btn_exitAccount.Size = new System.Drawing.Size(166, 50);
            this.btn_exitAccount.TabIndex = 18;
            this.btn_exitAccount.Text = "Çıkış Yap";
            this.btn_exitAccount.UseVisualStyleBackColor = false;
            this.btn_exitAccount.Click += new System.EventHandler(this.btn_exitAccount_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(304, 229);
            this.Controls.Add(this.btn_exitAccount);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.picBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(322, 276);
            this.MinimumSize = new System.Drawing.Size(322, 276);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_exitAccount;
    }
}