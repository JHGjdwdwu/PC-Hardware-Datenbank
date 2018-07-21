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
    public partial class Laufwerk_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        public Laufwerk_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster Schlissen
        {
            Close();
        }

        private void LoschenFunktion()//Lösch Funktion
        {
            wtxtHersteller.Text = wtxtSchnittstelle.Text = wtxtTyp.Text = wtxtBauart.Text = wtxtZustand.Text = null;
            cbtBrenner.Checked = false;
            wtxtHersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschenFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./Laufwerke_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtHersteller.Text != "" && wtxtSchnittstelle.Text != "" && wtxtTyp.Text != "" && wtxtBauart.Text != "" && wtxtZustand.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(@"./Laufwerke_Datenbank.csv");//Datenbanck lessen und in Datensatz speichern

                    #region CheckBoxen
                    string Brenner = "NEIN";
                    if (cbtBrenner.Checked == true)
                    {
                        Brenner = "JA";
                    }
                    #endregion

                    #region Datensatz erstellen
                    Datensatz += LF +
                        wtxtHersteller.Text + ";" +
                        wtxtSchnittstelle.Text + ";" +
                        wtxtTyp + ";" +
                        wtxtBauart.Text + ";" +
                        wtxtZustand.Text + ";" +
                        Brenner;
                    #endregion

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Schnittstelle: " + wtxtSchnittstelle.Text + LF +
                        "Mediumtyp: " + wtxtTyp.Text + LF +
                        "Typ: " + wtxtBauart.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Brenner: " + Brenner;
                    #endregion

                    File.WriteAllText(@"./Laufwerke_Datenbank.csv", Datensatz);//Datensatz in Datenbank schreiben
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
