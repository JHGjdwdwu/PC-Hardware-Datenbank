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
    public partial class GPU_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        public GPU_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schlißen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            wtxtKartenhersteller.Text = wtxtModell.Text = wtxtSpeichergrosse.Text = wtxtSpeicherTyp.Text = wtxtKuhlertyp.Text = wtxtAnschluss.Text = wtxtStromversorgung.Text = wtxtStromverbrauch.Text = txtTaktrate.Text = null;
            cbtMultiGPU.Checked = cbtVGA.Checked = cbtDVI.Checked = cbtHDMI.Checked = cbtDisplaport.Checked = cbtSVideo.Checked = cbtCinch.Checked = false;
            nudVGA.Value = nudDVI.Value = nudHDMI.Value = nudDisplaport.Value = nudSVideo.Value = nudCinch.Value = 0;
            wtxtKartenhersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./GPU_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtKartenhersteller.Text != "" && wtxtModell.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(@"./GPU_Datenbank.csv");//Datenbanck einlessen und in Datensatz speichern

                    #region Chak Boxen auswerten und Daten zuweisen
                    string MultiGPU = "NEIN";
                    if (cbtMultiGPU.Checked == true)
                    {
                        MultiGPU = "JA";
                    }
                    #endregion

                    #region Datensatz bilden
                    Datensatz += LF + wtxtKartenhersteller.Text + ";" + wtxtModell.Text + ";" + wtxtSpeichergrosse.Text + ";";
                    Datensatz += wtxtSpeicherTyp.Text + ";" + wtxtKuhlertyp.Text + ";" + wtxtAnschluss.Text + ";";
                    Datensatz += wtxtStromversorgung.Text + ";" + wtxtStromverbrauch.Text + ";" + txtTaktrate.Text + ";";
                    Datensatz += MultiGPU + ";" + nudVGA.Value + ";" + nudDVI.Value + ";" + nudHDMI.Value + ";";
                    Datensatz += nudDisplaport.Value + ";" + nudSVideo.Value + ";" + nudCinch.Value;
                    #endregion

                    #region QR Code
                    QR = "Kartenhersteller" + wtxtKartenhersteller.Text + LF + "Modell" + wtxtModell.Text + LF + "Speichergröße" + wtxtSpeichergrosse.Text + LF + "Speichertyp" + wtxtSpeicherTyp.Text + LF + "Kühlertyp" + wtxtKuhlertyp.Text + LF + "Stromversorgung" + wtxtStromversorgung.Text + LF + "Anschlussart" + wtxtAnschluss.Text + LF + "Stromverbrauch" + wtxtStromverbrauch.Text + LF + "Taktrate" + txtTaktrate.Text + LF + "Multi-Grafikkarten-Betrieb" + MultiGPU + LF + "VGA" + nudVGA.Value + LF + "DVI" + nudDVI.Value + LF + "HDMI" + nudHDMI.Value + LF + "Displayport" + nudDisplaport.Value + LF + "S-Video" + nudSVideo.Value + LF + "Cinch" + nudCinch.Value;
                    #endregion

                    File.WriteAllText(@"./GPU_Datenbank.csv", Datensatz);//Datensatz in GPU_Datenbank.csv schreiben
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
        #region Prüfen das Nummern Felder
        private void nudVGA_ValueChanged(object sender, EventArgs e)
        {
            if (nudVGA.Value > 0)
            {
                cbtVGA.Checked = true;
            }
            if (nudVGA.Value == 0)
            {
                cbtVGA.Checked = false;
            }
        }

        private void nudDVI_ValueChanged(object sender, EventArgs e)
        {
            if (nudDVI.Value > 0)
            {
                cbtDVI.Checked = true;
            }
            if (nudDVI.Value == 0)
            {
                cbtDVI.Checked = false;
            }
        }

        private void nudHDMI_ValueChanged(object sender, EventArgs e)
        {
            if (nudHDMI.Value > 0)
            {
                cbtHDMI.Checked = true;
            }
            if (nudHDMI.Value == 0)
            {
                cbtHDMI.Checked = false;
            }
        }

        private void nudDisplaport_ValueChanged(object sender, EventArgs e)
        {
            if (nudDisplaport.Value > 0)
            {
                cbtDisplaport.Checked = true;
            }
            if (nudDisplaport.Value == 0)
            {
                cbtDisplaport.Checked = false;
            }
        }

        private void nudSVideo_ValueChanged(object sender, EventArgs e)
        {
            if (nudSVideo.Value > 0)
            {
                cbtSVideo.Checked = true;
            }
            if (nudSVideo.Value == 0)
            {
                cbtSVideo.Checked = false;
            }
        }

        private void nudCinch_ValueChanged(object sender, EventArgs e)
        {
            if (nudCinch.Value > 0)
            {
                cbtCinch.Checked = true;
            }
            if (nudCinch.Value == 0)
            {
                cbtCinch.Checked = false;
            }
        }
        #endregion

        #region Prüfen ob Check-Box aktiv ist dan Nummern Block auf 1
        private void cbtVGA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtVGA.Checked == true)
            {
                nudVGA.Value = 1;
            }
            if (cbtVGA.Checked == false)
            {
                nudVGA.Value = 0;
            }
        }

        private void cbtDVI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtDVI.Checked == true)
            {
                nudDVI.Value = 1;
            }
            if (cbtDVI.Checked == false)
            {
                nudDVI.Value = 0;
            }
        }

        private void cbtHDMI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtHDMI.Checked == true)
            {
                nudHDMI.Value = 1;
            }
            if (cbtHDMI.Checked == false)
            {
                nudHDMI.Value = 0;
            }
        }

        private void cbtDisplaport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtDisplaport.Checked == true)
            {
                nudDisplaport.Value = 1;
            }
            if (cbtDisplaport.Checked == false)
            {
                nudDisplaport.Value = 0;
            }
        }

        private void cbtSVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtSVideo.Checked == true)
            {
                nudSVideo.Value = 1;
            }
            if (cbtSVideo.Checked == false)
            {
                nudSVideo.Value = 0;
            }
        }

        private void cbtCinch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtCinch.Checked == true)
            {
                nudCinch.Value = 1;
            }
            if (cbtCinch.Checked == false)
            {
                nudCinch.Value = 0;
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
    }
}
