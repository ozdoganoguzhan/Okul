using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace VTYSWinForms
{
    public class Veritabani
    {

        OracleConnection dbc = new OracleConnection("Data Source=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-8K4GTPV)(PORT = 1521))" +
            "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" +
            "User Id= SYSTEM;Password=12345;");

        public Veritabani()
        {

        }

        public int giris(string kullaniciAdi, string sifre)
        {
            dbc.Open();

            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM kullaniciListesi WHERE kullaniciAdi='" + kullaniciAdi + "' AND sifre='" + sifre + "'", dbc);
            OracleDataAdapter ada = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();
            ada.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                OracleCommand cmd2 = new OracleCommand("SELECT Rol FROM kullaniciListesi WHERE kullaniciAdi='" + kullaniciAdi + "' AND sifre='" + sifre + "'", dbc);
                OracleDataAdapter ada2 = new OracleDataAdapter(cmd2);

                DataTable dt2 = new DataTable();
                ada2.Fill(dt2);
                dbc.Close();

                if (dt2.Rows[0][0].ToString() == "admin")
                {
                    return 3; 
                }
                else if (dt2.Rows[0][0].ToString() == "disci")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }

            }

            else
            {
                dbc.Close();
                return 0;
            }


        }

        public void randevuEkle(DateTime tarih, string disci, string hasta, string islem)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand(@"INSERT INTO randevuListesi 
                       (tarih, disci, hasta, islem)
                       VALUES(:p1,:p2,:p3,:p4)", dbc);
            cmd.Parameters.Add(new OracleParameter("p1", tarih));
            cmd.Parameters.Add(new OracleParameter("p2", disci));
            cmd.Parameters.Add(new OracleParameter("p3", hasta));
            cmd.Parameters.Add(new OracleParameter("p4", islem));


            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public void randevuSil(string id)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM randevuListesi WHERE randevuNo='" + id + "'", dbc);
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public DataTable tableOku(string table)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM " + table, dbc);
            OracleDataAdapter ada = new OracleDataAdapter(cmd);

            DataTable tbl = new DataTable();

            ada.Fill(tbl);
            dbc.Close();

            return tbl;
        }

        public void hastaEkle(string TC, string hastaAdi, string hastaSoyadi, string telefon)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand(@"INSERT INTO hastaListesi 
                       (TC, hastaAdi, hastaSoyadi, telefon)
                       VALUES(:p1,:p2,:p3,:p4)", dbc);
            cmd.Parameters.Add(new OracleParameter("p1", TC));
            cmd.Parameters.Add(new OracleParameter("p2", hastaAdi));
            cmd.Parameters.Add(new OracleParameter("p3", hastaSoyadi));
            cmd.Parameters.Add(new OracleParameter("p4", telefon));
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public void hastaSil(string hastaAdi)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM hastaListesi WHERE hastaAdi='" + hastaAdi + "'", dbc);
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public void kullaniciEkle(string kullaniciAdi, string sifre, string rol)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand(@"INSERT INTO kullaniciListesi 
                       (kullaniciAdi, sifre, rol)
                       VALUES(:p1,:p2,:p3)", dbc);
            cmd.Parameters.Add(new OracleParameter("p1", kullaniciAdi));
            cmd.Parameters.Add(new OracleParameter("p2", sifre));
            cmd.Parameters.Add(new OracleParameter("p3", rol));
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public void kullaniciSil(string kullaniciAdi)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM kullaniciListesi WHERE kullaniciAdi='" + kullaniciAdi + "'", dbc);
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        /*public Kullanici kullaniciClassOlustur(string kulAdi)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM kullaniciListesi WHERE kullaniciAdi='" + kulAdi + "'", dbc);
            OracleDataAdapter ada = new OracleDataAdapter(cmd);



            DataTable dt = new DataTable();
            ada.Fill(dt);

            Kullanici kullanici = new Kullanici(kulAdi);
            kullanici.setSifre(dt.Rows[0]["sifre"].ToString());
            kullanici.setTelefon(dt.Rows[0]["telefon"].ToString());
            kullanici.setAd(dt.Rows[0]["ad"].ToString());
            kullanici.setSoyad(dt.Rows[0]["soyad"].ToString());

            dbc.Close();

            return kullanici;
        }



        public void yetkiliSil(string yetkiliAdi)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM yetkililer WHERE yetkiliAdi='" + yetkiliAdi + "'", dbc);
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public void borcSil(string kulAdi)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM borcListesi WHERE kulAdi='" + kulAdi + "'", dbc);
            cmd.ExecuteNonQuery();
            dbc.Close();
        }

        public DataTable borclarim(string kulAdi)
        {
            dbc.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM borcListesi WHERE kullaniciAdi='" + kulAdi + "'", dbc);
            OracleDataAdapter ada = new OracleDataAdapter(cmd);

            DataTable tbl = new DataTable();

            ada.Fill(tbl);
            dbc.Close();

            return tbl;
        }

        public void oduncAl(string kulAdi, string kitapAdi, string id, string yazar, string yayinevi, string sayfa)
        {
            dbc.Open();

            OracleCommand cmd = new OracleCommand("INSERT INTO verilenKitaplar(id, kullaniciAdi, kitapAdi, verildigiTarih, sonTeslim, yazar, yayinevi, sayfa) " +
                "VALUES (@id, @kulAdi, @kitapAdi, @verTarih, @sonTeslim, @yazar, @yayinevi, @sayfa)", dbc);

            DateTime dateTime = DateTime.Now;
            string verTarih = dateTime.ToString("yyyy-MM-dd");
            string sonTeslim = dateTime.AddDays(14).ToString("yyyy-MM-dd");

            cmd.Parameters.AddWithValue("@id", int.Parse(id));
            cmd.Parameters.AddWithValue("@kulAdi", kulAdi);
            cmd.Parameters.AddWithValue("@kitapAdi", kitapAdi);
            cmd.Parameters.AddWithValue("@verTarih", verTarih);
            cmd.Parameters.AddWithValue("@sonTeslim", sonTeslim);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@yayinevi", yayinevi);
            cmd.Parameters.AddWithValue("@sayfa", sayfa);

            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM kitapListesi WHERE id = '" + id + "'";

            cmd.ExecuteNonQuery();

            dbc.Close();
        }

        public void iade(string id)
        {
            dbc.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM verilenKitaplar WHERE id='" + id + "'", dbc);
            OracleDataAdapter ada = new OracleDataAdapter(cmd);

            DataTable tbl = new DataTable();

            ada.Fill(tbl);

            cmd.CommandText = "INSERT INTO kitapListesi(id, kitapAdi, yazar, yayinevi, sayfa) " +
                "VALUES (@id, @kitapAdi, @yazar, @yayinevi, @sayfa)";

            cmd.Parameters.AddWithValue("@id", tbl.Rows[0]["id"].ToString());
            cmd.Parameters.AddWithValue("@kitapAdi", tbl.Rows[0]["kitapAdi"].ToString());
            cmd.Parameters.AddWithValue("@yazar", tbl.Rows[0]["yazar"].ToString());
            cmd.Parameters.AddWithValue("@yayinevi", tbl.Rows[0]["yayinevi"].ToString());
            cmd.Parameters.AddWithValue("@sayfa", tbl.Rows[0]["sayfa"].ToString());

            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM verilenKitaplar WHERE id='" + tbl.Rows[0]["id"].ToString() + "'";

            cmd.ExecuteNonQuery();

            dbc.Close();
        }*/

    }
}
