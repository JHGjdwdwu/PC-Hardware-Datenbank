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

namespace PC_Hardware_Datenbank
{
    public partial class Benutzer : Form
    {
        Crypto_AES crypto = new Crypto_AES();//Aufruf des Crypto Tool

        public Benutzer()
        {
            InitializeComponent();
        }

        private void cmdSchliessen_Click(object sender, EventArgs e)//Button Schließen
        {
            Close();
        }

        private void Datei_lesen()//Datei einlesen und in die dgv schreiben
        {
            if (File.Exists(@"./User")==true)
            {
                try
                {
                    string verlusselt_text = File.ReadAllText(@"./User");//Verschlüsselten Text lesen
                    string unverslusselt_text = crypto.decrypt(verlusselt_text);//Text entschlüsseln
                    string[] zellen = unverslusselt_text.Split(';');//Text teilen bei ;

                    //lblNR.Text = Convert.ToString((zellen.Length -1) / 3);

                    for (int i = 0; i < zellen.Length - 1; i = i + 3)//Das dgv beschreiben Daten aus dem Arry benutzen
                    {
                        dgvUser.Rows.Add(zellen[i], zellen[i + 1], zellen[i + 2]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim einlesen der Datei! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Eine User Datenbank konnte nicht gefunden werden und wird erstellt!");
                File.WriteAllText(@"./User", "");
                Datei_lesen();
            }
        }

        private void Benutzer_Load(object sender, EventArgs e)//Ausfüren wen Fenster geöffnet wird
        {
            wtxtRechte.Text = "lesen";//Standart auswahl ist lesen
            Datei_lesen();
        }

        private void cmdErstellen_Click(object sender, EventArgs e)//Button Erstellen
        {
            if (txtName.Text != "" && txtPassword.Text != "" && wtxtRechte.Text != "")
            {
                try
                {
                    string UserDatenVers = File.ReadAllText(@"./User");//Dateiinhalt einlesen
                    string UserDatenUnver = crypto.decrypt(UserDatenVers);
                    dgvUser.Rows.Add(txtName.Text, txtPassword.Text, wtxtRechte.Text);//schreibt den neuen Benuzer in die dgvUser
                    File.WriteAllText(@"./User", crypto.encrypt(UserDatenUnver + txtName.Text + ";" + txtPassword.Text + ";" + wtxtRechte.Text + ";"));//Neien Dateiinhalt schreiben
                }
                catch
                {
                    MessageBox.Show("Fehler keine User Datenbank gefunden!");
                }
            }
            else
            {
                MessageBox.Show("Bitte gebe eine Namen, Passwort und Rechte an!");
            }
        }

        private void cmdLoschen_Click(object sender, EventArgs e)//Button Löschen
        {
            try
            {
                dgvUser.Rows.RemoveAt(dgvUser.CurrentCell.RowIndex);//aus der dgv den makirten User Löschen

                string verlusselt_text = File.ReadAllText(@"./User");//Verschlüsselten Text lesen
                string unverslusselt_text = crypto.decrypt(verlusselt_text);//Text entschlüsseln
                string[] zellen = unverslusselt_text.Split(';');//Text teilen bei ;

                int zeile = dgvUser.SelectedRows[0].Index;//Nummer der mackirten Zeile
                //int zeile = (dgvUser.SelectedRows[0].Index + 1) * 3 - 1;//Nummer der mackirten Zellen
                List<string> list = new List<string>(zellen);
                //erzeugt eine Liste mit allen Eintragungen
                /*  0    0 ; 1 ; 2
                 *  1    3 ; 4 ; 5
                 *  2    6 ; 7 ; 8
                 */
                lblNR.Text = Convert.ToString(zeile - 2) + ";" + Convert.ToString(zeile - 1) + ";" + Convert.ToString(zeile);

                //list.RemoveAt(zeile-2);//entfernt Zelle ID
                //list.RemoveAt(zeile-1);//entfernt Zelle ID
                //list.RemoveAt(zeile);//entfernt Zelle ID
                list.RemoveRange(zeile, 3);//entferne Index, Anzahl

                zellen = list.ToArray();//schreibt die Liste in das Array wider zurück
                
                File.WriteAllText(@"./User", "");//löscht die alten Daten
                //File.WriteAllText(@"./User",string.Join(";", zellen));//schreibt die neue User Liste
                File.WriteAllText(@"./User", crypto.encrypt(string.Join(";", zellen)));//schreibt die neue User Liste
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim löschen eines Benutzer: " + ex.Message);
            }
            dgvUser.Rows.Clear();
            Datei_lesen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tpbischof");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }
}
