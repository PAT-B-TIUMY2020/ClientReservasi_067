using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20180140067
{
    public partial class Login : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = service.Login(username, password);

            if (kategori == "Admin")
            {
                Register register = new Register();
                this.Hide();
                register.Show();
            }
            else if (kategori == "Resepsionis")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password Tidak Cocok! Silahkan Hubungi Admin.");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }
    }
}
