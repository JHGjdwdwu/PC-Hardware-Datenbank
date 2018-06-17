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
    public partial class Soundkarte_Imput : Form
    {
        public Soundkarte_Imput()
        {
            InitializeComponent();
        }

        private string Datensatz;//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schlißen
        {
            Close();
        }

        private void LoschenFunktin() //Löschen Funktion
        {
            wtxtBitaufloesung.Text = wtxtAusgabestandard.Text = wtxtAnschlusssSchnittstelle.Text = wtxtHersteller.Text = null;
            foreach (Control ctr in grpAudioSchnittstellen.Controls)//Alle Chekboxen zurücksetzen in der Gruppe AudioSchnittstellen
            {
                ((CheckBox)ctr).Checked = false;
            }
            foreach (Control ctr in grpSonstiges.Controls)//Alle Chekboxen zurücksetzen in der Gruppe Sonstiges
            {
                ((CheckBox)ctr).Checked = false;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschenFunktin();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./Soundkarte_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtAnschlusssSchnittstelle.Text != "" && wtxtAusgabestandard.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(@"./Soundkarte_Datenbank.csv");//Datenbanck einlessen und in Datensatz schreiben

                    #region Checkboxen
                    string ADAT = "NEIN", AES_EBU = "NEIN", Chinchbuchse = "NEIN", Klinkenbuchse = "NEIN", MADI = "NEIN", SPDIF = "NEIN", TDIF = "NEIN", BreakoutBox = "NEIN", DSP = "NEIN", Gameport = "NEIN", MIDI = "NEIN", Mikrofoneingang = "NEIN", Wavetable = "NEIN";
                    if (chbADAT.Checked == true)
                    {
                        ADAT = "JA";
                    }
                    if (chbAES_EBU.Checked == true)
                    {
                        AES_EBU = "JA";
                    }
                    if (chbChinch.Checked == true)
                    {
                        Chinchbuchse = "JA";
                    }
                    if (chbKlinke.Checked == true)
                    {
                        Klinkenbuchse = "JA";
                    }
                    if (chbMADI.Checked == true)
                    {
                        MADI = "JA";
                    }
                    if (chbS_PDIF.Checked == true)
                    {
                        SPDIF = "JA";
                    }
                    if (chbTDIF.Checked == true)
                    {
                        TDIF = "JA";
                    }
                    if (chbBreakoutBox.Checked == true)
                    {
                        BreakoutBox = "JA";
                    }
                    if (chbDSP.Checked == true)
                    {
                        DSP = "JA";
                    }
                    if (chbGameport.Checked == true)
                    {
                        Gameport = "JA";
                    }
                    if (chbMIDI.Checked == true)
                    {
                        MIDI = "JA";
                    }
                    if (chbMikrofon.Checked == true)
                    {
                        Mikrofoneingang = "JA";
                    }
                    if (chbWavetable.Checked == true)
                    {
                        Wavetable = "JA";
                    }
                    #endregion

                    #region Datensatzbilden
                    Datensatz += LF + wtxtAusgabestandard.Text + ";" + wtxtAnschlusssSchnittstelle.Text + ";" + wtxtBitaufloesung.Text + ";" + wtxtHersteller.Text + ";" + ADAT+";"+ AES_EBU + ";" + Chinchbuchse + ";" + Klinkenbuchse + ";" + MADI + ";" + SPDIF + ";" + TDIF + ";" + BreakoutBox + ";" + "DSP" + Gameport + ";" + MIDI + ";" + Mikrofoneingang + ";" + Wavetable;
                    #endregion

                    #region QR Code
                    QR = "Ausgabestandard:" + wtxtAusgabestandard.Text + LF + "Anschlussschnittstelle:" + wtxtAnschlusssSchnittstelle.Text + LF + "Bit-Auflösung:" + wtxtBitaufloesung.Text + LF + "Hersteller:" + wtxtHersteller.Text + LF + "ADAT:" + ADAT + LF + "AES/EBU:" + AES_EBU + LF + "Chinchbuchse:" + Chinchbuchse + LF + "Klinkenbuchse:" + Klinkenbuchse + LF + "MADI:" + MADI + LF + "S/PDIF:" + SPDIF + LF + "TDIF:" + TDIF + LF + "Breakout Box:" + BreakoutBox + LF + "DSP:" + DSP + LF + "Gameport:" + Gameport + LF + "MIDI:" + MIDI + LF + "Mikrofoneingang:" + Mikrofoneingang + LF + "Wavetable:" + Wavetable;
                    #endregion

                    File.WriteAllText(@"./Soundkarte_Datenbank.csv", Datensatz); //Datensatz in Soundkarte_Datenbank.csv schreiben
                    MessageBox.Show("Datensatz geschrieben!");//Bestätigung das der Datensatz geschrieben wurd
                }
                else
                {
                    MessageBox.Show("Bitte alle Roten Pflicht eintragungen ausfüllen!");
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
                MessageBox.Show("zuerst muss ein Datensatz gespeichert werden!");
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
