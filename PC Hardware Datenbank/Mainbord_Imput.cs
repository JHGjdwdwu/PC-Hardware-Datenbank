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
    public partial class Mainbord_Imput : Form
    {
        private string Datensatz = "";//Datensatz der dan in die Datenbank geschoben wird
        private char LF = (char)10;
        private string QR = "";//QR Code

        public Mainbord_Imput()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster Schlissen
        {
            Close();
        }

        private void LoschFunktion()//Löschen Funktion
        {
            txtHersteller.Text = txtTyp.Text = txtSockel.Text = txtRAM.Text = txtBauform.Text = txtSonstiges.Text = null;
            cbtAGP.Checked = cbtPCI.Checked = cbtPCIe1.Checked = cbtPCIe4.Checked = cbtPCIe8.Checked = cbtPCIe16.Checked = cbtPCIe64.Checked = cbtIDE.Checked = cbtSATA.Checked = cbtISA.Checked = false;
            cbtPS2.Checked = cbtUSB2.Checked = cbtUSB3.Checked = cbtRJ45.Checked = cbtKlinke.Checked = cbtVGA.Checked = cbtDVI.Checked = cbtHDMI.Checked = cbtDisplayPort.Checked = false;
            cbtMidiPort.Checked = cbtFireWire.Checked = cbtThunderbolt.Checked = cbtRS232.Checked = cbtBluetooth.Checked = cbtWLan.Checked = cbtLPT1.Checked = cbtESATA.Checked = cbtInfrarot.Checked = false;
            nudAGP.Value = nudPCI.Value = nudPCIe1.Value = nudPCIe4.Value = nudPCIe8.Value = nudPCIe16.Value = nudPCIe64.Value = nudIDE.Value = nudSATA.Value = nudISA.Value = 0;
            nudPS2.Value = nudUSB2.Value = nudUSB3.Value = nudRJ45.Value = nudKlinke.Value = nudVGA.Value = nudDVI.Value = nudHDMI.Value = 0;
            nudDisplayPort.Value = nudMidiPort.Value = nudFireWire.Value = nudThunderbolt.Value = nudRS232.Value = nudLPT1.Value = nudESATA.Value = 0;
            txtHersteller.Focus();
        }

        private void cmdClear_Click(object sender, EventArgs e)//Löschen Button
        {
            LoschFunktion();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)//Speichern Button
        {
            if (File.Exists(@"./Mainbord_Datenbank.csv") == true)//Prüffen ob eine .csv Datei bereits erstellt wurde
            {
                if (txtHersteller.Text != "" && txtTyp.Text != "")//Prüfft die Pflichtangaben
                {
                    Datensatz = File.ReadAllText(@"./Mainbord_Datenbank.csv");//Datenbanck lessen und in Datensatz speichern

                    #region Chak Boxen auswerten und Daten zuweisen
                    string Bluetooth = "", WLan = "", Infrarot = "";
                    if (cbtBluetooth.Checked == true)
                    {
                        Bluetooth = "JA";
                    }
                    if (cbtBluetooth.Checked == false)
                    {
                        Bluetooth = "NEIN";
                    }
                    if (cbtWLan.Checked == true)
                    {
                        WLan = "JA";
                    }
                    if (cbtWLan.Checked == false)
                    {
                        WLan = "NEIN";
                    }
                    if (cbtInfrarot.Checked == true)
                    {
                        Infrarot = "JA";
                    }
                    if (cbtInfrarot.Checked == false)
                    {
                        Infrarot = "NEIN";
                    }
                    #endregion

                    #region Datensatz bilden
                    Datensatz += LF + txtHersteller.Text + ";" + txtTyp.Text + ";" + txtSockel.Text + ";" + txtRAM.Text + ";";
                    Datensatz += txtBauform.Text + ";" + txtSonstiges.Text + ";";

                    Datensatz += nudAGP.Value + ";" + nudPCI.Value + ";" + nudPCIe1.Value + ";" + nudPCIe4.Value + ";";
                    Datensatz += nudPCIe8.Value + ";" + nudPCIe16.Value + ";" + nudPCIe64.Value + ";" + nudIDE.Value + ";";
                    Datensatz += nudSATA.Value + ";" + nudISA.Value + ";";

                    Datensatz += nudPS2.Value + ";" + nudUSB2.Value + ";" + nudUSB3.Value + ";" + nudRJ45.Value + ";";
                    Datensatz += nudKlinke.Value + ";" + nudVGA.Value + ";" + nudDVI.Value + ";" + nudHDMI.Value + ";";
                    Datensatz += nudDisplayPort.Value + ";" + nudMidiPort.Value + ";" + nudFireWire.Value + ";";
                    Datensatz += nudThunderbolt.Value + ";" + nudRS232.Value + ";" + Bluetooth + ";" + WLan + ";";
                    Datensatz += nudLPT1.Value + ";" + nudESATA.Value + ";" + Infrarot;
                    #endregion

                    #region QR Code
                    QR = "Hersteller:" + txtHersteller.Text + LF + "Typ:" + txtTyp.Text + LF + "Sockel:" + txtSockel.Text + LF + "RAM:" + txtRAM.Text + LF + "Bauform:" + txtBauform.Text + LF + "Sonstiges:" + txtSonstiges.Text + LF + "AGP:" + nudAGP.Value + LF + "PCI:" + nudPCI.Value + LF + "PCIe1:" + nudPCIe1.Value + LF + "PCIe4:" + nudPCIe4.Value + LF + "PCIe8:" + nudPCIe8.Value + LF + "PCIe16:" + nudPCIe16.Value + LF + "PCIe64:" + nudPCIe64.Value + LF + "IDE:" + nudIDE.Value + LF + "SATA:" + nudSATA.Value + LF + "ISA:" + nudISA.Value + LF;

                    QR += "PS2:" + nudPS2.Value + LF + "USB2:" + nudUSB2.Value + LF + "USB3:" + nudUSB3.Value + LF + "RJ45:" + nudRJ45.Value + LF + "Klinke:" + nudKlinke.Value + LF + "VGA:" + nudVGA.Value + LF + "DVI:" + nudDVI.Value + LF + "HDMI:" + nudHDMI.Value + LF + "DisplayPort:" + nudDisplayPort.Value + LF + "MidiPort:" + nudMidiPort.Value + LF + "FireWire:" + nudFireWire.Value + LF + "Thunderbolt:" + nudThunderbolt.Value + LF + "RS232:" + nudRS232.Value + LF + "Bluetooth:" + Bluetooth + LF + "WLan:" + WLan + LF + "LPT1:" + nudLPT1.Value + LF + "ESATA:" + nudESATA.Value + LF + "Infrarot:" + Infrarot;
                    #endregion

                    File.WriteAllText(@"./Mainbord_Datenbank.csv", Datensatz);//Datensatz in Mainbord_Datenbank.csv schreiben
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

        #region Check Boxen auswerten und wen gedrückt Nummern Feld + 1
        private void cbtAGP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtAGP.Checked == true)
            {
                nudAGP.Value = 1;
            }
            if (cbtAGP.Checked == false)
            {
                nudAGP.Value = 0;
            }
        }

        private void cbtPCI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPCI.Checked == true)
            {
                nudPCI.Value = 1;
            }
            if (cbtPCI.Checked == false)
            {
                nudPCI.Value = 0;
            }
        }

        private void cbtPCIe1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPCIe1.Checked == true)
            {
                nudPCIe1.Value = 1;
            }
            if (cbtPCIe1.Checked == false)
            {
                nudPCIe1.Value = 0;
            }
        }

        private void cbtPCIe4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPCIe4.Checked == true)
            {
                nudPCIe4.Value = 1;
            }
            if (cbtPCIe4.Checked == false)
            {
                nudPCIe4.Value = 0;
            }
        }

        private void cbtPCIe8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPCIe8.Checked == true)
            {
                nudPCIe8.Value = 1;
            }
            if (cbtPCIe8.Checked == false)
            {
                nudPCIe8.Value = 0;
            }
        }

        private void cbtPCIe16_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPCIe16.Checked == true)
            {
                nudPCIe16.Value = 1;
            }
            if (cbtPCIe16.Checked == false)
            {
                nudPCIe16.Value = 0;
            }
        }

        private void cbtPCIe64_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPCIe64.Checked == true)
            {
                nudPCIe64.Value = 1;
            }
            if (cbtPCIe64.Checked == false)
            {
                nudPCIe64.Value = 0;
            }
        }

        private void cbtIDE_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtIDE.Checked == true)
            {
                nudIDE.Value = 1;
            }
            if (cbtIDE.Checked == false)
            {
                nudIDE.Value = 0;
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

        private void cbtISA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtISA.Checked == true)
            {
                nudISA.Value = 1;
            }
            if (cbtISA.Checked == false)
            {
                nudISA.Value = 0;
            }
        }

        private void cbtPS2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtPS2.Checked == true)
            {
                nudPS2.Value = 1;
            }
            if (cbtPS2.Checked == false)
            {
                nudPS2.Value = 0;
            }
        }

        private void cbtUSB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtUSB2.Checked == true)
            {
                nudUSB2.Value = 1;
            }
            if (cbtUSB2.Checked == false)
            {
                nudUSB2.Value = 0;
            }
        }

        private void cbtUSB3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtUSB3.Checked == true)
            {
                nudUSB3.Value = 1;
            }
            if (cbtUSB3.Checked == false)
            {
                nudUSB3.Value = 0;
            }
        }

        private void cbtRJ45_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtRJ45.Checked == true)
            {
                nudRJ45.Value = 1;
            }
            if (cbtRJ45.Checked == false)
            {
                nudRJ45.Value = 0;
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

        private void cbtDisplayPort_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtDisplayPort.Checked == true)
            {
                nudDisplayPort.Value = 1;
            }
            if (cbtDisplayPort.Checked == false)
            {
                nudDisplayPort.Value = 0;
            }
        }

        private void cbtMidiPort_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtMidiPort.Checked == true)
            {
                nudMidiPort.Value = 1;
            }
            if (cbtMidiPort.Checked == false)
            {
                nudMidiPort.Value = 0;
            }
        }

        private void cbtFireWire_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtFireWire.Checked == true)
            {
                nudFireWire.Value = 1;
            }
            if (cbtFireWire.Checked == false)
            {
                nudFireWire.Value = 0;
            }
        }

        private void cbtThunderbolt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtThunderbolt.Checked == true)
            {
                nudThunderbolt.Value = 1;
            }
            if (cbtThunderbolt.Checked == false)
            {
                nudThunderbolt.Value = 0;
            }
        }

        private void cbtRS232_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtRS232.Checked == true)
            {
                nudRS232.Value = 1;
            }
            if (cbtRS232.Checked == false)
            {
                nudRS232.Value = 0;
            }
        }

        private void cbtLPT1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtLPT1.Checked == true)
            {
                nudLPT1.Value = 1;
            }
            if (cbtLPT1.Checked == false)
            {
                nudLPT1.Value = 0;
            }
        }

        private void cbtESATA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtESATA.Checked == true)
            {
                nudESATA.Value = 1;
            }
            if (cbtESATA.Checked == false)
            {
                nudESATA.Value = 0;
            }
        }
        #endregion

        #region Nummer Felder Überwachen wenn nicht 0 dan Check Box aktiviren
        private void nudAGP_ValueChanged(object sender, EventArgs e)
        {
            if (nudAGP.Value != 0)
            {
                cbtAGP.Checked = true;
            }
            if (nudAGP.Value == 0)
            {
                cbtAGP.Checked = false;
            }
        }

        private void nudPCI_ValueChanged(object sender, EventArgs e)
        {
            if (nudPCI.Value != 0)
            {
                cbtPCI.Checked = true;
            }
            if (nudPCI.Value == 0)
            {
                cbtPCI.Checked = false;
            }
        }

        private void nudPCIe1_ValueChanged(object sender, EventArgs e)
        {
            if (nudPCIe1.Value != 0)
            {
                cbtPCIe1.Checked = true;
            }
            if (nudPCIe1.Value == 0)
            {
                cbtPCIe1.Checked = false;
            }
        }

        private void nudPCIe4_ValueChanged(object sender, EventArgs e)
        {
            if (nudPCIe4.Value != 0)
            {
                cbtPCIe4.Checked = true;
            }
            if (nudPCIe4.Value == 0)
            {
                cbtPCIe4.Checked = false;
            }
        }

        private void nudPCIe8_ValueChanged(object sender, EventArgs e)
        {
            if (nudPCIe8.Value != 0)
            {
                cbtPCIe8.Checked = true;
            }
            if (nudPCIe8.Value == 0)
            {
                cbtPCIe8.Checked = false;
            }
        }

        private void nudPCIe16_ValueChanged(object sender, EventArgs e)
        {
            if (nudPCIe16.Value != 0)
            {
                cbtPCIe16.Checked = true;
            }
            if (nudPCIe16.Value == 0)
            {
                cbtPCIe16.Checked = false;
            }
        }

        private void nudPCIe64_ValueChanged(object sender, EventArgs e)
        {
            if (nudPCIe64.Value != 0)
            {
                cbtPCIe64.Checked = true;
            }
            if (nudPCIe64.Value == 0)
            {
                cbtPCIe64.Checked = false;
            }
        }

        private void nudIDE_ValueChanged(object sender, EventArgs e)
        {
            if (nudIDE.Value != 0)
            {
                cbtIDE.Checked = true;
            }
            if (nudIDE.Value == 0)
            {
                cbtIDE.Checked = false;
            }
        }

        private void nudSATA_ValueChanged(object sender, EventArgs e)
        {
            if (nudSATA.Value != 0)
            {
                cbtSATA.Checked = true;
            }
            if (nudSATA.Value == 0)
            {
                cbtSATA.Checked = false;
            }
        }

        private void nudISA_ValueChanged(object sender, EventArgs e)
        {
            if (nudISA.Value != 0)
            {
                cbtISA.Checked = true;
            }
            if (nudISA.Value == 0)
            {
                cbtISA.Checked = false;
            }
        }

        private void nudPS2_ValueChanged(object sender, EventArgs e)
        {
            if (nudPS2.Value != 0)
            {
                cbtPS2.Checked = true;
            }
            if (nudPS2.Value == 0)
            {
                cbtPS2.Checked = false;
            }
        }

        private void nudUSB2_ValueChanged(object sender, EventArgs e)
        {
            if (nudUSB2.Value != 0)
            {
                cbtUSB2.Checked = true;
            }
            if (nudUSB2.Value == 0)
            {
                cbtUSB2.Checked = false;
            }
        }

        private void nudUSB3_ValueChanged(object sender, EventArgs e)
        {
            if (nudUSB3.Value != 0)
            {
                cbtUSB3.Checked = true;
            }
            if (nudUSB3.Value == 0)
            {
                cbtUSB3.Checked = false;
            }
        }

        private void nudRJ45_ValueChanged(object sender, EventArgs e)
        {
            if (nudRJ45.Value != 0)
            {
                cbtRJ45.Checked = true;
            }
            if (nudRJ45.Value == 0)
            {
                cbtRJ45.Checked = false;
            }
        }

        private void nudKlinke_ValueChanged(object sender, EventArgs e)
        {
            if (nudKlinke.Value != 0)
            {
                cbtKlinke.Checked = true;
            }
            if (nudKlinke.Value == 0)
            {
                cbtKlinke.Checked = false;
            }
        }

        private void nudVGA_ValueChanged(object sender, EventArgs e)
        {
            if (nudVGA.Value != 0)
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
            if (nudDVI.Value != 0)
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
            if (nudHDMI.Value != 0)
            {
                cbtHDMI.Checked = true;
            }
            if (nudHDMI.Value == 0)
            {
                cbtHDMI.Checked = false;
            }
        }

        private void nudDisplayPort_ValueChanged(object sender, EventArgs e)
        {
            if (nudDisplayPort.Value != 0)
            {
                cbtDisplayPort.Checked = true;
            }
            if (nudDisplayPort.Value == 0)
            {
                cbtDisplayPort.Checked = false;
            }
        }

        private void nudMidiPort_ValueChanged(object sender, EventArgs e)
        {
            if (nudMidiPort.Value != 0)
            {
                cbtMidiPort.Checked = true;
            }
            if (nudMidiPort.Value == 0)
            {
                cbtMidiPort.Checked = false;
            }
        }

        private void nudFireWire_ValueChanged(object sender, EventArgs e)
        {
            if (nudFireWire.Value != 0)
            {
                cbtFireWire.Checked = true;
            }
            if (nudFireWire.Value == 0)
            {
                cbtFireWire.Checked = false;
            }
        }

        private void nudThunderbolt_ValueChanged(object sender, EventArgs e)
        {
            if (nudThunderbolt.Value != 0)
            {
                cbtThunderbolt.Checked = true;
            }
            if (nudThunderbolt.Value == 0)
            {
                cbtThunderbolt.Checked = false;
            }
        }

        private void nudRS232_ValueChanged(object sender, EventArgs e)
        {
            if (nudRS232.Value != 0)
            {
                cbtRS232.Checked = true;
            }
            if (nudRS232.Value == 0)
            {
                cbtRS232.Checked = false;
            }
        }

        private void nudLPT1_ValueChanged(object sender, EventArgs e)
        {
            if (nudLPT1.Value != 0)
            {
                cbtLPT1.Checked = true;
            }
            if (nudLPT1.Value == 0)
            {
                cbtLPT1.Checked = false;
            }
        }

        private void nudESATA_ValueChanged(object sender, EventArgs e)
        {
            if (nudESATA.Value != 0)
            {
                cbtESATA.Checked = true;
            }
            if (nudESATA.Value == 0)
            {
                cbtESATA.Checked = false;
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
