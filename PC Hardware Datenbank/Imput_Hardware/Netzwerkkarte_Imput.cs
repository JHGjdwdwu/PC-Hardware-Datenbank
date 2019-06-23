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
    public partial class Netzwerkkarte_Imput : Form
    {
        public Netzwerkkarte_Imput()
        {
            InitializeComponent();
        }

        Methoden methoden = new Methoden();
        private char LF = (char)10;
        private string QR = "";//QR Code

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster Schlissen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            Netzwerkkarte_Imput NewForm = new Netzwerkkarte_Imput();
            NewForm.Show();
            this.Dispose(false);
            wtxtHersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "" && wtxtSchnittstelle.Text != "" && wtxtGeschwindigkeit.Text != "")
            {
                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `netzwerkkarte` VALUES (''," + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Typ: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Schnittstelle: " + wtxtSchnittstelle.Text + LF +
                        "Geschwindigkeit: " + wtxtGeschwindigkeit.Text + LF +
                        "RJ-45: " + nudRJ45.Value + LF +
                        "Coax: " + nudCoax.Value + LF +
                        "LWL: " + nudLWL.Value + LF +
                        "W-Lan: " + nudWLan.Value;
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

        #region Check Boxen auswerten und wen gedrückt Nummern Feld + 1
        private void cbtRJ45_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtRJ45.Checked == true)
            {
                nudRJ45.Value = 1;
            }
            if (cbtRJ45.Checked == false)
            {
                nudRJ45.Value = 0;
            }
        }
        private void cbtCoax_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtCoax.Checked == true)
            {
                nudCoax.Value = 1;
            }
            if (cbtCoax.Checked == false)
            {
                nudCoax.Value = 0;
            }
        }
        private void cbtLWL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtLWL.Checked == true)
            {
                nudLWL.Value = 1;
            }
            if (cbtLWL.Checked == false)
            {
                nudLWL.Value = 0;
            }
        }
        private void cbtWLan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtWLan.Checked == true)
            {
                nudWLan.Value = 1;
            }
            if (cbtWLan.Checked == false)
            {
                nudWLan.Value = 0;
            }
        }
        #endregion

        #region Nummer Felder Überwachen wenn nicht 0 dan Check Box aktiviren
        private void nudRJ45_ValueChanged(object sender, EventArgs e)
        {
            if (nudRJ45.Value != 0)
            {
                cbtRJ45.Checked = true;
            }
            if (nudRJ45.Value == 0)
            {
                cbtRJ45.Checked = false;
            }
        }
        private void nudCoax_ValueChanged(object sender, EventArgs e)
        {
            if (nudCoax.Value != 0)
            {
                cbtCoax.Checked = true;
            }
            if (nudCoax.Value == 0)
            {
                cbtCoax.Checked = false;
            }
        }
        private void nudLWL_ValueChanged(object sender, EventArgs e)
        {
            if (nudLWL.Value != 0)
            {
                cbtLWL.Checked = true;
            }
            if (nudLWL.Value == 0)
            {
                cbtLWL.Checked = false;
            }
        }
        private void nudWLan_ValueChanged(object sender, EventArgs e)
        {
            if (nudWLan.Value != 0)
            {
                cbtWLan.Checked = true;
            }
            if (nudWLan.Value == 0)
            {
                cbtWLan.Checked = false;
            }
        }
        #endregion

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
