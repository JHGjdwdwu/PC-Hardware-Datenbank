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
    public partial class FrontErweiterung_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        public FrontErweiterung_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster Schlissen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            wtxtKartenhersteller.Text = wtxtModell.Text = null;
            cbtExternCardreader.Checked = cbtExternUSB2.Checked = cbtExternUSB3.Checked = cbtExternUSB3_1.Checked = cbtExternAudio.Checked = cbtExternFireWire.Checked = cbtExternThunderbolt.Checked = false;
            cbtInternUSB2.Checked = cbtInternUSB3.Checked = cbtInternUSB3_1.Checked = cbtInternAudio.Checked = cbtInternFireWire.Checked = cbtInternThunderbolt.Checked = false;
            nudExternCardreader.Value = nudExternUSB2.Value = nudExternUSB3.Value = nudExternUSB3_1.Value = nudExternAudio.Value = nudExternFireWire.Value = nudExternThunderbolt.Value = 0;
            nudInternUSB2.Value = nudInternUSB3.Value = nudInternUSB3_1.Value = nudInternAudio.Value = nudInternFireWire.Value = nudInternThunderbolt.Value = 0;
            wtxtKartenhersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./FrontErweiterung_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                Datensatz = File.ReadAllText(@"./FrontErweiterung_Datenbank.csv");//Datenbanck lessen und in Datensatz speichern

                #region Datensatz bilden
                Datensatz += LF + wtxtKartenhersteller.Text + ";" + wtxtModell.Text + ";";
                Datensatz += nudExternCardreader.Value + ";" + nudExternUSB2.Value + ";" + nudExternUSB3.Value + ";" + nudExternUSB3_1.Value + ";" + nudExternAudio.Value + ";" + nudExternFireWire.Value + ";" + nudExternThunderbolt.Value;
                Datensatz += nudInternUSB2.Value + ";" + nudInternUSB3.Value + ";" + nudInternUSB3_1.Value + ";" + nudInternAudio.Value + ";" + nudInternFireWire.Value + ";" + nudInternThunderbolt.Value;
                #endregion

                #region QR Code
                QR = "Hersteller:" + wtxtKartenhersteller.Text + LF + "Modell:" + wtxtModell.Text + LF + "Externe Schnittstellen" + LF + "Cardreader:" + nudExternCardreader.Value + LF + "USB2.0:" + nudExternUSB2.Value + LF + "USB3.0:" + nudExternUSB3.Value + LF + "USB3.1:" + nudExternUSB3_1.Value + LF + "Audio:" + nudExternAudio.Value + LF + "FireWire:" + nudExternFireWire.Value + LF + "Thunderbolt:" + nudExternThunderbolt.Value + LF + "Interne-Schnittstelle" + LF + "USB2.0:" + nudInternUSB2.Value + LF + "USB3.0:" + nudInternUSB3.Value + LF + "USB3.1:" + nudInternUSB3_1.Value + LF + "Audio:" + nudInternAudio.Value + LF + "FireWire:" + nudInternFireWire.Value + LF + "Thunderbolt:" + nudInternThunderbolt.Value;
                #endregion

                File.WriteAllText(@"./FrontErweiterung_Datenbank.csv", Datensatz);//Datensatz in Mainbord_Datenbank.csv schreiben
                MessageBox.Show("Datensatz geschrieben!");//Bestätigung das der Datensatz geschrieben wurd
            }
            else
            {
                MessageBox.Show("Datenbank nicht vorhanden bitte einen Administrator aufsuchen!");
                Application.Exit();
            }
        }
        #region Prüfen das Nummern Felder
        private void nudExternCardreader_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternCardreader.Value > 0)
            {
                cbtExternCardreader.Checked = true;
            }
            if (nudExternCardreader.Value == 0)
            {
                cbtExternCardreader.Checked = false;
            }
        }

        private void nudExternUSB2_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternUSB2.Value > 0)
            {
                cbtExternUSB2.Checked = true;
            }
            if (nudExternUSB2.Value == 0)
            {
                cbtExternUSB2.Checked = false;
            }
        }

        private void nudExternUSB3_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternUSB3.Value > 0)
            {
                cbtExternUSB3.Checked = true;
            }
            if (nudExternUSB3.Value == 0)
            {
                cbtExternUSB3.Checked = false;
            }
        }

        private void nudExternUSB3_1_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternUSB3_1.Value > 0)
            {
                cbtExternUSB3_1.Checked = true;
            }
            if (nudExternUSB3_1.Value == 0)
            {
                cbtExternUSB3_1.Checked = false;
            }
        }

        private void nudExternAudio_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternAudio.Value > 0)
            {
                cbtExternAudio.Checked = true;
            }
            if (nudExternAudio.Value == 0)
            {
                cbtExternAudio.Checked = false;
            }
        }

        private void nudExternFireWire_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternFireWire.Value > 0)
            {
                cbtExternFireWire.Checked = true;
            }
            if (nudExternFireWire.Value == 0)
            {
                cbtExternFireWire.Checked = false;
            }
        }

        private void nudExternThunderbolt_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternThunderbolt.Value > 0)
            {
                cbtExternThunderbolt.Checked = true;
            }
            if (nudExternThunderbolt.Value == 0)
            {
                cbtExternThunderbolt.Checked = false;
            }
        }

        private void nudInternUSB2_ValueChanged(object sender, EventArgs e)
        {
            if (nudInternUSB2.Value > 0)
            {
                cbtInternUSB2.Checked = true;
            }
            if (nudInternUSB2.Value == 0)
            {
                cbtInternUSB2.Checked = false;
            }
        }

        private void nudInternUSB3_ValueChanged(object sender, EventArgs e)
        {
            if (nudInternUSB3.Value > 0)
            {
                cbtInternUSB3.Checked = true;
            }
            if (nudInternUSB3.Value == 0)
            {
                cbtInternUSB3.Checked = false;
            }
        }

        private void nudInternUSB3_1_ValueChanged(object sender, EventArgs e)
        {
            if (nudInternUSB3_1.Value > 0)
            {
                cbtInternUSB3_1.Checked = true;
            }
            if (nudInternUSB3_1.Value == 0)
            {
                cbtInternUSB3_1.Checked = false;
            }
        }

        private void nudInternAudio_ValueChanged(object sender, EventArgs e)
        {
            if (nudInternAudio.Value > 0)
            {
                cbtInternAudio.Checked = true;
            }
            if (nudInternAudio.Value == 0)
            {
                cbtInternAudio.Checked = false;
            }
        }

        private void nudInternFireWire_ValueChanged(object sender, EventArgs e)
        {
            if (nudInternFireWire.Value > 0)
            {
                cbtInternFireWire.Checked = true;
            }
            if (nudInternFireWire.Value == 0)
            {
                cbtInternFireWire.Checked = false;
            }
        }

        private void nudInternThunderbolt_ValueChanged(object sender, EventArgs e)
        {
            if (nudInternThunderbolt.Value > 0)
            {
                cbtInternThunderbolt.Checked = true;
            }
            if (nudInternThunderbolt.Value == 0)
            {
                cbtInternThunderbolt.Checked = false;
            }
        }
        #endregion
        #region Prüfen ob Check-Box aktiv ist dan Nummern Block auf 1
        private void cbtExternCardreader_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternCardreader.Checked == true)
            {
                nudExternCardreader.Value = 1;
            }
            if (cbtExternCardreader.Checked == false)
            {
                nudExternCardreader.Value = 0;
            }
        }

        private void cbtExternUSB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternUSB2.Checked == true)
            {
                nudExternUSB2.Value = 1;
            }
            if (cbtExternUSB2.Checked == false)
            {
                nudExternUSB2.Value = 0;
            }
        }

        private void cbtExternUSB3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternUSB3.Checked == true)
            {
                nudExternUSB3.Value = 1;
            }
            if (cbtExternUSB3.Checked == false)
            {
                nudExternUSB3.Value = 0;
            }
        }

        private void cbtExternUSB3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternUSB3_1.Checked == true)
            {
                nudExternUSB3_1.Value = 1;
            }
            if (cbtExternUSB3_1.Checked == false)
            {
                nudExternUSB3_1.Value = 0;
            }
        }

        private void cbtExternAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternAudio.Checked == true)
            {
                nudExternAudio.Value = 1;
            }
            if (cbtExternAudio.Checked == false)
            {
                nudExternAudio.Value = 0;
            }
        }

        private void cbtExternFireWire_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternFireWire.Checked == true)
            {
                nudExternFireWire.Value = 1;
            }
            if (cbtExternFireWire.Checked == false)
            {
                nudExternFireWire.Value = 0;
            }
        }

        private void cbtExternThunderbolt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternThunderbolt.Checked == true)
            {
                nudExternThunderbolt.Value = 1;
            }
            if (cbtExternThunderbolt.Checked == false)
            {
                nudExternThunderbolt.Value = 0;
            }
        }

        private void cbtInternUSB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtInternUSB2.Checked == true)
            {
                nudInternUSB2.Value = 1;
            }
            if (cbtInternUSB2.Checked == false)
            {
                nudInternUSB2.Value = 0;
            }
        }

        private void cbtInternUSB3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtInternUSB3.Checked == true)
            {
                nudInternUSB3.Value = 1;
            }
            if (cbtInternUSB3.Checked == false)
            {
                nudInternUSB3.Value = 0;
            }
        }

        private void cbtInternUSB3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtInternUSB3_1.Checked == true)
            {
                nudInternUSB3_1.Value = 1;
            }
            if (cbtInternUSB3_1.Checked == false)
            {
                nudInternUSB3_1.Value = 0;
            }
        }

        private void cbtInternAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtInternAudio.Checked == true)
            {
                nudInternAudio.Value = 1;
            }
            if (cbtInternAudio.Checked == false)
            {
                nudInternAudio.Value = 0;
            }
        }

        private void cbtInternFireWire_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtInternFireWire.Checked == true)
            {
                nudInternFireWire.Value = 1;
            }
            if (cbtInternFireWire.Checked == false)
            {
                nudInternFireWire.Value = 0;
            }
        }

        private void cbtInternThunderbolt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtInternThunderbolt.Checked == true)
            {
                nudInternThunderbolt.Value = 1;
            }
            if (cbtInternThunderbolt.Checked == false)
            {
                nudInternThunderbolt.Value = 0;
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
