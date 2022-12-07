namespace Personel_Vardiya_Programı_Team_
{
    partial class PersonelForm
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ustPanel = new SoliteraxControlLibrary.CustomPanel();
            this.headerText = new SoliteraxControlLibrary.CustomLabel();
            this.FormMinimize = new SoliteraxControlLibrary.CustomPictureBox();
            this.FormClose = new SoliteraxControlLibrary.CustomPictureBox();
            this.ellipseControl1 = new SoliteraxControlLibrary.EllipseControl();
            this.componentHover1 = new SoliteraxControlLibrary.ComponentHover();
            this.customButton4 = new SoliteraxControlLibrary.CustomButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customButton1 = new SoliteraxControlLibrary.CustomButton();
            this.customButton2 = new SoliteraxControlLibrary.CustomButton();
            this.customButton3 = new SoliteraxControlLibrary.CustomButton();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ustPanel.borderBottomColor = System.Drawing.Color.White;
            this.ustPanel.borderBottomSize = 1;
            this.ustPanel.borderColor = System.Drawing.Color.White;
            this.ustPanel.borderLeftColor = System.Drawing.Color.White;
            this.ustPanel.borderLeftSize = 1;
            this.ustPanel.borderRadius = 30;
            this.ustPanel.borderRightColor = System.Drawing.Color.White;
            this.ustPanel.borderRightSize = 1;
            this.ustPanel.borderSize = 1;
            this.ustPanel.borderTopColor = System.Drawing.Color.White;
            this.ustPanel.borderTopSize = 1;
            this.ustPanel.Controls.Add(this.headerText);
            this.ustPanel.Controls.Add(this.FormMinimize);
            this.ustPanel.Controls.Add(this.FormClose);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.haveBorder = false;
            this.ustPanel.haveEllipse = false;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1436, 41);
            this.ustPanel.TabIndex = 0;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.borderBottomColor = System.Drawing.Color.White;
            this.headerText.borderBottomSize = 1;
            this.headerText.BorderColor = System.Drawing.Color.White;
            this.headerText.borderLeftColor = System.Drawing.Color.White;
            this.headerText.borderLeftSize = 1;
            this.headerText.borderRightColor = System.Drawing.Color.White;
            this.headerText.borderRightSize = 1;
            this.headerText.BorderSize = 1;
            this.headerText.borderTopColor = System.Drawing.Color.White;
            this.headerText.borderTopSize = 1;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerText.Location = new System.Drawing.Point(53, 7);
            this.headerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(244, 25);
            this.headerText.TabIndex = 2;
            this.headerText.Text = "Personel Vardiya Programı";
            // 
            // FormMinimize
            // 
            this.FormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormMinimize.BackColor = System.Drawing.Color.Transparent;
            this.FormMinimize.borderBottomColor = System.Drawing.Color.White;
            this.FormMinimize.borderBottomSize = 1;
            this.FormMinimize.borderColor = System.Drawing.Color.White;
            this.FormMinimize.borderLeftColor = System.Drawing.Color.White;
            this.FormMinimize.borderLeftSize = 1;
            this.FormMinimize.borderRightColor = System.Drawing.Color.White;
            this.FormMinimize.borderRightSize = 1;
            this.FormMinimize.borderSize = 1;
            this.FormMinimize.borderTopColor = System.Drawing.Color.White;
            this.FormMinimize.borderTopSize = 1;
            this.FormMinimize.haveBorder = false;
            this.FormMinimize.Image = global::Personel_Vardiya_Programı_Team_.Properties.Resources.minimize;
            this.FormMinimize.Location = new System.Drawing.Point(1321, 0);
            this.FormMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.FormMinimize.Name = "FormMinimize";
            this.FormMinimize.Size = new System.Drawing.Size(45, 41);
            this.FormMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormMinimize.TabIndex = 1;
            this.FormMinimize.TabStop = false;
            this.FormMinimize.Click += new System.EventHandler(this.customPictureBox2_Click);
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormClose.BackColor = System.Drawing.Color.Transparent;
            this.FormClose.borderBottomColor = System.Drawing.Color.White;
            this.FormClose.borderBottomSize = 1;
            this.FormClose.borderColor = System.Drawing.Color.White;
            this.FormClose.borderLeftColor = System.Drawing.Color.White;
            this.FormClose.borderLeftSize = 1;
            this.FormClose.borderRightColor = System.Drawing.Color.White;
            this.FormClose.borderRightSize = 1;
            this.FormClose.borderSize = 1;
            this.FormClose.borderTopColor = System.Drawing.Color.White;
            this.FormClose.borderTopSize = 1;
            this.FormClose.haveBorder = false;
            this.FormClose.Image = global::Personel_Vardiya_Programı_Team_.Properties.Resources.close;
            this.FormClose.Location = new System.Drawing.Point(1375, 0);
            this.FormClose.Margin = new System.Windows.Forms.Padding(4);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(45, 41);
            this.FormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormClose.TabIndex = 0;
            this.FormClose.TabStop = false;
            this.FormClose.Click += new System.EventHandler(this.customPictureBox1_Click);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 40;
            this.ellipseControl1.TargetControl = this;
            // 
            // componentHover1
            // 
            this.componentHover1.ReferencedControl = this.ustPanel;
            this.componentHover1.TargetControl = this;
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton4.BorderRadius = 10;
            this.customButton4.BorderSize = 3;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(36, 654);
            this.customButton4.Margin = new System.Windows.Forms.Padding(4);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(200, 49);
            this.customButton4.TabIndex = 5;
            this.customButton4.Text = " Geri Dön";
            this.customButton4.TextColor = System.Drawing.Color.White;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 507);
            this.dataGridView1.TabIndex = 6;
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
            this.customButton1.Location = new System.Drawing.Point(1179, 633);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(200, 70);
            this.customButton1.TabIndex = 7;
            this.customButton1.Text = "Kaydet";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 3;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(622, 633);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(200, 70);
            this.customButton2.TabIndex = 8;
            this.customButton2.Text = " Sil";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.BorderRadius = 10;
            this.customButton3.BorderSize = 3;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(903, 633);
            this.customButton3.Margin = new System.Windows.Forms.Padding(4);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(200, 70);
            this.customButton3.TabIndex = 9;
            this.customButton3.Text = " Güncelle";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1436, 745);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SoliteraxControlLibrary.EllipseControl ellipseControl1;
        private SoliteraxControlLibrary.CustomPanel ustPanel;
        private SoliteraxControlLibrary.CustomPictureBox FormClose;
        private SoliteraxControlLibrary.CustomLabel headerText;
        private SoliteraxControlLibrary.CustomPictureBox FormMinimize;
        private Layouts.LoginUserControl loginUserControl1;
        private SoliteraxControlLibrary.ComponentHover componentHover1;
        private SoliteraxControlLibrary.CustomButton customButton4;
        private SoliteraxControlLibrary.CustomButton customButton3;
        private SoliteraxControlLibrary.CustomButton customButton2;
        private SoliteraxControlLibrary.CustomButton customButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}