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
    public partial class HastaEkleme : Form
    {
        public HastaEkleme()
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

            if (tbox_hastaAdi.Text != "" && tbox_hastaSoyadi.Text != "" && tbox_hastaTC.Text != "" && tbox_hastaTelefon.Text != "")
            {
                vt.hastaEkle(tbox_hastaTC.Text, tbox_hastaAdi.Text, tbox_hastaSoyadi.Text, tbox_hastaTelefon.Text);
                this.Hide();
            }
            else MessageBox.Show("Kutucuklar boş olamaz!", "Hata!");

        }
    }
}
