
namespace VTYSWinForms
{
    partial class SekreterForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.randevuListView = new System.Windows.Forms.ListView();
            this.randevuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.islem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hastaListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_randevuEkle = new System.Windows.Forms.Button();
            this.btn_randevuSil = new System.Windows.Forms.Button();
            this.btn_hastaEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 414);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.randevuListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(851, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Randevular";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hastaListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(851, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hastalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hastaListView
            // 
            this.hastaListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.hastaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.hastaListView.HideSelection = false;
            this.hastaListView.Location = new System.Drawing.Point(-1, 0);
            this.hastaListView.Margin = new System.Windows.Forms.Padding(4);
            this.hastaListView.MultiSelect = false;
            this.hastaListView.Name = "hastaListView";
            this.hastaListView.Size = new System.Drawing.Size(852, 381);
            this.hastaListView.TabIndex = 2;
            this.hastaListView.UseCompatibleStateImageBehavior = false;
            this.hastaListView.View = System.Windows.Forms.View.Details;
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
            // btn_randevuSil
            // 
            this.btn_randevuSil.Location = new System.Drawing.Point(747, 446);
            this.btn_randevuSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_randevuSil.Name = "btn_randevuSil";
            this.btn_randevuSil.Size = new System.Drawing.Size(123, 38);
            this.btn_randevuSil.TabIndex = 2;
            this.btn_randevuSil.Text = "Kaydı Sil";
            this.btn_randevuSil.UseVisualStyleBackColor = true;
            this.btn_randevuSil.Click += new System.EventHandler(this.btn_randevuSil_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(282, 446);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(58, 38);
            this.btn_yenile.TabIndex = 8;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // SekreterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 495);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_hastaEkle);
            this.Controls.Add(this.btn_randevuSil);
            this.Controls.Add(this.btn_randevuEkle);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SekreterForm";
            this.Text = "SekreterForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView randevuListView;
        private System.Windows.Forms.ColumnHeader randevuNo;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader disci;
        private System.Windows.Forms.ColumnHeader hasta;
        private System.Windows.Forms.ColumnHeader islem;
        private System.Windows.Forms.Button btn_randevuEkle;
        private System.Windows.Forms.Button btn_randevuSil;
        private System.Windows.Forms.Button btn_hastaEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView hastaListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_yenile;
    }
}