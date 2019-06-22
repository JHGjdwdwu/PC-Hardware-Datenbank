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

        Methoden methoden = new Methoden();
        private char LF = (char)10;
        private string QR = "";//QR Code

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schlißen
        {
            Close();
        }

        private void LoschFunktion() //Löschen Funktion
        {
            Soundkarte_Imput NewForm = new Soundkarte_Imput();
            NewForm.Show();
            this.Dispose(false);
            wtxtAusgabestandard.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "" && wtxtAnschlusssSchnittstelle.Text != "")
            {
                #region CheckBox auswerten
                string ADAT = "Nein", AES_EBU = "Nein", Chinchbuchse = "Nein", Klinkenbuchse = "Nein", MADI = "Nein", SPDIFo = "Nein", SPDIFc = "Nein";
               string TDIF = "Nein", BreakoutBox = "Nein", DSP = "Nein", Gameport = "Nein", MIDI = "Nein", Mikrofoneingang = "Nein", Wavetable = "Nein";

                if (cbtADAT.Checked)
                {
                    ADAT = "Ja";
                }

                if (cbtAES_EBU.Checked)
                {
                    AES_EBU = "Ja";
                }

                if (cbtChinch.Checked)
                {
                    Chinchbuchse = "Ja";
                }

                if (cbtKlinke.Checked)
                {
                    Klinkenbuchse = "Ja";
                }

                if (cbtMADI.Checked)
                {
                    MADI = "Ja";
                }

                if (cbtS_PDIFo.Checked)
                {
                    SPDIFo = "Ja";
                }

                if (cbtS_PDIFc.Checked)
                {
                    SPDIFc = "Ja";
                }

                if (cbtTDIF.Checked)
                {
                    TDIF = "Ja";
                }

                if (cbtBreakoutBox.Checked)
                {
                    BreakoutBox = "Ja";
                }

                if (cbtDSP.Checked)
                {
                    DSP = "Ja";
                }

                if (cbtGameport.Checked)
                {
                    Gameport = "Ja";
                }


                if (cbtMIDI.Checked)
                {
                    MIDI = "Ja";
                }

                if (cbtMikrofon.Checked)
                {
                    Mikrofoneingang = "Ja";
                }

                if (cbtWavetable.Checked)
                {
                    Wavetable = "Ja";
                }
                #endregion

                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `soundkarte` VALUES (" + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Bezeichnung: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Anschlussschnittstelle: " + wtxtAnschlusssSchnittstelle.Text + LF +
                        "Ausgabestandard: " + wtxtAusgabestandard.Text + LF +
                        "Bit-Auflösung: " + wtxtBitaufloesung.Text + LF +

                        "ADAT: " + ADAT + LF +
                        "AES/EBU: " + AES_EBU + LF +
                        "Chinchbuchse: " + Chinchbuchse + LF +
                        "Klinkenbuchse: " + Klinkenbuchse + LF +
                        "MADI: " + MADI + LF +
                        "S/PDIF-optical: " + SPDIFo + LF +
                        "S/PDIF-cinch: " + SPDIFc + LF +
                        "TDIF: " + TDIF + LF +
                        "Breakout Box: " + BreakoutBox + LF +
                        "DSP: " + DSP + LF +
                        "Gameport: " + Gameport + LF +
                        "MIDI: " + MIDI + LF +
                        "Mikrofoneingang: " + Mikrofoneingang + LF +
                        "Wavetable: " + Wavetable;
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
            System.Diagnostics.Process.Start("https://github.com/tpbischof");
        }
    }
}
