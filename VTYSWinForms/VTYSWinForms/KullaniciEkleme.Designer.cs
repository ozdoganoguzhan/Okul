
namespace VTYSWinForms
{
    partial class KullaniciEkleme
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
            this.tbox_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_randevuEkle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.cbox_rol = new System.Windows.Forms.ComboBox();
            this.tbox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_sifre
            // 
            this.tbox_sifre.Location = new System.Drawing.Point(127, 56);
            this.tbox_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_sifre.Name = "tbox_sifre";
            this.tbox_sifre.Size = new System.Drawing.Size(236, 22);
            this.tbox_sifre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre:";
            // 
            // btn_randevuEkle
            // 
            this.btn_randevuEkle.Location = new System.Drawing.Point(13, 128);
            this.btn_randevuEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_randevuEkle.Name = "btn_randevuEkle";
            this.btn_randevuEkle.Size = new System.Drawing.Size(120, 36);
            this.btn_randevuEkle.TabIndex = 10;
            this.btn_randevuEkle.Text = "Hasta Kaydet";
            this.btn_randevuEkle.UseVisualStyleBackColor = true;
            this.btn_randevuEkle.Click += new System.EventHandler(this.btn_randevuEkle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(243, 128);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(120, 36);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // cbox_rol
            // 
            this.cbox_rol.FormattingEnabled = true;
            this.cbox_rol.Items.AddRange(new object[] {
            "sekreter",
            "disci",
            "admin"});
            this.cbox_rol.Location = new System.Drawing.Point(127, 85);
            this.cbox_rol.Name = "cbox_rol";
            this.cbox_rol.Size = new System.Drawing.Size(236, 24);
            this.cbox_rol.TabIndex = 13;
            // 
            // tbox_kullaniciAdi
            // 
            this.tbox_kullaniciAdi.Location = new System.Drawing.Point(127, 26);
            this.tbox_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_kullaniciAdi.Name = "tbox_kullaniciAdi";
            this.tbox_kullaniciAdi.Size = new System.Drawing.Size(236, 22);
            this.tbox_kullaniciAdi.TabIndex = 12;
            // 
            // KullaniciEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 179);
            this.Controls.Add(this.cbox_rol);
            this.Controls.Add(this.tbox_kullaniciAdi);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_randevuEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_sifre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciEkleme";
            this.Text = "Hasta Kaydı";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_randevuEkle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.ComboBox cbox_rol;
        private System.Windows.Forms.TextBox tbox_kullaniciAdi;
    }
}