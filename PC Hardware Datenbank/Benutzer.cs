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
                dgvUser.Rows.RemoveAt(dgvUser.SelectedRows[0].Index);//aus der dgv den makirten User Löschen

                //allt ohne verschlüsselung
                //int zeile = dgvUser.CurrentCell.RowIndex;//Nummer der mackirten Zeile
                //string verlusselt_text = File.ReadAllText(@"./User");//Verschlüsselten Text lesen
                //string unverslusselt_text = crypto.decrypt(verlusselt_text);//Text entschlüsseln
                //string[] zellen = unverslusselt_text.Split(';');//Text teilen bei ;

                //var file = new List<string>(File.ReadAllLines(@"./User"));
                //file.RemoveAt(zeile);
                //File.WriteAllLines(@"./User", file.ToArray());

                string verlusselt_text = File.ReadAllText(@"./User");//Verschlüsselten Text lesen
                string unverslusselt_text = crypto.decrypt(verlusselt_text);//Text entschlüsseln
                string[] zellen = unverslusselt_text.Split(';');//Text teilen bei ;

                int zeile = dgvUser.SelectedRows[0].Index + 1;//Nummer der mackirten Zeile ///Fehler noch die letzte Zeile wird nicht richtig gezählt!
                int entfernen = zeile * 3;


                List<string> list = new List<string>(zellen);

                //list.Sort();//Liste sortieren!
                //list.Remove("4");//entfernt anhang String
                //list.RemoveAt(entfernen);//entfernt anhang ID

                list.RemoveRange(entfernen, entfernen - 2);//entfern von bis
                zellen = list.ToArray();

                for (int i = 0; i < zellen.Length - 1; i++)
                {
                    File.WriteAllText(@"./User", zellen[i] + ";");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim löschen eines Benutzer: " + ex.Message);
            }
            dgvUser.Rows.Clear();
            Datei_lesen();
        }
    }
}
