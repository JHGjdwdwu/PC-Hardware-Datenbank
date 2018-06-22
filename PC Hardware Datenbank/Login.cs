using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Hardware_Datenbank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//Programm Beenden
        {
            Application.Exit();
        }

        private void LoginFunktion()//LoginFunktion
        {
            int Logingwert = 0;

            if (txtName.Text == "Dima" && txtPassword.Text == "0000")//Benutzer für Dateneingabe
            {
                new Home_Imput().Show(this);
                this.Hide();
                txtName.Text = txtPassword.Text = null;
                Logingwert = 1;
            }

            if (txtName.Text == "dima" && txtPassword.Text == "0000")//Benutzer für Datenbetrachtung
            {
                new Home_Imput().Show(this);
                this.Hide();
                txtName.Text = txtPassword.Text = null;
                Logingwert = 1;
            }

            if (txtName.Text == "Admin" && txtPassword.Text == "sudo" || txtName.Text == "admin" && txtPassword.Text == "sudo")//Administrator
            {
                new Admin().Show(this);
                this.Hide();
                txtName.Text = txtPassword.Text = null;
                Logingwert = 1;
            }
            if(Logingwert != 1)
            {
                MessageBox.Show("Ungültiger Log-In!");
                txtName.Text = txtPassword.Text = null;
                txtName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)//Login
        {
            LoginFunktion();
        }

        private void Loging(object sender, KeyEventArgs e)//Loging bei Eingabe Taste
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginFunktion();
            }
        }
    }
}
