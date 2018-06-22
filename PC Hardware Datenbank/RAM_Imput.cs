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
    public partial class RAM_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        public RAM_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schlißen
        {
            Close();
        }

        private void LoschenFunktin()//Löschen Funktion
        {
            wtxtSlot.Text = wtxtGrosse.Text = wtxtHersteller.Text = txtTyp.Text = wtxtTacktrate.Text = null;
            cbtSO_DIMM.Checked = cbtECC.Checked = cbtRegistered.Checked = cbtUnbuffered.Checked = false;
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschenFunktin();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./RAM_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtSlot.Text != "" && wtxtGrosse.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(@"./RAM_Datenbank.csv");//Datenbanck einlessen und in Datensatz schreiben

                    #region Chak Boxen auswerten und Daten zuweisen
                    string SO_DIMM = "NEIN";
                    if (cbtSO_DIMM.Checked == true)
                    {
                        SO_DIMM = "JA";
                    }

                    string ECC = "NEIN";
                    if (cbtECC.Checked == true)
                    {
                        ECC = "JA";
                    }

                    string Registered = "NEIN";
                    if (cbtRegistered.Checked == true)
                    {
                        Registered = "JA";
                    }

                    string Unbuffered = "NEIN";
                    if (cbtUnbuffered.Checked == true)
                    {
                        Unbuffered = "JA";
                    }
                    #endregion

                    #region Datensatz bilden
                    Datensatz += LF + wtxtSlot.Text + ";" + wtxtGrosse.Text + ";" + wtxtHersteller.Text + ";" + txtTyp.Text + ";" + wtxtTacktrate.Text + ";" + txtLatenz.Text + ";" + SO_DIMM + ";" + ECC + ";" + Registered + ";" + Unbuffered;
                    #endregion

                    #region QR Code
                    QR = "Slot" + wtxtSlot.Text + LF + "Größe" + wtxtGrosse.Text + LF + "Hersteller" + wtxtHersteller.Text + LF + "Typ" + txtTyp.Text + LF + "Taktrate" + wtxtTacktrate.Text + LF + "Latenz" + txtLatenz.Text + LF + "SO-DIMM" + SO_DIMM + LF + "ECC" + ECC + LF + "Registered" + Registered + LF + "Unbuffered" + Unbuffered;
                    #endregion
                    File.WriteAllText(@"./RAM_Datenbank.csv", Datensatz);//Datensatz in RAM_Datenbank.csv schreiben
                    MessageBox.Show("Datensatz geschrieben!");//Bestätigung das der Datensatz geschrieben wurd
                }
                else
                {
                    MessageBox.Show("Bitte alle roten Pflichtfelder ausfüllen!");
                }
            }
            else
            {
                MessageBox.Show("Datenbank nicht vorhanden bitte einen Administrator aufsuchen!");
                Application.Exit();
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
    }
}
