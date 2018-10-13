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
    public partial class Netzteil_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code
        public string DateiPfad;

        public Netzteil_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schlißen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            Netzteil_Imput NewForm = new Netzteil_Imput();
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
            if (File.Exists(DateiPfad + @"/Netzteil_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (wtxtHersteller.Text != "" && wtxtTyp.Text != "" && wtxtZustand.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(DateiPfad + @"/Netzteil_Datenbank.csv");//Alte Daten einlessen und in Datensatz speichern

                    #region Chak Boxen auswerten und Daten zuweisen
                    string StromAusgang = "NEIN";
                    if (cbtxStromAusganag.Checked == true)
                    {
                        StromAusgang = "JA";
                    }
                    string Netzschalter = "NEIN";
                    if (cbtxSchaltera.Checked == true)
                    {
                        Netzschalter = "JA";
                    }
                    string Schalter110V = "NEIN";
                    if (cbtx110vSchalter.Checked == true)
                    {
                        Schalter110V = "JA";
                    }
                    string Betrieb110Vmöglich = "NEIN";
                    if (cbtx110vBetrieb.Checked == true)
                    {
                        Betrieb110Vmöglich = "JA";
                    }
                    #endregion

                    #region Datensatz bilden
                    Datensatz += LF + 
                        wtxtHersteller.Text + ";" +
                        wtxtTyp.Text + ";" +
                        wtxtZustand.Text + ";" +
                        nudLuster.Value + ";" +
                        wtxtFormat.Text + ";" +
                        wtxtLeistung.Text + ";" +
                        nud3V.Value + ";" +
                        nud3W.Value + ";" +
                        nud5V.Value + ";" +
                        nud5W.Value + ";" +
                        nud12V.Value + ";" +
                        nud12W.Value + ";" +
                        StromAusgang + ";" +
                        Netzschalter + ";" +
                        Schalter110V + ";" +
                        Betrieb110Vmöglich + ";" +
                        nudMolex8981.Value + ";" +
                        nudSATA.Value + ";" +
                        nudAT.Value + ";" +
                        nudATX.Value + ";" +
                        nudBTX.Value + ";" +
                        nudATXlarge.Value + ";" +
                        nudCFX.Value + ";" +
                        nudSFX.Value + ";" +
                        nudTFX.Value + ";" +
                        nudLFX.Value + ";" +
                        nud2x2.Value + ";" +
                        nud2x3.Value + ";" +
                        nud2x4.Value + ";" +
                        nudBerg.Value;
                    #endregion

                    #region QR Code
                    QR = 
                        "Hersteller: " + wtxtHersteller.Text + LF + 
                        "Typ: " + wtxtTyp.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Anzahl Lüfter: " + nudLuster.Value + LF + 
                        "Breite-Tiefe-Höhe: " + wtxtFormat.Text + LF + 
                        "Leistung: " + wtxtLeistung.Text + LF +
                        "max Ampere 3V: " + nud3V.Value + LF +
                        "Leistung 3V: " + nud3W.Value + LF +
                        "max Ampere 5V: " + nud5V.Value + LF +
                        "Leistung 5V: " + nud5W.Value + LF +
                        "max Ampere 12V: " + nud12V.Value + LF +
                        "Leistung 12V: " + nud12W.Value + LF +
                        "Stromausgang: " + StromAusgang + LF + 
                        "Netzschalter: " + Netzschalter + LF + 
                        "110V Schalter: " + Schalter110V + LF + 
                        "110V Betrieb möglich: " + Betrieb110Vmöglich + LF + 
                        "Molex-8981: " + nudMolex8981.Value + LF + 
                        "SATA: " + nudSATA.Value + LF + 
                        "AT: " + nudAT.Value + LF + 
                        "ATX: " + nudATX.Value + LF + 
                        "BTX: " + nudBTX.Value + LF + 
                        "ATX large: " + nudATXlarge.Value + LF + 
                        "CFX: " + nudCFX.Value + LF + 
                        "SFX: " + nudSFX.Value + LF + 
                        "TFX: " + nudTFX.Value + LF + 
                        "LFX: " + nudLFX.Value + LF + 
                        "2x2-12V: " + nud2x2.Value + LF + 
                        "2x3-12V: " + nud2x3.Value + LF + 
                        "2x4-12V: " + nud2x4.Value + LF + 
                        "BERG: " + nudBerg.Value;
                    #endregion

                    File.WriteAllText(DateiPfad + @"/Netzteil_Datenbank.csv", Datensatz);//Datensatz in GPU_Datenbank.csv schreiben
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

        #region Check Box auswerten
        private void cbtMolex8981_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtMolex8981.Checked == true)
            {
                nudMolex8981.Value = 1;
            }
            if (cbtMolex8981.Checked == false)
            {
                nudMolex8981.Value = 0;
            }
        }

        private void cbtSATA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtSATA.Checked == true)
            {
                nudSATA.Value = 1;
            }
            if (cbtSATA.Checked == false)
            {
                nudSATA.Value = 0;
            }
        }

        private void cbtAT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtAT.Checked == true)
            {
                nudAT.Value = 1;
            }
            if (cbtAT.Checked == false)
            {
                nudAT.Value = 0;
            }
        }

        private void cbtATX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtATX.Checked == true)
            {
                nudATX.Value = 1;
            }
            if (cbtATX.Checked == false)
            {
                nudATX.Value = 0;
            }
        }

        private void cbtBTX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtBTX.Checked == true)
            {
                nudBTX.Value = 1;
            }
            if (cbtBTX.Checked == false)
            {
                nudBTX.Value = 0;
            }
        }

        private void cbtATXlarge_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtATXlarge.Checked == true)
            {
                nudATXlarge.Value = 1;
            }
            if (cbtATXlarge.Checked == false)
            {
                nudATXlarge.Value = 0;
            }
        }

        private void cbtCFX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtCFX.Checked == true)
            {
                nudCFX.Value = 1;
            }
            if (cbtCFX.Checked == false)
            {
                nudCFX.Value = 0;
            }
        }

        private void cbtSFX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtSFX.Checked == true)
            {
                nudSFX.Value = 1;
            }
            if (cbtSFX.Checked == false)
            {
                nudSFX.Value = 0;
            }
        }

        private void cbtTFX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtTFX.Checked == true)
            {
                nudTFX.Value = 1;
            }
            if (cbtTFX.Checked == false)
            {
                nudTFX.Value = 0;
            }
        }

        private void cbtLFX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtLFX.Checked == true)
            {
                nudLFX.Value = 1;
            }
            if (cbtLFX.Checked == false)
            {
                nudLFX.Value = 0;
            }
        }

        private void cbt2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbt2x2.Checked == true)
            {
                nud2x2.Value = 1;
            }
            if (cbt2x2.Checked == false)
            {
                nud2x2.Value = 0;
            }
        }

        private void cbt2x3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbt2x3.Checked == true)
            {
                nud2x3.Value = 1;
            }
            if (cbt2x3.Checked == false)
            {
                nud2x3.Value = 0;
            }
        }

        private void cbt2x4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbt2x4.Checked == true)
            {
                nud2x4.Value = 1;
            }
            if (cbt2x4.Checked == false)
            {
                nud2x4.Value = 0;
            }
        }

        private void cbtBerg_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtBerg.Checked == true)
            {
                nudBerg.Value = 1;
            }
            if (cbtBerg.Checked == false)
            {
                nudBerg.Value = 0;
            }
        }
        #endregion

        #region Nummern Felder auswerten
        private void nudMolex8981_ValueChanged(object sender, EventArgs e)
        {
            if (nudMolex8981.Value > 0)
            {
                cbtMolex8981.Checked = true;
            }
            if (nudMolex8981.Value < 1)
            {
                cbtMolex8981.Checked = false;
            }
        }

        private void nudSATA_ValueChanged(object sender, EventArgs e)
        {
            if (nudSATA.Value > 0)
            {
                cbtSATA.Checked = true;
            }
            if (nudSATA.Value < 1)
            {
                cbtSATA.Checked = false;
            }
        }

        private void nudAT_ValueChanged(object sender, EventArgs e)
        {
            if (nudAT.Value > 0)
            {
                cbtAT.Checked = true;
            }
            if (nudAT.Value < 1)
            {
                cbtAT.Checked = false;
            }
        }

        private void nudATX_ValueChanged(object sender, EventArgs e)
        {
            if (nudATX.Value > 0)
            {
                cbtATX.Checked = true;
            }
            if (nudATX.Value < 1)
            {
                cbtATX.Checked = false;
            }
        }

        private void nudBTX_ValueChanged(object sender, EventArgs e)
        {
            if (nudBTX.Value > 0)
            {
                cbtBTX.Checked = true;
            }
            if (nudBTX.Value < 1)
            {
                cbtBTX.Checked = false;
            }
        }

        private void nudATXlarge_ValueChanged(object sender, EventArgs e)
        {
            if (nudATXlarge.Value > 0)
            {
                cbtATXlarge.Checked = true;
            }
            if (nudATXlarge.Value < 1)
            {
                cbtATXlarge.Checked = false;
            }
        }

        private void nudCFX_ValueChanged(object sender, EventArgs e)
        {
            if (nudCFX.Value > 0)
            {
                cbtCFX.Checked = true;
            }
            if (nudCFX.Value < 1)
            {
                cbtCFX.Checked = false;
            }
        }

        private void nudSFX_ValueChanged(object sender, EventArgs e)
        {
            if (nudSFX.Value > 0)
            {
                cbtSFX.Checked = true;
            }
            if (nudSFX.Value < 1)
            {
                cbtSFX.Checked = false;
            }
        }

        private void nudTFX_ValueChanged(object sender, EventArgs e)
        {
            if (nudTFX.Value > 0)
            {
                cbtTFX.Checked = true;
            }
            if (nudTFX.Value < 1)
            {
                cbtTFX.Checked = false;
            }
        }

        private void nudLFX_ValueChanged(object sender, EventArgs e)
        {
            if (nudLFX.Value > 0)
            {
                cbtLFX.Checked = true;
            }
            if (nudLFX.Value < 1)
            {
                cbtLFX.Checked = false;
            }
        }

        private void nud2x2_ValueChanged(object sender, EventArgs e)
        {
            if (nud2x2.Value > 0)
            {
                cbt2x2.Checked = true;
            }
            if (nud2x2.Value < 1)
            {
                cbt2x2.Checked = false;
            }
        }

        private void nud2x3_ValueChanged(object sender, EventArgs e)
        {
            if (nud2x3.Value > 0)
            {
                cbt2x3.Checked = true;
            }
            if (nud2x3.Value < 1)
            {
                cbt2x3.Checked = false;
            }
        }

        private void nud2x4_ValueChanged(object sender, EventArgs e)
        {
            if (nud2x4.Value > 0)
            {
                cbt2x4.Checked = true;
            }
            if (nud2x4.Value < 1)
            {
                cbt2x4.Checked = false;
            }
        }

        private void nudBerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudBerg.Value > 0)
            {
                cbtBerg.Checked = true;
            }
            if (nudBerg.Value < 1)
            {
                cbtBerg.Checked = false;
            }
        }
        #endregion

        #region 110V Auswertung Logische schaltung
        private void cbtx110vSchalter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtx110vSchalter.Checked == true)
            {
                cbtx110vBetrieb.Checked = true;
            }
            if (cbtx110vSchalter.Checked == false)
            {
                cbtx110vBetrieb.Checked = false;
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

        private void Netzteil_Imput_Load(object sender, EventArgs e)//lesen des gespeicherten DateiPfad
        {
            DateiPfad = File.ReadAllText(@"./settings");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }
}
