using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//22.06.19

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
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Bitte geben Sie das Password an!");
                txtPassword.Focus();
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Bitte geben Sie den Benutzernamen an!");
                txtName.Focus();
            }

            if (txtName.Text != "" && txtPassword.Text != "")//Benutzer Rechte Prüfen und einlogen lasen
            {
                Methoden methoden = new Methoden();
                string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan

                string hash = methoden.StringToSha512(txtPassword.Text);//erzeugt ein Hash vom Password

                string mysqlcommandtext = "SELECT * FROM `user` WHERE `Name`='" + txtName.Text + "'AND`Password`='" + hash + "';";//SQL Abfrage Befehl: suche User und key
                string[] daten = methoden.MySqlToString(mysqlconnectionstring, mysqlcommandtext);//Daten abfragen und in ein Array schreiben {User,Passwored,Rechte}
                Speicher.rechte = daten[2];//Globalle Variable zum bestimmen was auf der Form zu sehen ist

                if (daten[0]!=txtName.Text || daten[1] != hash)
                {
                    MessageBox.Show("" +
                        "Der Benutzer konnte nicht gefunden werden oder \r\n" +
                        "das Passwort ist falsch! \r\n" +
                        "Bitte achten Sie auf groß und kleinschreibung!");
                    txtName.Text = txtPassword.Text = null;
                    txtName.Focus();
                }

                if (daten[2] == "lesen")//Rechte lesen
                {
                    new Home_Suche().Show(this);
                    this.Hide();
                    txtName.Text = txtPassword.Text = null;
                }

                if (daten[2] == "schreiben")//Rechte schreiben
                {
                    new Home_Imput().Show(this);
                    this.Hide();
                    txtName.Text = txtPassword.Text = null;
                }

                if (daten[2] == "root")//Rechte root
                {
                    new Admin().Show(this);
                    this.Hide();
                    txtName.Text = txtPassword.Text = null;
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }

    static class Speicher//Speicher für Daten die Global sind
    {
        public static string rechte = null;//Globalle Variable zum bestimmen was auf der Form zu sehen ist
    }
}
