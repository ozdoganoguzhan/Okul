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
    public partial class RandevuEkleme : Form
    {
        public RandevuEkleme()
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

            if (tbox_disci.Text != "" && tbox_hasta.Text != "" && tbox_islem.Text != "")
            {
                vt.randevuEkle(dtp_tarih.Value, tbox_disci.Text, tbox_hasta.Text, tbox_islem.Text);
                this.Hide();
            }
            else MessageBox.Show("Kutucuklar boş olamaz!", "Hata!");

        }
    }
}
