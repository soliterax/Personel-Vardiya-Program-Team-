using SoliteraxControlLibrary;
using System.Drawing;

namespace Personel_Vardiya_Programı_Team_.Layouts
{
    partial class UsersUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customButton1 = new SoliteraxControlLibrary.CustomButton();
            this.customButton2 = new SoliteraxControlLibrary.CustomButton();
            this.customButton3 = new SoliteraxControlLibrary.CustomButton();
            this.dataName = new SoliteraxControlLibrary.CustomTextBox();
            this.dataSurname = new SoliteraxControlLibrary.CustomTextBox();
            this.dataTelno = new SoliteraxControlLibrary.CustomTextBox();
            this.dataTarih = new SoliteraxControlLibrary.CustomTextBox();
            this.data = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataid = new SoliteraxControlLibrary.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton1.BorderColor = System.Drawing.Color.DarkViolet;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(1168, 609);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(200, 49);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Kaydet";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton2.BorderColor = System.Drawing.Color.DarkViolet;
            this.customButton2.BorderRadius = 15;
            this.customButton2.BorderSize = 2;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(47, 609);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(200, 49);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Geri Dön";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.customButton3.BorderColor = System.Drawing.Color.DarkViolet;
            this.customButton3.BorderRadius = 15;
            this.customButton3.BorderSize = 2;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(916, 609);
            this.customButton3.Margin = new System.Windows.Forms.Padding(4);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(200, 49);
            this.customButton3.TabIndex = 3;
            this.customButton3.Text = "Sil";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // dataName
            // 
            this.dataName.BackColor = System.Drawing.SystemColors.Window;
            this.dataName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dataName.BorderRadius = 0;
            this.dataName.BorderSize = 2;
            this.dataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataName.LeftImage = null;
            this.dataName.Location = new System.Drawing.Point(462, 537);
            this.dataName.Margin = new System.Windows.Forms.Padding(4);
            this.dataName.Multiline = false;
            this.dataName.Name = "dataName";
            this.dataName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dataName.PasswordChar = false;
            this.dataName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dataName.PlaceholderText = "Name";
            this.dataName.RightImage = null;
            this.dataName.Size = new System.Drawing.Size(155, 35);
            this.dataName.TabIndex = 4;
            this.dataName.Texts = "";
            this.dataName.UnderlinedStyle = false;
            this.dataName.TextChanged += new System.EventHandler(this.customtextBox_TextChanged);
            // 
            // dataSurname
            // 
            this.dataSurname.BackColor = System.Drawing.SystemColors.Window;
            this.dataSurname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataSurname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dataSurname.BorderRadius = 0;
            this.dataSurname.BorderSize = 2;
            this.dataSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataSurname.LeftImage = null;
            this.dataSurname.Location = new System.Drawing.Point(714, 537);
            this.dataSurname.Margin = new System.Windows.Forms.Padding(4);
            this.dataSurname.Multiline = false;
            this.dataSurname.Name = "dataSurname";
            this.dataSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dataSurname.PasswordChar = false;
            this.dataSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dataSurname.PlaceholderText = "Surname";
            this.dataSurname.RightImage = null;
            this.dataSurname.Size = new System.Drawing.Size(155, 35);
            this.dataSurname.TabIndex = 5;
            this.dataSurname.Texts = "";
            this.dataSurname.UnderlinedStyle = false;
            this.dataSurname._TextChanged += new System.EventHandler(this.customtextBox1_TextChanged);
            // 
            // dataTelno
            // 
            this.dataTelno.BackColor = System.Drawing.SystemColors.Window;
            this.dataTelno.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataTelno.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dataTelno.BorderRadius = 0;
            this.dataTelno.BorderSize = 2;
            this.dataTelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTelno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataTelno.LeftImage = null;
            this.dataTelno.Location = new System.Drawing.Point(961, 537);
            this.dataTelno.Margin = new System.Windows.Forms.Padding(4);
            this.dataTelno.Multiline = false;
            this.dataTelno.Name = "dataTelno";
            this.dataTelno.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dataTelno.PasswordChar = false;
            this.dataTelno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dataTelno.PlaceholderText = "Phone";
            this.dataTelno.RightImage = null;
            this.dataTelno.Size = new System.Drawing.Size(155, 35);
            this.dataTelno.TabIndex = 6;
            this.dataTelno.Texts = "";
            this.dataTelno.UnderlinedStyle = false;
            // 
            // dataTarih
            // 
            this.dataTarih.BackColor = System.Drawing.SystemColors.Window;
            this.dataTarih.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataTarih.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dataTarih.BorderRadius = 0;
            this.dataTarih.BorderSize = 2;
            this.dataTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataTarih.LeftImage = null;
            this.dataTarih.Location = new System.Drawing.Point(1213, 537);
            this.dataTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dataTarih.Multiline = false;
            this.dataTarih.Name = "dataTarih";
            this.dataTarih.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dataTarih.PasswordChar = false;
            this.dataTarih.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dataTarih.PlaceholderText = "Birthday";
            this.dataTarih.RightImage = null;
            this.dataTarih.Size = new System.Drawing.Size(155, 35);
            this.dataTarih.TabIndex = 7;
            this.dataTarih.Texts = "";
            this.dataTarih.UnderlinedStyle = false;
            // 
            // data
            // 
            this.data.AllowCustomTheming = false;
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.ColumnHeadersHeight = 40;
            this.data.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.data.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.data.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.data.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.data.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.data.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.data.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.data.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.data.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.data.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data.CurrentTheme.Name = null;
            this.data.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.data.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.data.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.data.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.data.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle3;
            this.data.EnableHeadersVisualStyles = false;
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.data.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.data.HeaderBgColor = System.Drawing.Color.Empty;
            this.data.HeaderForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(27, 24);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 40;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(1383, 458);
            this.data.StandardTab = true;
            this.data.TabIndex = 8;
            this.data.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // dataid
            // 
            this.dataid.BackColor = System.Drawing.SystemColors.Window;
            this.dataid.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataid.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dataid.BorderRadius = 0;
            this.dataid.BorderSize = 2;
            this.dataid.Enabled = false;
            this.dataid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataid.LeftImage = null;
            this.dataid.Location = new System.Drawing.Point(220, 537);
            this.dataid.Margin = new System.Windows.Forms.Padding(4);
            this.dataid.Multiline = false;
            this.dataid.Name = "dataid";
            this.dataid.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dataid.PasswordChar = false;
            this.dataid.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dataid.PlaceholderText = "ID";
            this.dataid.RightImage = null;
            this.dataid.Size = new System.Drawing.Size(155, 35);
            this.dataid.TabIndex = 9;
            this.dataid.Texts = "";
            this.dataid.UnderlinedStyle = false;
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.dataid);
            this.Controls.Add(this.data);
            this.Controls.Add(this.dataTarih);
            this.Controls.Add(this.dataTelno);
            this.Controls.Add(this.dataSurname);
            this.Controls.Add(this.dataName);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersUserControl";
            this.Size = new System.Drawing.Size(1436, 704);
            this.Load += new System.EventHandler(this.UsersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SoliteraxControlLibrary.CustomButton customButton1;
        private SoliteraxControlLibrary.CustomButton customButton2;
        private SoliteraxControlLibrary.CustomButton customButton3;
        private SoliteraxControlLibrary.CustomTextBox dataName;
        private SoliteraxControlLibrary.CustomTextBox dataSurname;
        private SoliteraxControlLibrary.CustomTextBox dataTelno;
        private SoliteraxControlLibrary.CustomTextBox dataTarih;
        private Bunifu.UI.WinForms.BunifuDataGridView data;
        private SoliteraxControlLibrary.CustomTextBox dataid;
    }
}
