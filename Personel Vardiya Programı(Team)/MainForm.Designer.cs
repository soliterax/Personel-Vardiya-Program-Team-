namespace Personel_Vardiya_Programı_Team_
{
    partial class MainForm
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
            this.ellipseControl1 = new SoliteraxControlLibrary.EllipseControl();
            this.ustPanel = new SoliteraxControlLibrary.CustomPanel();
            this.customPictureBox1 = new SoliteraxControlLibrary.CustomPictureBox();
            this.customPictureBox2 = new SoliteraxControlLibrary.CustomPictureBox();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // ustPanel
            // 
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
            this.ustPanel.Controls.Add(this.customPictureBox2);
            this.ustPanel.Controls.Add(this.customPictureBox1);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.haveBorder = false;
            this.ustPanel.haveEllipse = false;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(800, 33);
            this.ustPanel.TabIndex = 0;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.Color.Red;
            this.customPictureBox1.borderBottomColor = System.Drawing.Color.White;
            this.customPictureBox1.borderBottomSize = 1;
            this.customPictureBox1.borderColor = System.Drawing.Color.White;
            this.customPictureBox1.borderLeftColor = System.Drawing.Color.White;
            this.customPictureBox1.borderLeftSize = 1;
            this.customPictureBox1.borderRightColor = System.Drawing.Color.White;
            this.customPictureBox1.borderRightSize = 1;
            this.customPictureBox1.borderSize = 1;
            this.customPictureBox1.borderTopColor = System.Drawing.Color.White;
            this.customPictureBox1.borderTopSize = 1;
            this.customPictureBox1.haveBorder = false;
            this.customPictureBox1.Location = new System.Drawing.Point(766, 0);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(34, 33);
            this.customPictureBox1.TabIndex = 0;
            this.customPictureBox1.TabStop = false;
            this.customPictureBox1.Click += new System.EventHandler(this.customPictureBox1_Click);
            // 
            // customPictureBox2
            // 
            this.customPictureBox2.BackColor = System.Drawing.Color.Cyan;
            this.customPictureBox2.borderBottomColor = System.Drawing.Color.White;
            this.customPictureBox2.borderBottomSize = 1;
            this.customPictureBox2.borderColor = System.Drawing.Color.White;
            this.customPictureBox2.borderLeftColor = System.Drawing.Color.White;
            this.customPictureBox2.borderLeftSize = 1;
            this.customPictureBox2.borderRightColor = System.Drawing.Color.White;
            this.customPictureBox2.borderRightSize = 1;
            this.customPictureBox2.borderSize = 1;
            this.customPictureBox2.borderTopColor = System.Drawing.Color.White;
            this.customPictureBox2.borderTopSize = 1;
            this.customPictureBox2.haveBorder = false;
            this.customPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.customPictureBox2.Name = "customPictureBox2";
            this.customPictureBox2.Size = new System.Drawing.Size(34, 33);
            this.customPictureBox2.TabIndex = 1;
            this.customPictureBox2.TabStop = false;
            this.customPictureBox2.Click += new System.EventHandler(this.customPictureBox2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ustPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SoliteraxControlLibrary.EllipseControl ellipseControl1;
        private SoliteraxControlLibrary.CustomPanel ustPanel;
        private SoliteraxControlLibrary.CustomPictureBox customPictureBox2;
        private SoliteraxControlLibrary.CustomPictureBox customPictureBox1;
    }
}

