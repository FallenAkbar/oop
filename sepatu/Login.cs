using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sepatu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                MessageBox.Show("Login Berhasil!", "login");
            }
            else
            {
                username.Focus();
                username.Clear();
                password.Clear();
                MessageBox.Show("login gagal", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
