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
//14.08.18

namespace PC_Hardware_Datenbank
{
    public partial class Login : Form
    {
        string[] zellen = null;
        string Name = null;
        string Password = null;
        string Rechte = null;

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

            if (txtName.Text == "Admin" && txtPassword.Text == "sudo" || txtName.Text == "admin" && txtPassword.Text == "sudo")//Administrator
            {
                new Admin().Show(this);
                this.Hide();
                txtName.Text = txtPassword.Text = null;
                Logingwert = 1;
            }

            if (File.Exists(@"./User") == true)//Login von User Datei
            {
                int durchlauf = zellen.Length / 3;//Die Anzahl der möglichen User in der Datenbank
                int schritte = 3;//Array sprünge für die Bereiche Benuzernamme;Password;Rechte

                if (Logingwert == 0)//Abfragen ob sich der Admin erfolgreich eingelogt hat
                {
                    while (durchlauf > 1)//Login versuche begrenzen nicht mehr als es User in der Datenbank gibt
                    {
                        if (txtName.Text != Name || txtPassword.Text != Password)//Prüfen ob die Eingegebenen Daten stimmen
                        {
                            Name = zellen[0 + schritte];//Nechsten User aus der Datenbank lesen
                            Password = zellen[1 + schritte];//Nechstes Password zum Nechsten User lesen
                            Rechte = zellen[2 + schritte];//Nechste Rechte zum Nechsten User lesen
                            schritte = schritte + 3;//zum richtigen Array leiten
                        }
                        durchlauf--;
                    }
                }
                
                if (txtName.Text == Name && txtPassword.Text == Password)//Benutzer Rechte Prüfen und einlogen lasen
                {
                    if (Rechte == "lesen")//Rechte lesen
                    {
                        new Home_Imput().Show(this);
                        this.Hide();
                        txtName.Text = txtPassword.Text = null;
                        Logingwert = 1;
                    }

                    if (Rechte == "schreiben")//Rechte schreiben
                    {
                        new Home_Imput().Show(this);
                        this.Hide();
                        txtName.Text = txtPassword.Text = null;
                        Logingwert = 1;
                    }

                    if (Rechte == "root")//Rechte root
                    {
                        new Admin().Show(this);
                        this.Hide();
                        txtName.Text = txtPassword.Text = null;
                        Logingwert = 1;
                    }
                }
            }
            
            if(Logingwert != 1)//Wen der loging Versuch nicht erfolgreich ist
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

        private void Login_Load(object sender, EventArgs e)//Was beim erstelle der Fensters gemacht wird
        {

            try
            {
                if (File.Exists(@"./User") == true)
                {
                    Crypto_AES crypto = new Crypto_AES();
                    string verlusselt_text = File.ReadAllText(@"./User");//Verschlüsselten Text lesen
                    string unverslusselt_text = crypto.decrypt(verlusselt_text);//Text entschlüsseln
                    zellen = unverslusselt_text.Split(';');//Text teilen bei ;

                    if (unverslusselt_text == "")
                    {

                    }
                    else
                    {
                        Name = zellen[0];
                        Password = zellen[1];
                        Rechte = zellen[2];
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden noch keine User angelegt, nur der Administrator kann sich anmelden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }
}
