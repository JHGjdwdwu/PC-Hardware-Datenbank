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
        public FrontErweiterung_Imput()
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
            FrontErweiterung_Imput NewForm = new FrontErweiterung_Imput();
            NewForm.Show();
            this.Dispose(false);
            wtxtKartenhersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (wtxtZustand.Text != "")
            {
                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `fronteinschub` VALUES (''," + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Hersteller: " + wtxtKartenhersteller.Text + LF +
                        "Bezeichnung: " + wtxtID.Text + LF +
                        "<Externe Schnittstellen>" + LF +
                        "Cardreader: " + nudExternCardreader.Value + LF +
                        "USB2.0: " + nudExternUSB2.Value + LF +
                        "USB3.0: " + nudExternUSB3.Value + LF +
                        "USB3.1: " + nudExternUSB3_1.Value + LF +
                        "Line-Out: " + nudExternLineOut.Value + LF +
                        "Line-In: " + nudExternLineIn.Value + LF +
                        "FireWire: " + nudExternFireWire.Value + LF +
                        "Thunderbolt: " + nudExternThunderbolt.Value + LF +
                        "<Interne-Schnittstelle>" + LF +
                        "USB2.0: " + nudInternUSB2.Value + LF +
                        "USB3.0: " + nudInternUSB3.Value + LF +
                        "USB3.1: " + nudInternUSB3_1.Value + LF +
                        "Audio: " + nudInternAudio.Value + LF +
                        "FireWire: " + nudInternFireWire.Value + LF +
                        "Thunderbolt: " + nudInternThunderbolt.Value;
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

        private void nudExternLineOut_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternLineOut.Value > 0)
            {
                cbtExternLineOut.Checked = true;
            }
            if (nudExternLineOut.Value == 0)
            {
                cbtExternLineOut.Checked = false;
            }
        }

        private void nudExternLineIn_ValueChanged(object sender, EventArgs e)
        {
            if (nudExternLineIn.Value > 0)
            {
                cbtExternLineIn.Checked = true;
            }
            if (nudExternLineIn.Value == 0)
            {
                cbtExternLineIn.Checked = false;
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

        private void cbtExternLineOut_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternLineOut.Checked == true)
            {
                nudExternLineOut.Value = 1;
            }
            if (cbtExternLineOut.Checked == false)
            {
                nudExternLineOut.Value = 0;
            }
        }

        private void cbtExternLineIn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtExternLineIn.Checked == true)
            {
                nudExternLineIn.Value = 1;
            }
            if (cbtExternLineIn.Checked == false)
            {
                nudExternLineIn.Value = 0;
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
