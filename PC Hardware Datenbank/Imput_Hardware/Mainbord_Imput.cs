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
    public partial class Mainboard_Imput : Form
    {
        public Mainboard_Imput()
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
            Mainboard_Imput NewForm = new Mainboard_Imput();
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
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "" && wtxtSockel.Text != "" && wtxtRAM.Text != "" && wtxtBauform.Text != "")
            {
                #region CheckBox auswerten
                string Bluetooth, WLan, Infrarot;
                if (cbtBluetooth.Checked)
                {
                    Bluetooth = "Ja";
                }
                else
                {
                    Bluetooth = "Nein";
                }

                if (cbtWLan.Checked)
                {
                    WLan = "Ja";
                }
                else
                {
                    WLan = "Nein";
                }

                if (cbtInfrarot.Checked)
                {
                    Infrarot = "Ja";
                }
                else
                {
                    Infrarot = "Nein";
                }
                #endregion

                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `mainboard` VALUES (" + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Bezeichnung: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Sockel: " + wtxtSockel.Text + LF +
                        "RAM Typ: " + wtxtRAM.Text + LF +
                        "Bauform: " + wtxtBauform.Text + LF +
                        "Sonstiges: " + txtSonstiges.Text + LF +
                        "AGP: " + nudAGP.Value + LF +
                        "PCI: " + nudPCI.Value + LF +
                        "PCIe1: " + nudPCIe1.Value + LF +
                        "PCIe4: " + nudPCIe4.Value + LF +
                        "PCIe8: " + nudPCIe8.Value + LF +
                        "PCIe16: " + nudPCIe16.Value + LF +
                        "IDE: " + nudIDE.Value + LF +
                        "SATA: " + nudSATA.Value + LF +
                        "ISA: " + nudISA.Value + LF +
                        "M.2: " + nudM2.Value + LF +
                        "PS2: " + nudPS2.Value + LF +
                        "USB 2: " + nudUSB2.Value + LF +
                        "USB 3.0: " + nudUSB3.Value + LF +
                        "USB 3.1: " + nudUSB31.Value + LF +
                        "USB-C: " + nudUSBC.Value + LF +
                        "RJ45: " + nudRJ45.Value + LF +
                        "Audio: " + wtxtAudio.Text + LF +
                        "VGA: " + nudVGA.Value + LF +
                        "DVI: " + nudDVI.Value + LF +
                        "HDMI: " + nudHDMI.Value + LF +
                        "DisplayPort: " + nudDisplayPort.Value + LF +
                        "MidiPort: " + nudMidiPort.Value + LF +
                        "FireWire: " + nudFireWire.Value + LF +
                        "Thunderbolt: " + nudThunderbolt.Value + LF +
                        "RS 232: " + nudRS232.Value + LF +
                        "eSATA: " + nudESATA.Value + LF +
                        "LPT1: " + nudLPT1.Value + LF +
                        "WLan: " + WLan + LF +
                        "Bluetooth: " + Bluetooth + LF +
                        "Infrarot: " + Infrarot;
                    #endregion

                    DialogResult dialogresult = MessageBox.Show("Möchten Sie einen QR-Code Drucken?", "QR-Code Drucken?",MessageBoxButtons.YesNo);
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

        #region CheckBox auswerten wenn true NumericUpDown + 1

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

        private void cbtM2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtM2.Checked == true)
            {
                nudM2.Value = 1;
            }
            if (cbtM2.Checked == false)
            {
                nudM2.Value = 0;
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

        private void cbtUSB31_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtUSB31.Checked == true)
            {
                nudUSB31.Value = 1;
            }
            if (cbtUSB31.Checked == false)
            {
                nudUSB31.Value = 0;
            }
        }

        private void cbtUSBC_CheckedChanged(object sender, EventArgs e)
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

        #region NumericUpDown überwachen wenn 0 dann CheckBox false

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

        private void nudM2_ValueChanged(object sender, EventArgs e)
        {
            if (nudM2.Value != 0)
            {
                cbtM2.Checked = true;
            }
            if (nudM2.Value == 0)
            {
                cbtM2.Checked = false;
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

        private void nudUSB31_ValueChanged(object sender, EventArgs e)
        {
            if (nudUSB31.Value != 0)
            {
                cbtUSB31.Checked = true;
            }
            if (nudUSB31.Value == 0)
            {
                cbtUSB31.Checked = false;
            }
        }

        private void nudUSBC_ValueChanged(object sender, EventArgs e)
        {
            if (nudUSBC.Value != 0)
            {
                cbtUSBC.Checked = true;
            }
            if (nudUSBC.Value == 0)
            {
                cbtUSBC.Checked = false;
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
