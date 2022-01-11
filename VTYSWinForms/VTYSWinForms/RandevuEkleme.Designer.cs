
namespace VTYSWinForms
{
    partial class RandevuEkleme
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
            this.tbox_disci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.tbox_hasta = new System.Windows.Forms.TextBox();
            this.tbox_islem = new System.Windows.Forms.TextBox();
            this.btn_randevuEkle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_disci
            // 
            this.tbox_disci.Location = new System.Drawing.Point(109, 40);
            this.tbox_disci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox_disci.Name = "tbox_disci";
            this.tbox_disci.Size = new System.Drawing.Size(236, 22);
            this.tbox_disci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "İşlem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dişçi:";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(109, 8);
            this.dtp_tarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(236, 22);
            this.dtp_tarih.TabIndex = 7;
            // 
            // tbox_hasta
            // 
            this.tbox_hasta.Location = new System.Drawing.Point(109, 72);
            this.tbox_hasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox_hasta.Name = "tbox_hasta";
            this.tbox_hasta.Size = new System.Drawing.Size(236, 22);
            this.tbox_hasta.TabIndex = 8;
            // 
            // tbox_islem
            // 
            this.tbox_islem.Location = new System.Drawing.Point(109, 104);
            this.tbox_islem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox_islem.Name = "tbox_islem";
            this.tbox_islem.Size = new System.Drawing.Size(236, 22);
            this.tbox_islem.TabIndex = 9;
            // 
            // btn_randevuEkle
            // 
            this.btn_randevuEkle.Location = new System.Drawing.Point(18, 143);
            this.btn_randevuEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_randevuEkle.Name = "btn_randevuEkle";
            this.btn_randevuEkle.Size = new System.Drawing.Size(120, 36);
            this.btn_randevuEkle.TabIndex = 10;
            this.btn_randevuEkle.Text = "Randevu Ekle";
            this.btn_randevuEkle.UseVisualStyleBackColor = true;
            this.btn_randevuEkle.Click += new System.EventHandler(this.btn_randevuEkle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(226, 143);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(120, 36);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // RandevuEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 196);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_randevuEkle);
            this.Controls.Add(this.tbox_islem);
            this.Controls.Add(this.tbox_hasta);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_disci);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RandevuEkleme";
            this.Text = "Randevu Ekleme";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_disci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.TextBox tbox_hasta;
        private System.Windows.Forms.TextBox tbox_islem;
        private System.Windows.Forms.Button btn_randevuEkle;
        private System.Windows.Forms.Button btn_iptal;
    }
}