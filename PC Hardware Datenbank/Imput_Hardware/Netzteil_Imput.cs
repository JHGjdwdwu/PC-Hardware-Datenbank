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
        public Netzteil_Imput()
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
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "" && nudLufter.Text != "" && wtxtFormat.Text != "" && wtxtLeistung.Text != "" && wtxtSteckerFormat.Text != "")
            {
                #region CheckBox auswerten für QR-Code
                string Netzausgang = "Nein", Netzschalter = "Nein", Schalter110V = "Nein", Betrib110V = "Nein";
                if (cbtStromAusganag.Checked)
                {
                    Netzausgang = "Ja";
                }
                if (cbtSchalter.Checked)
                {
                    Netzschalter = "Ja";
                }
                if (cbt110vSchalter.Checked)
                {
                    Schalter110V = "Ja";
                }
                if (cbt110vBetrieb.Checked)
                {
                    Betrib110V = "Ja";
                }
                #endregion

                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `netzteil` VALUES (''," + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR =
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Typ: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Anzahl Lüfter: " + nudLufter.Value + LF +
                        "Breite-Tiefe-Höhe: " + wtxtFormat.Text + LF +
                        "Leistung: " + wtxtLeistung.Text + LF +
                        "Stecker Format: " + wtxtSteckerFormat.Text + LF +
                        "max Ampere 3V: " + nud3V.Value + LF +
                        "Leistung 3V: " + nud3W.Value + LF +
                        "max Ampere 5V: " + nud5V.Value + LF +
                        "Leistung 5V: " + nud5W.Value + LF +
                        "max Ampere 12V: " + nud12V.Value + LF +
                        "Leistung 12V: " + nud12W.Value + LF +
                        "Netzausgang: " + Netzausgang + LF +
                        "Netzschalter: " + Netzschalter + LF +
                        "110V Schalter: " + Schalter110V + LF +
                        "110V Betrieb möglich: " + Betrib110V + LF +
                        "Molex-8981: " + nudMolex8981.Value + LF +
                        "SATA: " + nudSATA.Value + LF +
                        "AT: " + nudAT.Value + LF +
                        "2x2-12V: " + nud2x2.Value + LF +
                        "2x3-12V: " + nud2x3.Value + LF +
                        "2x4-12V: " + nud2x4.Value + LF +
                        "BERG: " + nudBerg.Value;
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
            if (cbt110vSchalter.Checked == true)
            {
                cbt110vBetrieb.Checked = true;
            }
            if (cbt110vSchalter.Checked == false)
            {
                cbt110vBetrieb.Checked = false;
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
