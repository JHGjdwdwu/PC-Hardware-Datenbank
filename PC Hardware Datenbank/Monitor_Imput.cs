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
    public partial class Monitor_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code
        public string DateiPfad;

        public Monitor_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster Schlissen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            wtxtHersteller.Text = wtxtModell.Text = wtxtTechnik.Text = wtxtMaxAuflosung.Text = wtxtZustand.Text = null;
            cbtLautsprecher.Checked = cbtHöhenVerstellbar.Checked = cbtVESA.Checked = false;
            cbtEingangVGA.Checked = cbtEingangDVI.Checked = cbtEingangHDMI.Checked = cbtEingangDisplaport.Checked = cbtEingangRGB.Checked = cbtEingangAudio.Checked = cbtEingangUSB.Checked = false;
            nudEingangVGA.Value = nudEingangDVI.Value = nudEingangHDMI.Value = nudEingangDisplaport.Value = nudEingangRGB.Value = nudEingangAudio.Value = nudEingangUSB.Value = 0;
            cbtAusgangAudio.Checked = cbtAusgangUSB.Checked = false;
            nudAusgangAudio.Value = nudAusgangUSB.Value = 0;
            wtxtHersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(DateiPfad + @"/Monitor_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtHersteller.Text != "" && wtxtModell.Text != "" && wtxtZustand.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(DateiPfad + @"/Monitor_Datenbank.csv");//Datenbanck lessen und in Datensatz speichern

                    #region Chak Boxen auswerten und Daten zuweisen
                    string Lautsprecher = "NEIN";
                    if (cbtLautsprecher.Checked == true)
                    {
                        Lautsprecher = "JA";
                    }

                    string HöhenVerstellbar = "NEIN";
                    if (cbtHöhenVerstellbar.Checked == true)
                    {
                        HöhenVerstellbar = "JA";
                    }

                    string VESA = "NEIN";
                    if (cbtVESA.Checked == true)
                    {
                        VESA = "JA";
                    }
                    #endregion

                    #region Datensatz bilden
                    Datensatz += LF +
                        wtxtHersteller.Text + ";" +
                        wtxtModell.Text + ";" +
                        wtxtZustand.Text + ";" +
                        wtxtMaxAuflosung.Text + ";" +
                        wtxtTechnik.Text + ";" +
                        Lautsprecher + ";" +
                        HöhenVerstellbar + ";" +
                        VESA + ";" +
                        nudEingangVGA.Value + ";" +
                        nudEingangDVI.Value + ";" +
                        nudEingangHDMI.Value + ";" +
                        nudEingangDisplaport.Value + ";" +
                        nudEingangRGB.Value + ";" +
                        nudEingangAudio.Value + ";" +
                        nudEingangUSB.Value + ";" +
                        nudAusgangAudio.Value + ";" +
                        nudAusgangUSB.Value;
                    #endregion

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Modell: " + wtxtModell.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Max.Auflösung: " + wtxtMaxAuflosung.Text + LF +
                        "Technik: " + wtxtTechnik.Text + LF +
                        "Lautsprecher: " + Lautsprecher + LF +
                        "Höhen verstellbar: " + HöhenVerstellbar + LF +
                        "VESA Halterung: " + VESA + LF +
                        "<Eingänge>" + LF +
                        "VGA: " + nudEingangVGA.Value + LF +
                        "DVI: " + nudEingangDVI.Value + LF +
                        "HDMI: " + nudEingangHDMI.Value + LF +
                        "Displayport: " + nudEingangDisplaport.Value + LF +
                        "RGB: " + nudEingangRGB.Value + LF +
                        "Ausio: " + nudEingangAudio.Value + LF +
                        "USB: " + nudEingangUSB.Value + LF +
                        "<Ausgänge>" + LF +
                        "Audio: " + nudAusgangAudio.Value + LF +
                        "USB: " + nudAusgangUSB.Value;
                    #endregion

                    File.WriteAllText(DateiPfad + @"/Monitor_Datenbank.csv", Datensatz);//Datensatz in Monitor_Datenbank.csv schreiben
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
        #region Prüfen ob Check-Box aktiv ist dan Nummern Block auf 1
        private void cbtEingangVGA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangVGA.Checked == true)
            {
                nudEingangVGA.Value = 1;
            }
            if (cbtEingangVGA.Checked == false)
            {
                nudEingangVGA.Value = 0;
            }
        }

        private void cbtEingangDVI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangDVI.Checked == true)
            {
                nudEingangDVI.Value = 1;
            }
            if (cbtEingangDVI.Checked == false)
            {
                nudEingangDVI.Value = 0;
            }
        }

        private void cbtEingangHDMI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangHDMI.Checked == true)
            {
                nudEingangHDMI.Value = 1;
            }
            if (cbtEingangHDMI.Checked == false)
            {
                nudEingangHDMI.Value = 0;
            }
        }

        private void cbtEingangDisplaport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangDisplaport.Checked == true)
            {
                nudEingangDisplaport.Value = 1;
            }
            if (cbtEingangDisplaport.Checked == false)
            {
                nudEingangDisplaport.Value = 0;
            }
        }

        private void cbtEingangRGB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangRGB.Checked == true)
            {
                nudEingangRGB.Value = 1;
            }
            if (cbtEingangRGB.Checked == false)
            {
                nudEingangRGB.Value = 0;
            }
        }

        private void cbtEingangAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangAudio.Checked == true)
            {
                nudEingangAudio.Value = 1;
            }
            if (cbtEingangAudio.Checked == false)
            {
                nudEingangAudio.Value = 0;
            }
        }

        private void cbtEingangUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtEingangUSB.Checked == true)
            {
                nudEingangUSB.Value = 1;
            }
            if (cbtEingangUSB.Checked == false)
            {
                nudEingangUSB.Value = 0;
            }
        }

        private void cbtAusgangAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtAusgangAudio.Checked == true)
            {
                nudAusgangAudio.Value = 1;
            }
            if (cbtAusgangAudio.Checked == false)
            {
                nudAusgangAudio.Value = 0;
            }
        }

        private void cbtAusgangUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtAusgangUSB.Checked == true)
            {
                nudAusgangUSB.Value = 1;
            }
            if (cbtAusgangUSB.Checked == false)
            {
                nudAusgangUSB.Value = 0;
            }
        }
        #endregion
        #region Prüfen das Nummern Felder
        private void nudEingangVGA_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangVGA.Value > 0)
            {
                cbtEingangVGA.Checked = true;
            }
            if (nudEingangVGA.Value == 0)
            {
                cbtEingangVGA.Checked = false;
            }
        }

        private void nudEingangDVI_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangDVI.Value > 0)
            {
                cbtEingangDVI.Checked = true;
            }
            if (nudEingangDVI.Value == 0)
            {
                cbtEingangDVI.Checked = false;
            }
        }

        private void nudEingangHDMI_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangHDMI.Value > 0)
            {
                cbtEingangHDMI.Checked = true;
            }
            if (nudEingangHDMI.Value == 0)
            {
                cbtEingangHDMI.Checked = false;
            }
        }

        private void nudEingangDisplaport_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangDisplaport.Value > 0)
            {
                cbtEingangDisplaport.Checked = true;
            }
            if (nudEingangDisplaport.Value == 0)
            {
                cbtEingangDisplaport.Checked = false;
            }
        }

        private void nudEingangRGB_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangRGB.Value > 0)
            {
                cbtEingangRGB.Checked = true;
            }
            if (nudEingangRGB.Value == 0)
            {
                cbtEingangRGB.Checked = false;
            }
        }

        private void nudEingangAudio_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangAudio.Value > 0)
            {
                cbtEingangAudio.Checked = true;
            }
            if (nudEingangAudio.Value == 0)
            {
                cbtEingangAudio.Checked = false;
            }
        }

        private void nudEingangUSB_ValueChanged(object sender, EventArgs e)
        {
            if (nudEingangUSB.Value > 0)
            {
                cbtEingangUSB.Checked = true;
            }
            if (nudEingangUSB.Value == 0)
            {
                cbtEingangUSB.Checked = false;
            }
        }

        private void nudAusgangAudio_ValueChanged(object sender, EventArgs e)
        {
            if (nudAusgangAudio.Value > 0)
            {
                cbtAusgangAudio.Checked = true;
            }
            if (nudAusgangAudio.Value == 0)
            {
                cbtAusgangAudio.Checked = false;
            }
        }

        private void nudAusgangUSB_ValueChanged(object sender, EventArgs e)
        {
            if (nudAusgangUSB.Value > 0)
            {
                cbtAusgangUSB.Checked = true;
            }
            if (nudAusgangUSB.Value == 0)
            {
                cbtAusgangUSB.Checked = false;
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

        private void Monitor_Imput_Load(object sender, EventArgs e)//lesen des gespeicherten DateiPfad
        {
            DateiPfad = File.ReadAllText(@"./settings");
        }
    }
}
