namespace Personel_Vardiya_Programı_Team_.Layouts
{
    partial class UserControl1
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
            this.customLabel1 = new SoliteraxControlLibrary.CustomLabel();
            this.SuspendLayout();
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.borderBottomColor = System.Drawing.Color.White;
            this.customLabel1.borderBottomSize = 1;
            this.customLabel1.BorderColor = System.Drawing.Color.White;
            this.customLabel1.borderLeftColor = System.Drawing.Color.White;
            this.customLabel1.borderLeftSize = 1;
            this.customLabel1.borderRightColor = System.Drawing.Color.White;
            this.customLabel1.borderRightSize = 1;
            this.customLabel1.BorderSize = 1;
            this.customLabel1.borderTopColor = System.Drawing.Color.White;
            this.customLabel1.borderTopSize = 1;
            this.customLabel1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(348, 50);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(256, 38);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "Tekrar Hoşgeldiniz";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.customLabel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1077, 572);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoliteraxControlLibrary.CustomLabel customLabel1;
    }
}
