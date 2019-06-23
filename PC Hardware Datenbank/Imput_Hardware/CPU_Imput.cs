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
    public partial class CPU_Imput : Form
    {
        public CPU_Imput()
        {
            InitializeComponent();
        }

        Methoden methoden = new Methoden();
        private char LF = (char)10;
        private string QR = "";//QR Code

        private void cmdBeenden_Click(object sender, EventArgs e)//Fenster schliessen
        {
            Close();
        }

        private void LoschFunktion()//Löschfunktion
        {
            CPU_Imput NewForm = new CPU_Imput();
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
            if (wtxtHersteller.Text != "" && wtxtID.Text != "" && wtxtZustand.Text != "" && wtxtSockel.Text != "" && wtxtTaktrate.Text != "" && nudKerne.Text != "")
            {
                try
                {
                    string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
                    methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
                    string Datensatz = methoden.ObjekteTextToString(",", this);//Erzeugt ein String aus den Daten auf der Form
                    string sqldatensatz = Datensatz.Substring(0, Datensatz.Length - 1);//Entfert ein überflüssiges Zeichen (Grund Schleife)
                    string mysqlcommandtext = "INSERT INTO `cpu` VALUES ('';" + sqldatensatz + ");";//SQL Befehl Abfrage aller User
                    methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Daten in die Datenbank schreiben
                    LoschFunktion();
                    wtxtZustand.Focus();
                    MessageBox.Show("Daten wurden erfolgreich gespeichert!");

                    #region QR Code
                    QR +=
                        "Hersteller: " + wtxtHersteller.Text + LF +
                        "Bezeichnung: " + wtxtID.Text + LF +
                        "Zustand: " + wtxtZustand.Text + LF +
                        "Sockel: " + wtxtSockel.Text + LF +
                        "Taktrate: " + wtxtTaktrate.Text + LF +
                        "Anzahl Kerne: " + nudKerne.Value + LF +
                        "Level1 Cache: " + nudCach1.Value + LF +
                        "Level2 Cache: " + nudCach2.Value + LF +
                        "Level3 Cache: " + nudCach3.Value + LF;
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

        private void wtxtHersteller_SelectedIndexChanged(object sender, EventArgs e)//Giebt die Sokel für den Hersteller frei
        {
            string[] INTEL = new string[] { "3", "4", "5", "6", "7", "463/NextGen", "8", "Slot 1", "479", "M", "P", "370", "µPGA2", "Slot 2", "495", "603", "604", "771/J", "1356/B2", "441", "423", "478", "1150", "1151", "1155", "1156", "1567", "2011", "2011-3", "3647/P3", "775/T", "989/G1", "1366" };
            string[] ADM = new string[] { "7", "Slot A", "A/462", "563", "754", "939", "940", "F/1207", "S1", "AM2", "AM2+", "AM3", "AM3+", "AM4", "FM1", "FM2", "FM2+", "TR4" };
            string[] SOCKEL = INTEL.Concat(ADM).ToArray();

            if (wtxtHersteller.Text == "Intel")
            {
                wtxtSockel.DataSource = INTEL;
            }

            if (wtxtHersteller.Text == "AMD")
            {
                wtxtSockel.DataSource = ADM;
            }
        }

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
