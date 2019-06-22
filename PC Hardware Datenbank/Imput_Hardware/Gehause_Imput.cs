using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Zusäzlich für Daten
using System.Drawing.Printing;//Zusäzlich für Drucken
using QRCoder;//Zusäzlich für den QR-Code Generator

namespace PC_Hardware_Datenbank
{
    public partial class Gehause_Imput : Form
    {
        public Gehause_Imput()
        {
            InitializeComponent();
        }

        Methoden methoden = new Methoden();
        private char LF = (char)10;
        private string QR = "";//QR Code

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schlissen
        {
            Close();
        }

        private void LoschFunktion()//Lösch Funktion
        {
            Gehause_Imput NewForm = new Gehause_Imput();
            NewForm.Show();
            this.Dispose(false);
            mtxtBreiteHocheTiefe.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (mtxtBreiteHocheTiefe.Text != "" && wtxtZustand.Text != "" && wtxtNetzteilPosition.Text != "" && nudEinschub5ex.Text != "" && nudEinschub3ex.Text != "" && nudEinschub2ex.Text != "" && nudEinschub3in.Text != "" && nudEinschub2in.Text != "" && nudFrontUSB.Text != "" && nudFrontKlinke.Text != "")
            {
                #region Chekbox auswerten
                string Kabelsystem, Beleuchtung, PlexiglassFenster;
                if (cbtKabelsystem.Checked)
                {
                    Kabelsystem = "Ja";
                }
                else
                {
                    Kabelsystem = "Nein";
                }

                if (cbtBelechtung.Checked)
                {
                    Beleuchtung = "Ja";
                }
                else
                {
                    Beleuchtung = "Nein";
                }

                if (cbtFenster.Checked)
                {
                    PlexiglassFenster = "Ja";
                }
                else
                {
                    PlexiglassFenster = "Nein";
                }
                #endregion

                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `gehause` VALUES (" + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Breite-Höhe-Tiefe: " + mtxtBreiteHocheTiefe.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Netzteil Position: " + wtxtNetzteilPosition.Text + LF +
                        "Einschub 5,25 extern: " + nudEinschub5ex.Value + LF +
                        "Einschub 3,5 extern: " + nudEinschub3ex.Value + LF +
                        "Einschub 2,5 extern: " + nudEinschub2ex.Value + LF +
                        "Einschub 3,5 intern: " + nudEinschub3in.Value + LF +
                        "Einschub 2,5 intern: " + nudEinschub2in.Value + LF +
                        "Front USB: " + nudFrontUSB.Value + LF +
                        "Front Klinke: " + nudFrontKlinke.Value + LF +
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Bezeichnung: " + wtxtID.Text + LF +
                        "Formfaktor: " + wtxtForm.Text + LF +
                        "Kabelsystem: " + Kabelsystem + LF +
                        "Beleuchtung: " + Beleuchtung + LF +
                        "Plexiglas Fenster: " + PlexiglassFenster;
                    #endregion

                    DialogResult dialogresult = MessageBox.Show("Möchten Sie einen QR-Code Drucken?", "QR-Code Drucken?", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        cmdQR_Click(cmdQR, e);
                    }
                    else if (dialogresult == DialogResult.No)
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Fehler: Daten konnten nicht gespeichert speichern werden!");
                }
            }
            else
            {
                MessageBox.Show("Bitte füllen sie alle rot markierten Felder aus!");
            }
        }

        #region Drucken von einem QR-Code
        private void cmdQR_Click(object sender, EventArgs e)
        {
            if (QR != "")
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += printDocument1_PrintPage;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
            else
            {
                MessageBox.Show("Zuerst muss ein Datensatz gespeichert werden!");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData Daten = qrGenerator.CreateQrCode(QR, QRCodeGenerator.ECCLevel.L);

            QRCode qrCode = new QRCode(Daten);
            Bitmap qrCodeImage = qrCode.GetGraphic(2);
            e.Graphics.DrawImage(qrCodeImage, 10, 10);
            qrCodeImage.Dispose();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }
}
