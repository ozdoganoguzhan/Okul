
namespace VTYSWinForms
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_randevular = new System.Windows.Forms.TabPage();
            this.randevuListView = new System.Windows.Forms.ListView();
            this.randevuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.islem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_hastalar = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastaListView = new System.Windows.Forms.ListView();
            this.tab_personel = new System.Windows.Forms.TabPage();
            this.tab_kullanicilar = new System.Windows.Forms.TabPage();
            this.btn_randevuEkle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_hastaEkle = new System.Windows.Forms.Button();
            this.kullaniciListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_islemEkle = new System.Windows.Forms.Button();
            this.btn_kullaniciEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_randevular.SuspendLayout();
            this.tab_hastalar.SuspendLayout();
            this.tab_kullanicilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_randevular);
            this.tabControl1.Controls.Add(this.tab_hastalar);
            this.tabControl1.Controls.Add(this.tab_personel);
            this.tabControl1.Controls.Add(this.tab_kullanicilar);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 414);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tab_randevular
            // 
            this.tab_randevular.Controls.Add(this.randevuListView);
            this.tab_randevular.Location = new System.Drawing.Point(4, 25);
            this.tab_randevular.Margin = new System.Windows.Forms.Padding(4);
            this.tab_randevular.Name = "tab_randevular";
            this.tab_randevular.Padding = new System.Windows.Forms.Padding(4);
            this.tab_randevular.Size = new System.Drawing.Size(851, 385);
            this.tab_randevular.TabIndex = 0;
            this.tab_randevular.Text = "Randevular";
            this.tab_randevular.UseVisualStyleBackColor = true;
            // 
            // randevuListView
            // 
            this.randevuListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.randevuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.randevuNo,
            this.tarih,
            this.disci,
            this.hasta,
            this.islem});
            this.randevuListView.HideSelection = false;
            this.randevuListView.Location = new System.Drawing.Point(-5, 0);
            this.randevuListView.Margin = new System.Windows.Forms.Padding(4);
            this.randevuListView.MultiSelect = false;
            this.randevuListView.Name = "randevuListView";
            this.randevuListView.Size = new System.Drawing.Size(852, 381);
            this.randevuListView.TabIndex = 1;
            this.randevuListView.UseCompatibleStateImageBehavior = false;
            this.randevuListView.View = System.Windows.Forms.View.Details;
            // 
            // randevuNo
            // 
            this.randevuNo.Text = "Randevu No";
            this.randevuNo.Width = 73;
            // 
            // tarih
            // 
            this.tarih.Text = "Tarih";
            this.tarih.Width = 118;
            // 
            // disci
            // 
            this.disci.Text = "Dişçi";
            this.disci.Width = 155;
            // 
            // hasta
            // 
            this.hasta.Text = "Hasta";
            this.hasta.Width = 157;
            // 
            // islem
            // 
            this.islem.Text = "İşlem";
            this.islem.Width = 133;
            // 
            // tab_hastalar
            // 
            this.tab_hastalar.Controls.Add(this.listView1);
            this.tab_hastalar.Controls.Add(this.hastaListView);
            this.tab_hastalar.Location = new System.Drawing.Point(4, 25);
            this.tab_hastalar.Margin = new System.Windows.Forms.Padding(4);
            this.tab_hastalar.Name = "tab_hastalar";
            this.tab_hastalar.Padding = new System.Windows.Forms.Padding(4);
            this.tab_hastalar.Size = new System.Drawing.Size(851, 385);
            this.tab_hastalar.TabIndex = 1;
            this.tab_hastalar.Text = "Hastalar";
            this.tab_hastalar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(852, 381);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik No";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta Adı";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hasta Soyadı";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 157;
            // 
            // hastaListView
            // 
            this.hastaListView.HideSelection = false;
            this.hastaListView.Location = new System.Drawing.Point(0, 0);
            this.hastaListView.Margin = new System.Windows.Forms.Padding(4);
            this.hastaListView.Name = "hastaListView";
            this.hastaListView.Size = new System.Drawing.Size(847, 386);
            this.hastaListView.TabIndex = 0;
            this.hastaListView.UseCompatibleStateImageBehavior = false;
            // 
            // tab_personel
            // 
            this.tab_personel.Location = new System.Drawing.Point(4, 25);
            this.tab_personel.Margin = new System.Windows.Forms.Padding(4);
            this.tab_personel.Name = "tab_personel";
            this.tab_personel.Size = new System.Drawing.Size(851, 385);
            this.tab_personel.TabIndex = 2;
            this.tab_personel.Text = "Personel";
            this.tab_personel.UseVisualStyleBackColor = true;
            // 
            // tab_kullanicilar
            // 
            this.tab_kullanicilar.Controls.Add(this.kullaniciListView);
            this.tab_kullanicilar.Location = new System.Drawing.Point(4, 25);
            this.tab_kullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.tab_kullanicilar.Name = "tab_kullanicilar";
            this.tab_kullanicilar.Size = new System.Drawing.Size(851, 385);
            this.tab_kullanicilar.TabIndex = 3;
            this.tab_kullanicilar.Text = "Kullanıcılar";
            this.tab_kullanicilar.UseVisualStyleBackColor = true;
            // 
            // btn_randevuEkle
            // 
            this.btn_randevuEkle.Location = new System.Drawing.Point(21, 446);
            this.btn_randevuEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_randevuEkle.Name = "btn_randevuEkle";
            this.btn_randevuEkle.Size = new System.Drawing.Size(123, 38);
            this.btn_randevuEkle.TabIndex = 1;
            this.btn_randevuEkle.Text = "Randevu Ekle";
            this.btn_randevuEkle.UseVisualStyleBackColor = true;
            this.btn_randevuEkle.Click += new System.EventHandler(this.btn_randevuEkle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(792, 446);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(77, 38);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_randevuSil_Click);
            // 
            // btn_hastaEkle
            // 
            this.btn_hastaEkle.Location = new System.Drawing.Point(152, 446);
            this.btn_hastaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hastaEkle.Name = "btn_hastaEkle";
            this.btn_hastaEkle.Size = new System.Drawing.Size(123, 38);
            this.btn_hastaEkle.TabIndex = 3;
            this.btn_hastaEkle.Text = "Hasta Ekle";
            this.btn_hastaEkle.UseVisualStyleBackColor = true;
            this.btn_hastaEkle.Click += new System.EventHandler(this.btn_hastaEkle_Click);
            // 
            // kullaniciListView
            // 
            this.kullaniciListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.kullaniciListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.kullaniciListView.HideSelection = false;
            this.kullaniciListView.Location = new System.Drawing.Point(0, 0);
            this.kullaniciListView.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciListView.MultiSelect = false;
            this.kullaniciListView.Name = "kullaniciListView";
            this.kullaniciListView.Size = new System.Drawing.Size(852, 381);
            this.kullaniciListView.TabIndex = 4;
            this.kullaniciListView.UseCompatibleStateImageBehavior = false;
            this.kullaniciListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kullanıcı Adı";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Şifre";
            this.columnHeader6.Width = 165;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rol";
            this.columnHeader7.Width = 155;
            // 
            // btn_islemEkle
            // 
            this.btn_islemEkle.Location = new System.Drawing.Point(283, 446);
            this.btn_islemEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_islemEkle.Name = "btn_islemEkle";
            this.btn_islemEkle.Size = new System.Drawing.Size(123, 38);
            this.btn_islemEkle.TabIndex = 4;
            this.btn_islemEkle.Text = "İşlem Ekle";
            this.btn_islemEkle.UseVisualStyleBackColor = true;
            // 
            // btn_kullaniciEkle
            // 
            this.btn_kullaniciEkle.Location = new System.Drawing.Point(414, 446);
            this.btn_kullaniciEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kullaniciEkle.Name = "btn_kullaniciEkle";
            this.btn_kullaniciEkle.Size = new System.Drawing.Size(123, 38);
            this.btn_kullaniciEkle.TabIndex = 5;
            this.btn_kullaniciEkle.Text = "Kullanıcı Ekle";
            this.btn_kullaniciEkle.UseVisualStyleBackColor = true;
            this.btn_kullaniciEkle.Click += new System.EventHandler(this.btn_kullaniciEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(544, 446);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(58, 38);
            this.btn_yenile.TabIndex = 7;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 498);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_kullaniciEkle);
            this.Controls.Add(this.btn_islemEkle);
            this.Controls.Add(this.btn_hastaEkle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_randevuEkle);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.tabControl1.ResumeLayout(false);
            this.tab_randevular.ResumeLayout(false);
            this.tab_hastalar.ResumeLayout(false);
            this.tab_kullanicilar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_randevular;
        private System.Windows.Forms.TabPage tab_hastalar;
        private System.Windows.Forms.ListView hastaListView;
        private System.Windows.Forms.ListView randevuListView;
        private System.Windows.Forms.ColumnHeader randevuNo;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader disci;
        private System.Windows.Forms.ColumnHeader hasta;
        private System.Windows.Forms.ColumnHeader islem;
        private System.Windows.Forms.Button btn_randevuEkle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_hastaEkle;
        private System.Windows.Forms.TabPage tab_personel;
        private System.Windows.Forms.TabPage tab_kullanicilar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView kullaniciListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_islemEkle;
        private System.Windows.Forms.Button btn_kullaniciEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_yenile;
    }
}