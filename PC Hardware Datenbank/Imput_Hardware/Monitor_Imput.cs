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
        public Monitor_Imput()
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
            Monitor_Imput NewForm = new Monitor_Imput();
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
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "")
            {
                #region CheckBox auswertung
                string Lautsprecher, HohenVerstellbar, VESA;

                if (cbtLautsprecher.Checked)
                {
                    Lautsprecher = "ja";
                }
                else
                {
                    Lautsprecher = "Nein";
                }

                if (cbtHohenVerstellbar.Checked)
                {
                    HohenVerstellbar = "ja";
                }
                else
                {
                    HohenVerstellbar = "Nein";
                }

                if (cbtVESA.Checked)
                {
                    VESA = "ja";
                }
                else
                {
                    VESA = "Nein";
                }
                #endregion

                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `monitor` VALUES (" + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Modell: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Technik: " + wtxtTechnik.Text + LF +
                        "Max.Auflösung: " + wtxtMaxAuflosung.Text + LF +
                        "Lautsprecher: " + Lautsprecher + LF +
                        "Höhen verstellbar: " + HohenVerstellbar + LF +
                        "VESA Halterung: " + VESA + LF +
                        "<Eingänge>" + LF +
                        "VGA: " + nudEingangVGA.Value + LF +
                        "DVI: " + nudEingangDVI.Value + LF +
                        "HDMI: " + nudEingangHDMI.Value + LF +
                        "Displayport: " + nudEingangDisplaport.Value + LF +
                        "RGB: " + nudEingangRGB.Value + LF +
                        "Ausio: " + nudEingangAudio.Value + LF +
                        "USB: " + nudEingangUSBC.Value + LF +
                        "<Ausgänge>" + LF +
                        "Audio: " + nudAusgangAudio.Value + LF +
                        "USB: " + nudAusgangUSB.Value;
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
            if (cbtEingangUSBC.Checked == true)
            {
                nudEingangUSBC.Value = 1;
            }
            if (cbtEingangUSBC.Checked == false)
            {
                nudEingangUSBC.Value = 0;
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
            if (nudEingangVGA.Value != 0)
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
            if (nudEingangDVI.Value != 0)
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
            if (nudEingangHDMI.Value != 0)
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
            if (nudEingangDisplaport.Value != 0)
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
            if (nudEingangRGB.Value != 0)
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
            if (nudEingangAudio.Value != 0)
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
            if (nudEingangUSBC.Value != 0)
            {
                cbtEingangUSBC.Checked = true;
            }
            if (nudEingangUSBC.Value == 0)
            {
                cbtEingangUSBC.Checked = false;
            }
        }

        private void nudAusgangAudio_ValueChanged(object sender, EventArgs e)
        {
            if (nudAusgangAudio.Value != 0)
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
            if (nudAusgangUSB.Value != 0)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }
}
