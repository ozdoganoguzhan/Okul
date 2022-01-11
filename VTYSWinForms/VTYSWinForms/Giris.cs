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
    public partial class Giris : Form
    {
        Veritabani vt = new Veritabani();
        public Giris()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            int rol = vt.giris(username, password);
            switch (rol)
            {
                case 1:
                    SekreterForm sekreterForm = new SekreterForm();
                    sekreterForm.Show();
                    this.Hide();
                    break;
                case 2:
                    break;
                case 3:
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Kullanıcı adı veya parola hatalı!");
                    break;
            }
        }
    }
}
