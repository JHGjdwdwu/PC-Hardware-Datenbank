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
        public GPU_Imput()
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

        private void LoschFunktion()//Löschen Funktion
        {
            GPU_Imput NewForm = new GPU_Imput();
            NewForm.Show();
            this.Dispose(false);
            wtxtGPU_Hersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "" && wtxtGPU_Hersteller.Text != "" && wtxtSpeicherTyp.Text != "" && wtxtSpeichergrosse.Text != "" && txtTaktrate.Text != "" && wtxtKuhlertyp.Text != "")
            {
                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `gpu` VALUES (''," + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Bezeichnung: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "GPU-Hersteller: " + wtxtGPU_Hersteller.Text + LF +
                        "Speichertyp: " + wtxtSpeicherTyp.Text + LF +
                        "Speichergröße: " + wtxtSpeichergrosse.Text + LF +
                        "Taktrate: " + txtTaktrate.Text + LF +
                        "Kühlertyp: " + wtxtKuhlertyp.Text + LF +
                        "Stromverbrauch: " + wtxtStromverbrauch.Text + LF +
                        "Anschlussart: " + wtxtAnschluss.Text + LF +
                        "Stromversorgung: " + wtxtStromversorgung.Text + LF +
                        "Multi-Grafikkarten-Betrieb: " + wtxtMultiGPU.Text + LF +
                        "VGA: " + nudVGA.Value + LF +
                        "DVI: " + nudDVI.Value + LF +
                        "HDMI: " + nudHDMI.Value + LF +
                        "Displayport: " + nudDisplaport.Value + LF +
                        "S-Video: " + nudSVideo.Value + LF +
                        "Cinch: " + nudCinch.Value + LF +
                        "USB-C " + nudUSBC.Value;
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

        private void nudUSBC_ValueChanged(object sender, EventArgs e)
        {
            if (nudUSBC.Value > 0)
            {
                cbtUSBC.Checked = true;
            }
            if (nudUSBC.Value == 0)
            {
                cbtUSBC.Checked = false;
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

        private void cbtUSBC_Click(object sender, EventArgs e)
        {
            if (cbtUSBC.Checked == true)
            {
                nudUSBC.Value = 1;
            }
            if (cbtUSBC.Checked == false)
            {
                nudUSBC.Value = 0;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }

        
    }
}
