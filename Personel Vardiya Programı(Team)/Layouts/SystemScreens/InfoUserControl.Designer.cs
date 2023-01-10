namespace Personel_Vardiya_Programı_Team_.Layouts.SystemScreens
{
    partial class InfoUserControl
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
            this.date = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.Label();
            this.id3 = new System.Windows.Forms.Label();
            this.id4 = new System.Windows.Forms.Label();
            this.id5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date.Location = new System.Drawing.Point(12, 15);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(57, 23);
            this.date.TabIndex = 0;
            this.date.Text = "{date}";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id1.Location = new System.Drawing.Point(196, 15);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(35, 23);
            this.id1.TabIndex = 1;
            this.id1.Text = "{id}";
            this.id1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id2
            // 
            this.id2.AutoSize = true;
            this.id2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id2.Location = new System.Drawing.Point(380, 15);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(35, 23);
            this.id2.TabIndex = 2;
            this.id2.Text = "{id}";
            this.id2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id3
            // 
            this.id3.AutoSize = true;
            this.id3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id3.Location = new System.Drawing.Point(564, 15);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(35, 23);
            this.id3.TabIndex = 3;
            this.id3.Text = "{id}";
            this.id3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id4
            // 
            this.id4.AutoSize = true;
            this.id4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id4.Location = new System.Drawing.Point(748, 15);
            this.id4.Name = "id4";
            this.id4.Size = new System.Drawing.Size(35, 23);
            this.id4.TabIndex = 4;
            this.id4.Text = "{id}";
            this.id4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id5
            // 
            this.id5.AutoSize = true;
            this.id5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id5.Location = new System.Drawing.Point(932, 15);
            this.id5.Name = "id5";
            this.id5.Size = new System.Drawing.Size(35, 23);
            this.id5.TabIndex = 5;
            this.id5.Text = "{id}";
            this.id5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.id5);
            this.Controls.Add(this.id4);
            this.Controls.Add(this.id3);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.date);
            this.Name = "InfoUserControl";
            this.Size = new System.Drawing.Size(1043, 52);
            this.Load += new System.EventHandler(this.InfoUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label id2;
        private System.Windows.Forms.Label id3;
        private System.Windows.Forms.Label id4;
        private System.Windows.Forms.Label id5;
    }
}
