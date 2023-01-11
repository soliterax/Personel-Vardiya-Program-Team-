﻿namespace Personel_Vardiya_Programı_Team_.Layouts
{
    partial class LoginUserControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customButton1 = new SoliteraxControlLibrary.CustomButton();
            this.usernameTxt = new SoliteraxControlLibrary.CustomTextBox();
            this.passwordTxt = new SoliteraxControlLibrary.CustomTextBox();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 3;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(597, 369);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(200, 49);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Giriş Yap";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.usernameTxt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.usernameTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTxt.BorderRadius = 5;
            this.usernameTxt.BorderSize = 2;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.White;
            this.usernameTxt.LeftImage = null;
            this.usernameTxt.Location = new System.Drawing.Point(531, 170);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.usernameTxt.Multiline = false;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.usernameTxt.PasswordChar = false;
            this.usernameTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.RightImage = null;
            this.usernameTxt.Size = new System.Drawing.Size(333, 39);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.Texts = "";
            this.usernameTxt.UnderlinedStyle = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.passwordTxt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTxt.BorderRadius = 5;
            this.passwordTxt.BorderSize = 2;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.LeftImage = null;
            this.passwordTxt.Location = new System.Drawing.Point(531, 246);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.passwordTxt.PasswordChar = false;
            this.passwordTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.RightImage = null;
            this.passwordTxt.Size = new System.Drawing.Size(333, 39);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Texts = "";
            this.passwordTxt.UnderlinedStyle = false;
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.ForeColor = System.Drawing.Color.White;
            this.rememberme.Location = new System.Drawing.Point(635, 311);
            this.rememberme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(119, 20);
            this.rememberme.TabIndex = 3;
            this.rememberme.Text = "Remember Me";
            this.rememberme.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(383, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 80);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı veya Şifreniz Hatalı!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Personel_Vardiya_Programı_Team_.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rememberme);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.customButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(1436, 704);
            this.Load += new System.EventHandler(this.LoginUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoliteraxControlLibrary.CustomButton customButton1;
        private SoliteraxControlLibrary.CustomTextBox usernameTxt;
        private SoliteraxControlLibrary.CustomTextBox passwordTxt;
        private System.Windows.Forms.CheckBox rememberme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
