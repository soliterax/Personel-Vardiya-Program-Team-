namespace Personel_Vardiya_Programı_Team_
{
    partial class SetupForm
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
            this.customLabel2 = new SoliteraxControlLibrary.CustomLabel();
            this.customLabel1 = new SoliteraxControlLibrary.CustomLabel();
            this.customProgressbar1 = new SoliteraxControlLibrary.CustomProgressbar();
            this.SuspendLayout();
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.borderBottomColor = System.Drawing.Color.White;
            this.customLabel2.borderBottomSize = 1;
            this.customLabel2.BorderColor = System.Drawing.Color.White;
            this.customLabel2.borderLeftColor = System.Drawing.Color.White;
            this.customLabel2.borderLeftSize = 1;
            this.customLabel2.borderRightColor = System.Drawing.Color.White;
            this.customLabel2.borderRightSize = 1;
            this.customLabel2.BorderSize = 1;
            this.customLabel2.borderTopColor = System.Drawing.Color.White;
            this.customLabel2.borderTopSize = 1;
            this.customLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customLabel2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.customLabel2.Location = new System.Drawing.Point(12, 372);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(219, 23);
            this.customLabel2.TabIndex = 1;
            this.customLabel2.Text = "Kurulum için Hazırlanılıyor...";
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
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(209, 45);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(361, 31);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "Personel Vardiya Programı";
            // 
            // customProgressbar1
            // 
            this.customProgressbar1.AnimateSpeed = 0;
            this.customProgressbar1.borderBottomColor = System.Drawing.Color.White;
            this.customProgressbar1.borderBottomSize = 1;
            this.customProgressbar1.borderColor = System.Drawing.Color.White;
            this.customProgressbar1.borderLeftColor = System.Drawing.Color.White;
            this.customProgressbar1.borderLeftSize = 1;
            this.customProgressbar1.borderRadius = 30;
            this.customProgressbar1.borderRightColor = System.Drawing.Color.White;
            this.customProgressbar1.borderRightSize = 1;
            this.customProgressbar1.borderSize = 1;
            this.customProgressbar1.borderTopColor = System.Drawing.Color.White;
            this.customProgressbar1.borderTopSize = 1;
            this.customProgressbar1.haveBorder = false;
            this.customProgressbar1.haveEllipse = false;
            this.customProgressbar1.IsAnimated = false;
            this.customProgressbar1.IsShowText = false;
            this.customProgressbar1.Location = new System.Drawing.Point(16, 407);
            this.customProgressbar1.Name = "customProgressbar1";
            this.customProgressbar1.ProgressFinishColor = System.Drawing.Color.Green;
            this.customProgressbar1.ProgressStartColor = System.Drawing.Color.Yellow;
            this.customProgressbar1.ProgressStopColor = System.Drawing.Color.Red;
            this.customProgressbar1.ProgressValue = 1;
            this.customProgressbar1.Size = new System.Drawing.Size(772, 10);
            this.customProgressbar1.TabIndex = 2;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customProgressbar1);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetupForm";
            this.Text = "SetupForm";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoliteraxControlLibrary.CustomLabel customLabel1;
        private SoliteraxControlLibrary.CustomLabel customLabel2;
        private SoliteraxControlLibrary.CustomProgressbar customProgressbar1;
    }
}