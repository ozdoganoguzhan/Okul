using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSWinForms
{
    public partial class KullaniciEkleme : Form
    {
        public KullaniciEkleme()
        {
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_randevuEkle_Click(object sender, EventArgs e)
        {
            Veritabani vt = new Veritabani();

            if (tbox_kullaniciAdi.Text != "" && tbox_sifre.Text != "")
            {
                vt.kullaniciEkle(tbox_kullaniciAdi.Text, tbox_sifre.Text, cbox_rol.SelectedItem.ToString());
                this.Hide();

            }
            else MessageBox.Show("Kutucuklar boş olamaz!", "Hata!");

        }
    }
}
