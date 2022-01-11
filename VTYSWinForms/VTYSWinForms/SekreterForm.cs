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
    public partial class SekreterForm : Form
    {
        string filter = "";
        Veritabani vt = new Veritabani();
        public SekreterForm()
        {
            InitializeComponent();
            randevuYenile();
            hastaYenile();
        }

        private void randevuYenile(string filter = "")
        {
            randevuListView.Items.Clear();
            DataTable tbl = vt.tableOku("randevuListesi");


            int j = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["DISCI"].ToString().ToLower().Contains(filter.ToLower()) ||
                    tbl.Rows[i]["HASTA"].ToString().ToLower().Contains(filter.ToLower()))
                {
                    randevuListView.Items.Add(tbl.Rows[i]["RANDEVUNO"].ToString());
                    randevuListView.Items[j].SubItems.Add(tbl.Rows[i]["TARIH"].ToString());
                    randevuListView.Items[j].SubItems.Add(tbl.Rows[i]["DISCI"].ToString());
                    randevuListView.Items[j].SubItems.Add(tbl.Rows[i]["HASTA"].ToString());
                    randevuListView.Items[j].SubItems.Add(tbl.Rows[i]["ISLEM"].ToString());
                    j++;
                }

            }
        }
        private void hastaYenile(string filter = "")
        {
            hastaListView.Items.Clear();
            DataTable tbl = vt.tableOku("hastaListesi");


            int j = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["HASTAADI"].ToString().ToLower().Contains(filter.ToLower()) ||
                    tbl.Rows[i]["HASTASOYADI"].ToString().ToLower().Contains(filter.ToLower()))
                {
                    hastaListView.Items.Add(tbl.Rows[i]["TC"].ToString());
                    hastaListView.Items[j].SubItems.Add(tbl.Rows[i]["HASTAADI"].ToString());
                    hastaListView.Items[j].SubItems.Add(tbl.Rows[i]["HASTASOYADI"].ToString());
                    hastaListView.Items[j].SubItems.Add(tbl.Rows[i]["TELEFON"].ToString());
                    j++;
                }

            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            randevuYenile();
            hastaYenile();
        }

        private void btn_randevuSil_Click(object sender, EventArgs e)
        {
            if (randevuListView.SelectedItems.Count > 0)
            {
                var selection = randevuListView.SelectedItems[0];
                vt.randevuSil(selection.SubItems[0].Text);
                randevuYenile();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir randevu seçiniz.", "Hata!");
            }
        }

        private void btn_randevuEkle_Click(object sender, EventArgs e)
        {
            RandevuEkleme asd = new RandevuEkleme();
            asd.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter = textBox1.Text;
            randevuYenile(filter);
            hastaYenile(filter);
        }

        private void btn_hastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkleme asd = new HastaEkleme();
            asd.Show();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            randevuYenile(filter);
            hastaYenile(filter);
        }
    }
}
