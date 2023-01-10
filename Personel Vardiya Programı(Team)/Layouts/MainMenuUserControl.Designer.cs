namespace Personel_Vardiya_Programı_Team_.Layouts
{
    partial class MainMenuUserControl
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
            this.customButton2 = new SoliteraxControlLibrary.CustomButton();
            this.customButton3 = new SoliteraxControlLibrary.CustomButton();
            this.customButton4 = new SoliteraxControlLibrary.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nobetMonitor1 = new Personel_Vardiya_Programı_Team_.Layouts.SystemScreens.NobetMonitor();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(135, 439);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(195, 57);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Kullanıcılar";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderRadius = 15;
            this.customButton2.BorderSize = 2;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(437, 439);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(213, 57);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = " Otomatik Vardiya Ayarla";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.BorderRadius = 15;
            this.customButton3.BorderSize = 2;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(745, 439);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(195, 57);
            this.customButton3.TabIndex = 2;
            this.customButton3.Text = "Personeller";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton4.BorderColor = System.Drawing.Color.DarkViolet;
            this.customButton4.BorderRadius = 15;
            this.customButton4.BorderSize = 2;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(471, 517);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(150, 40);
            this.customButton4.TabIndex = 5;
            this.customButton4.Text = "Çıkış Yap";
            this.customButton4.TextColor = System.Drawing.Color.White;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nobetMonitor1);
            this.panel1.Location = new System.Drawing.Point(16, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 413);
            this.panel1.TabIndex = 6;
            // 
            // nobetMonitor1
            // 
            this.nobetMonitor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.nobetMonitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nobetMonitor1.Location = new System.Drawing.Point(0, 0);
            this.nobetMonitor1.Name = "nobetMonitor1";
            this.nobetMonitor1.Size = new System.Drawing.Size(1046, 413);
            this.nobetMonitor1.TabIndex = 0;
            // 
            // MainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Name = "MainMenuUserControl";
            this.Size = new System.Drawing.Size(1077, 572);
            this.Load += new System.EventHandler(this.MainMenuUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SoliteraxControlLibrary.CustomButton customButton1;
        private SoliteraxControlLibrary.CustomButton customButton2;
        private SoliteraxControlLibrary.CustomButton customButton3;
        private SoliteraxControlLibrary.CustomButton customButton4;
        private System.Windows.Forms.Panel panel1;
        private SystemScreens.NobetMonitor nobetMonitor1;
    }
}
