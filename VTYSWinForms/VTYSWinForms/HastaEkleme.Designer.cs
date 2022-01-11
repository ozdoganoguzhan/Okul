
namespace VTYSWinForms
{
    partial class HastaEkleme
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
            this.tbox_hastaSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_hastaTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_hastaTelefon = new System.Windows.Forms.TextBox();
            this.btn_randevuEkle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.tbox_hastaAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_hastaSoyadi
            // 
            this.tbox_hastaSoyadi.Location = new System.Drawing.Point(130, 80);
            this.tbox_hastaSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_hastaSoyadi.Name = "tbox_hastaSoyadi";
            this.tbox_hastaSoyadi.Size = new System.Drawing.Size(236, 22);
            this.tbox_hastaSoyadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Adı:";
            // 
            // tbox_hastaTC
            // 
            this.tbox_hastaTC.Location = new System.Drawing.Point(130, 20);
            this.tbox_hastaTC.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_hastaTC.Name = "tbox_hastaTC";
            this.tbox_hastaTC.Size = new System.Drawing.Size(236, 22);
            this.tbox_hastaTC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hasta Soyadı:";
            // 
            // tbox_hastaTelefon
            // 
            this.tbox_hastaTelefon.Location = new System.Drawing.Point(130, 110);
            this.tbox_hastaTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_hastaTelefon.Name = "tbox_hastaTelefon";
            this.tbox_hastaTelefon.Size = new System.Drawing.Size(236, 22);
            this.tbox_hastaTelefon.TabIndex = 8;
            // 
            // btn_randevuEkle
            // 
            this.btn_randevuEkle.Location = new System.Drawing.Point(16, 152);
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
            this.btn_iptal.Location = new System.Drawing.Point(246, 152);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(120, 36);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // tbox_hastaAdi
            // 
            this.tbox_hastaAdi.Location = new System.Drawing.Point(130, 50);
            this.tbox_hastaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_hastaAdi.Name = "tbox_hastaAdi";
            this.tbox_hastaAdi.Size = new System.Drawing.Size(236, 22);
            this.tbox_hastaAdi.TabIndex = 12;
            // 
            // HastaEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 201);
            this.Controls.Add(this.tbox_hastaAdi);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_randevuEkle);
            this.Controls.Add(this.tbox_hastaTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_hastaTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_hastaSoyadi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HastaEkleme";
            this.Text = "Hasta Kaydı";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_hastaSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_hastaTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_hastaTelefon;
        private System.Windows.Forms.Button btn_randevuEkle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.TextBox tbox_hastaAdi;
    }
}