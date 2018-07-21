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
    public partial class TVKarte_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        public TVKarte_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster Schlissen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            wtxtKartenhersteller.Text = wtxtModell.Text = wtxtAnschluss.Text = wtxtZustand.Text = null;
            nudAnalog.Value = nudDVB_C.Value = nudDVB_T.Value = nudDVB_S.Value = nudKlinke.Value = nudODT.Value = nudHDMI.Value = nudScart.Value = nudSVideo.Value = nudCinch.Value = 0;
            cbtAnalog.Checked = cbtDVB_C.Checked = cbtDVB_T.Checked = cbtDVB_S.Checked = cbtKlinke.Checked = cbtODT.Checked = cbtHDMI.Checked = cbtScart.Checked = cbtSVideo.Checked = cbtCinch.Checked;
            wtxtKartenhersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./TVKarte_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtKartenhersteller.Text != "" && wtxtModell.Text != "" && wtxtZustand.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(@"./TVKarte_Datenbank.csv");//Datenbanck einlessen und in Datensatz speichern

                    #region Datensatz bilden
                    Datensatz += LF +
                        wtxtKartenhersteller.Text + ";" +
                        wtxtModell.Text + ";" +
                        wtxtZustand.Text + ";" +
                        wtxtAnschluss.Text + ";" +
                        nudAnalog.Value + ";" +
                        nudDVB_C.Value + ";" +
                        nudDVB_T.Value + ";" +
                        nudDVB_S.Value + ";" +
                        nudKlinke.Value + ";" +
                        nudODT.Value + ";" +
                        nudHDMI.Value + ";" +
                        nudScart.Value + ";" +
                        nudSVideo.Value + ";" +
                        nudCinch.Value;
                    #endregion

                    #region QR Code
                    QR =
                        "Kartenhersteller: " + wtxtKartenhersteller.Text + LF +
                        "Modell: " + wtxtModell.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Anschlussart: " + wtxtAnschluss.Text + LF +
                        "Analog: " + nudAnalog.Value + LF +
                        "DVB-C: " + nudDVB_C.Value + LF +
                        "DVB-T: " + nudDVB_T.Value + LF +
                        "DVB-S: " + nudDVB_S.Value + LF +
                        "Klinke: " + nudKlinke.Value + LF +
                        "ODT: " + nudODT.Value + LF +
                        "HDMI: " + nudHDMI.Value + LF +
                        "Scart: " + nudScart.Value + LF +
                        "S-Video: " + nudSVideo.Value + LF +
                        "Cinch: " + nudCinch.Value;
                    #endregion

                    File.WriteAllText(@"./TVKarte_Datenbank.csv", Datensatz);//Datensatz in GPU_Datenbank.csv schreiben
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
        private void cbtAnalog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtAnalog.Checked == true)
            {
                nudAnalog.Value = 1;
            }
            if (cbtAnalog.Checked == false)
            {
                nudAnalog.Value = 0;
            }
        }
        private void cbtDVB_C_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtDVB_C.Checked == true)
            {
                nudDVB_C.Value = 1;
            }
            if (cbtDVB_C.Checked == false)
            {
                nudDVB_C.Value = 0;
            }
        }
        private void cbtCVB_T_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtDVB_T.Checked == true)
            {
                nudDVB_T.Value = 1;
            }
            if (cbtDVB_T.Checked == false)
            {
                nudDVB_T.Value = 0;
            }
        }
        private void cbtDVB_S_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtDVB_S.Checked == true)
            {
                nudDVB_S.Value = 1;
            }
            if (cbtDVB_S.Checked == false)
            {
                nudDVB_S.Value = 0;
            }
        }
        private void cbtKlinke_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtKlinke.Checked == true)
            {
                nudKlinke.Value = 1;
            }
            if (cbtKlinke.Checked == false)
            {
                nudKlinke.Value = 0;
            }
        }
        private void cbtODT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtODT.Checked == true)
            {
                nudODT.Value = 1;
            }
            if (cbtODT.Checked == false)
            {
                nudODT.Value = 0;
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
        private void cbtScart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtScart.Checked == true)
            {
                nudScart.Value = 1;
            }
            if (cbtScart.Checked == false)
            {
                nudScart.Value = 0;
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
        #region Prüfen das Nummern Felder
        private void nudAnalog_ValueChanged(object sender, EventArgs e)
        {
            if (nudAnalog.Value > 0)
            {
                cbtAnalog.Checked = true;
            }
            if (nudAnalog.Value == 0)
            {
                cbtAnalog.Checked = false;
            }
        }
        private void nudDVB_C_ValueChanged(object sender, EventArgs e)
        {
            if (nudDVB_C.Value > 0)
            {
                cbtDVB_C.Checked = true;
            }
            if (nudDVB_C.Value == 0)
            {
                cbtDVB_C.Checked = false;
            }
        }
        private void nudCVB_T_ValueChanged(object sender, EventArgs e)
        {
            if (nudDVB_T.Value > 0)
            {
                cbtDVB_T.Checked = true;
            }
            if (nudDVB_T.Value == 0)
            {
                cbtDVB_T.Checked = false;
            }
        }
        private void nudDVB_S_ValueChanged(object sender, EventArgs e)
        {
            if (nudDVB_S.Value > 0)
            {
                cbtDVB_S.Checked = true;
            }
            if (nudDVB_S.Value == 0)
            {
                cbtDVB_S.Checked = false;
            }
        }
        private void nudKlinke_ValueChanged(object sender, EventArgs e)
        {
            if (nudKlinke.Value > 0)
            {
                cbtKlinke.Checked = true;
            }
            if (nudKlinke.Value == 0)
            {
                cbtKlinke.Checked = false;
            }
        }
        private void nudODT_ValueChanged(object sender, EventArgs e)
        {
            if (nudODT.Value > 0)
            {
                cbtODT.Checked = true;
            }
            if (nudODT.Value == 0)
            {
                cbtODT.Checked = false;
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
        private void nudScart_ValueChanged(object sender, EventArgs e)
        {
            if (nudScart.Value > 0)
            {
                cbtScart.Checked = true;
            }
            if (nudScart.Value == 0)
            {
                cbtScart.Checked = false;
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
