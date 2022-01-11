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
    public partial class AdminForm : Form
    {
        string filter = "";
        Veritabani vt = new Veritabani();
        public AdminForm()
        {
            InitializeComponent();
            randevuYenile();
            hastaYenile();
            kullaniciYenile();
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
            listView1.Items.Clear();
            DataTable tbl = vt.tableOku("hastaListesi");


            int j = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["HASTAADI"].ToString().ToLower().Contains(filter.ToLower()) ||
                    tbl.Rows[i]["HASTASOYADI"].ToString().ToLower().Contains(filter.ToLower()))
                {
                    listView1.Items.Add(tbl.Rows[i]["TC"].ToString());
                    listView1.Items[j].SubItems.Add(tbl.Rows[i]["HASTAADI"].ToString());
                    listView1.Items[j].SubItems.Add(tbl.Rows[i]["HASTASOYADI"].ToString());
                    listView1.Items[j].SubItems.Add(tbl.Rows[i]["TELEFON"].ToString());
                    j++;
                }

            }
        }

        private void kullaniciYenile(string filter = "")
        {
            kullaniciListView.Items.Clear();
            DataTable tbl = vt.tableOku("kullaniciListesi");


            int j = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["KULLANICIADI"].ToString().ToLower().Contains(filter.ToLower()) ||
                    tbl.Rows[i]["ROL"].ToString().ToLower().Contains(filter.ToLower()))
                {
                    kullaniciListView.Items.Add(tbl.Rows[i]["KULLANICIADI"].ToString());
                    kullaniciListView.Items[j].SubItems.Add(tbl.Rows[i]["SIFRE"].ToString());
                    kullaniciListView.Items[j].SubItems.Add(tbl.Rows[i]["ROL"].ToString());
                    j++;
                }

            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            randevuYenile();
            hastaYenile();
            kullaniciYenile();
        }

        private void btn_randevuSil_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (randevuListView.SelectedItems.Count > 0)
                {
                    var selection = randevuListView.SelectedItems[0];
                    vt.randevuSil(selection.SubItems[0].Text);
                    randevuYenile(filter);
                }
                else
                {
                    MessageBox.Show("Lütfen listeden bir randevu seçiniz.", "Hata!");
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (hastaListView.SelectedItems.Count > 0)
                {
                    var selection = hastaListView.SelectedItems[0];
                    vt.hastaSil(selection.SubItems[0].Text);
                    hastaYenile(filter);
                }
                else
                {
                    MessageBox.Show("Lütfen listeden bir hasta seçiniz.", "Hata!");
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (kullaniciListView.SelectedItems.Count > 0)
                {
                    var selection = hastaListView.SelectedItems[0];
                    vt.hastaSil(selection.SubItems[0].Text);
                    kullaniciYenile(filter);
                }
                else
                {
                    MessageBox.Show("Lütfen listeden bir kullanici seçiniz.", "Hata!");
                }
            }

        }

        private void btn_randevuEkle_Click(object sender, EventArgs e)
        {
            RandevuEkleme asd = new RandevuEkleme();
            asd.Show();
            randevuYenile();
        }

        private void btn_hastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkleme qwe = new HastaEkleme();
            qwe.Show();
            hastaYenile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter = textBox1.Text;
            hastaYenile(filter);
            randevuYenile(filter);
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            randevuYenile(filter);
            hastaYenile(filter);
            kullaniciYenile(filter);
        }

        private void btn_kullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkleme asd = new KullaniciEkleme();
            asd.Show();
        }
    }
}
