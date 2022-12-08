namespace Personel_Vardiya_Programı_Team_.Layouts
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
            this.customButton1 = new SoliteraxControlLibrary.CustomButton();
            this.usernameTxt = new SoliteraxControlLibrary.CustomTextBox();
            this.passwordTxt = new SoliteraxControlLibrary.CustomTextBox();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.customButton1.Location = new System.Drawing.Point(209, 275);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
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
            this.usernameTxt.Location = new System.Drawing.Point(143, 76);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTxt.Multiline = false;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.usernameTxt.PasswordChar = false;
            this.usernameTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.PlaceholderText = "Username";
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
            this.passwordTxt.Location = new System.Drawing.Point(143, 152);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.passwordTxt.PasswordChar = false;
            this.passwordTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.Size = new System.Drawing.Size(333, 39);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Texts = "";
            this.passwordTxt.UnderlinedStyle = false;
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.ForeColor = System.Drawing.Color.White;
            this.rememberme.Location = new System.Drawing.Point(247, 217);
            this.rememberme.Margin = new System.Windows.Forms.Padding(4);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(119, 20);
            this.rememberme.TabIndex = 3;
            this.rememberme.Text = "Remember Me";
            this.rememberme.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rememberme);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(400, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 447);
            this.panel1.TabIndex = 5;
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(1436, 704);
            this.Load += new System.EventHandler(this.LoginUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SoliteraxControlLibrary.CustomButton customButton1;
        private SoliteraxControlLibrary.CustomTextBox usernameTxt;
        private SoliteraxControlLibrary.CustomTextBox passwordTxt;
        private System.Windows.Forms.CheckBox rememberme;
        private System.Windows.Forms.Panel panel1;
    }
}
