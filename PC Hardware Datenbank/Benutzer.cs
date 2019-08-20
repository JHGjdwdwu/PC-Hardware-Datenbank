using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PC_Hardware_Datenbank
{
    public partial class Benutzer : Form
    {
        public Benutzer()
        {
            InitializeComponent();
        }

        Methoden methoden = new Methoden();//Class eigene Methoden
        string[] UKR = new string[3];//User,Key,Recht

        private void Benutzer_Load(object sender, EventArgs e)//Ausfüren wen Fenster geöffnet wird
        {
            wtxtRechte.Text = "lesen";//Standart auswahl ist lesen
            string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
            methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
            string mysqlcommandtext = "SELECT * FROM `user`;";//SQL Befehl Abfrage aller User
            dgvUser.DataSource = methoden.MySqlDataToDatGrid(mysqlconnectionstring, mysqlcommandtext);//Alle User in die DataGridViwe schreiben
            dgvUser.Columns["Password"].Visible = false;//Spalte mit den Passwörten ausblenden
        }

        private void cmdSchliessen_Click(object sender, EventArgs e)//Button Schließen
        {
            Close();
        }

        private void cmdErstellen_Click(object sender, EventArgs e)//Button Erstellen
        {
            if (cmdErstellen.Text== "&Erstellen")
            {
                if (txtName.Text != "" && txtPassword.Text != "" && wtxtRechte.Text != "")
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan

                    string mysqlcommandtext = "SELECT * FROM `user` WHERE `Name`='" + txtName.Text + "';";//SQL Befehl Abfrage ob es den User schon giebt
                    string bit = methoden.MySqlToString(mysqlconnectionstring, mysqlcommandtext)[0];//Daten in die Datenbank schreiben

                    if (bit==null)
                    {
                        string hash = methoden.StringToSha512(txtPassword.Text);//erzeugt ein Hash vom Password

                        mysqlcommandtext = "INSERT INTO `user` (`Name`, `Password`, `Rechte`) VALUES ('" + txtName.Text + "', '" + hash + "', '" + wtxtRechte.Text + "');";//SQL Befehl Abfrage aller User
                        methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                        txtName.Text = txtPassword.Text = null;//Eigegebenen Text löschen
                        txtName.Focus();//Tabstop auf das Textfeld Name setzen
                        Benutzer_Load(cmdErstellen, e);//Daten mit den User aus der Datenbank neu auslesen
                    }
                    else
                    {
                        MessageBox.Show("Es giebt bereits einen Benuzer mit dem Namen!\r\nBitte geben Sie einen anderen Namen an.","Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bitte gebe einen Benuzernamen, Passwort und das Recht an!");
                }
            }
            if (cmdErstellen.Text == "&Ändern")
            {
                string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan



                string mysqlcommandtext = "UPDATE `user` SET `Name`='" + txtName.Text + "',`Password`='" + txtPassword.Text + "',`Rechte`='" + wtxtRechte.Text + "' WHERE `Name`='" + UKR[0] + "'AND`Password`='" + UKR[1] + "'AND`Rechte`='" + UKR[2] + "';";//SQL Befehl Abfrage aller User
                methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                txtName.Text = txtPassword.Text = null;//Eigegebenen Text löschen
                txtName.Focus();//Tabstop auf das Textfeld Name setzen
                Benutzer_Load(cmdErstellen, e);//Daten mit den User aus der Datenbank neu auslesen
            }
        }

        private void cmdLoschen_Click(object sender, EventArgs e)//Button Löschen
        {
            int anz = dgvUser.ColumnCount;//Anzahl der Spalten in der DataGridViwe ermitelln
            string[] Cellen = new string[anz];//Array erzeugen mit der Anzahl der Spalten
            for (int i = 0; i < anz; i++)//Makirte Zeile Spalte nach Spalte abarbeiten
            {
                string Celle = Convert.ToString(dgvUser.SelectedRows[0].Cells[i].Value);//Die Daten aus der Zehle ermitteln
                Cellen[i] = Celle;//Daten in das Array schreiben
            }
            string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
            methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
            string mysqlcommandtext = "DELETE FROM `user` WHERE `Name`='" + Cellen[0] + "'AND`Password`='" + Cellen[1] + "'AND`Rechte`='" + Cellen[2] + "';";//SQL Befehl Abfrage aller User
            methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//User aus der Datenbank löschen
            Benutzer_Load(cmdErstellen, e);//Daten mit den User aus der Datenbank neu auslesen
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            int anz = dgvUser.ColumnCount;//Anzahl der Spalten in der DataGridViwe ermitelln
            string[] Cellen = new string[anz];//Array erzeugen mit der Anzahl der Spalten
            for (int i = 0; i < anz; i++)//Makirte Zeile Spalte nach Spalte abarbeiten
            {
                string Celle = Convert.ToString(dgvUser.SelectedRows[0].Cells[i].Value);//Die Daten aus der Zehle ermitteln
                Cellen[i] = Celle;//Daten in das Array schreiben
            }
            UKR = Cellen;
            txtName.Text = Cellen[0];
            txtPassword.Text = Cellen[1];
            wtxtRechte.Text = Cellen[2];

            cmdErstellen.Text = "&Ändern";

            if (txtName.Text=="" || txtPassword.Text=="")
            {
                cmdErstellen.Text = "&Erstellen";
                wtxtRechte.Text = "lesen";
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            Benutzer NewForm = new Benutzer();
            NewForm.Show();
            this.Dispose(false);
            txtName.Focus();
        }
    }
}
