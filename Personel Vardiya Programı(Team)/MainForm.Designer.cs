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
            this.ustPanel = new SoliteraxControlLibrary.CustomPanel();
            this.headerText = new SoliteraxControlLibrary.CustomLabel();
            this.ellipseControl1 = new SoliteraxControlLibrary.EllipseControl();
            this.componentHover1 = new SoliteraxControlLibrary.ComponentHover();
            this.loginUserControl1 = new Personel_Vardiya_Programı_Team_.Layouts.LoginUserControl();
            this.FormMinimize = new SoliteraxControlLibrary.CustomPictureBox();
            this.FormClose = new SoliteraxControlLibrary.CustomPictureBox();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ustPanel.borderBottomColor = System.Drawing.Color.White;
            this.ustPanel.borderBottomSize = 2;
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
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1077, 33);
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
            this.headerText.Location = new System.Drawing.Point(40, 6);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(195, 20);
            this.headerText.TabIndex = 2;
            this.headerText.Text = "Personel Vardiya Programı";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // componentHover1
            // 
            this.componentHover1.ReferencedControl = this.ustPanel;
            this.componentHover1.TargetControl = this;
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.loginUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUserControl1.Location = new System.Drawing.Point(0, 33);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(1077, 572);
            this.loginUserControl1.TabIndex = 1;
            this.loginUserControl1.Load += new System.EventHandler(this.loginUserControl1_Load);
            // 
            // FormMinimize
            // 
            this.FormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormMinimize.BackColor = System.Drawing.Color.Cyan;
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
            this.FormMinimize.Location = new System.Drawing.Point(991, 0);
            this.FormMinimize.Name = "FormMinimize";
            this.FormMinimize.Size = new System.Drawing.Size(34, 33);
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
            this.FormClose.Location = new System.Drawing.Point(1031, 0);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(34, 33);
            this.FormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormClose.TabIndex = 0;
            this.FormClose.TabStop = false;
            this.FormClose.Click += new System.EventHandler(this.customPictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1077, 605);
            this.Controls.Add(this.loginUserControl1);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SoliteraxControlLibrary.EllipseControl ellipseControl1;
        private SoliteraxControlLibrary.CustomPanel ustPanel;
        private SoliteraxControlLibrary.CustomPictureBox FormClose;
        private SoliteraxControlLibrary.CustomLabel headerText;
        private SoliteraxControlLibrary.CustomPictureBox FormMinimize;
        private SoliteraxControlLibrary.ComponentHover componentHover1;
        private Layouts.LoginUserControl loginUserControl1;
    }
}

