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
    public partial class Home_Suche : Form
    {
        public Home_Suche()
        {
            InitializeComponent();
            Form_anpassen_an_Rechte();
        }

        Methoden methoden = new Methoden();
        string tabel = null;
        string QR = null;
        private char LF = (char)10;

        private void cmdBeenden_Click(object sender, EventArgs e)//Button Beenden
        {
            Application.Exit();
        }

        private void wtxtSuche_SelectedIndexChanged(object sender, EventArgs e)//wtxtSuchen ListTextBox Bild je nach wahl zuweisen
        {
            string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
            methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
            string mysqlcommandtext = null;

            if (wtxtSuche.Text == "Mainboard")
            {
                img.Image = Properties.Resources.Mainboard;
                mysqlcommandtext = "SELECT * FROM `mainboard`;";//SQL Abfrage Befehl
                tabel = "mainboard";
            }
            if (wtxtSuche.Text == "CPU")
            {
                img.Image = Properties.Resources.CPU;
                mysqlcommandtext = "SELECT * FROM `cpu`;";//SQL Abfrage Befehl
                tabel = "cpu";
            }
            if (wtxtSuche.Text == "RAM")
            {
                img.Image = Properties.Resources.RAM;
                mysqlcommandtext = "SELECT * FROM `ram`;";//SQL Abfrage Befehl
                tabel = "ram";
            }
            if (wtxtSuche.Text == "GPU")
            {
                img.Image = Properties.Resources.GPU;
                mysqlcommandtext = "SELECT * FROM `gpu`;";//SQL Abfrage Befehl;
                tabel = "gpu";
            }
            if (wtxtSuche.Text == "HDD")
            {
                img.Image = Properties.Resources.HDD;
                mysqlcommandtext = "SELECT * FROM `hdd`;";//SQL Abfrage Befehl
                tabel = "hdd";
            }
            if (wtxtSuche.Text == "Netzteil")
            {
                img.Image = Properties.Resources.Netzteil;
                mysqlcommandtext = "SELECT * FROM `netzteil`;";//SQL Abfrage Befehl
                tabel = "netzteil";
            }
            if (wtxtSuche.Text == "Gehäuse")
            {
                img.Image = Properties.Resources.Gehause;
                mysqlcommandtext = "SELECT * FROM `gehause`;";//SQL Abfrage Befehl
                tabel = "gehause";
            }
            if (wtxtSuche.Text == "Soundkarte")
            {
                img.Image = Properties.Resources.Soundkarte;
                mysqlcommandtext = "SELECT * FROM `soundkarte`;";//SQL Abfrage Befehl
                tabel = "soundkarte";
            }
            if (wtxtSuche.Text == "Netzwerkkarte")
            {
                img.Image = Properties.Resources.Netzwerkkarte;
                mysqlcommandtext = "SELECT * FROM `netzwerkkarte`;";//SQL Abfrage Befehl
                tabel = "netzwerkkarte";
            }
            if (wtxtSuche.Text == "Schnittstellenkarte")
            {
                img.Image = Properties.Resources.Schnittstellenkarte;
                mysqlcommandtext = "SELECT * FROM `schnittstellenkarte`;";//SQL Abfrage Befehl
                tabel = "schnittstellenkarte";
            }
            if (wtxtSuche.Text == "TVKarte")
            {
                img.Image = Properties.Resources.TVKarte;
                mysqlcommandtext = "SELECT * FROM `tv-karte`;";//SQL Abfrage Befehl
                tabel = "tv-karte";
            }
            if (wtxtSuche.Text == "Raiserkarte")
            {
                img.Image = Properties.Resources.Raiserkarte;
                mysqlcommandtext = "SELECT * FROM `raiserkarte`;";//SQL Abfrage Befehl
                tabel = "raiserkarte";
            }
            if (wtxtSuche.Text == "Laufwerk")
            {
                img.Image = Properties.Resources.DVDLaufwerk;
                mysqlcommandtext = "SELECT * FROM `laufwerke`;";//SQL Abfrage Befehl
                tabel = "laufwerke";
            }
            if (wtxtSuche.Text == "FrontErweiterung")
            {
                img.Image = Properties.Resources.FrontErweiterung;
                mysqlcommandtext = "SELECT * FROM `fronteinschub`;";//SQL Abfrage Befehl
                tabel = "fronteinschub";
            }
            if (wtxtSuche.Text == "Lüfter")
            {
                img.Image = Properties.Resources.Lufter;
                mysqlcommandtext = "SELECT * FROM `lufter`;";//SQL Abfrage Befehl
                tabel = "lufter";
            }
            if (wtxtSuche.Text == "Monitor")
            {
                img.Image = Properties.Resources.Monitor;
                mysqlcommandtext = "SELECT * FROM `monitor`;";//SQL Abfrage Befehl
                tabel = "monitor";
            }
            if (wtxtSuche.Text == "USV")
            {
                img.Image = Properties.Resources.USV;
                mysqlcommandtext = "SELECT * FROM `usv`;";//SQL Abfrage Befehl
                tabel = "usv";
            }
            if (wtxtSuche.Text == "Kabel")
            {
                img.Image = Properties.Resources.Kabel;
                mysqlcommandtext = "SELECT * FROM `kabel`;";//SQL Abfrage Befehl
                tabel = "kabel";
            }
            if (wtxtSuche.Text == "Adapter")
            {
                img.Image = Properties.Resources.Adapter;
                mysqlcommandtext = "SELECT * FROM `adapter`;";//SQL Abfrage Befehl
                tabel = "adapter";
            }
            if (wtxtSuche.Text == "I/O")
            {
                img.Image = Properties.Resources.I_O;
                mysqlcommandtext = "SELECT * FROM `i-o`;";//SQL Abfrage Befehl
                tabel = "i-o";
            }
            if (wtxtSuche.Text == "Sonstiges")
            {
                img.Image = Properties.Resources.Sonstiges;
                mysqlcommandtext = "SELECT * FROM `sonstiges`;";//SQL Abfrage Befehl
                tabel = "sonstiges";
            }

            dgvDaten.DataSource = methoden.MySqlDataToDatGrid(mysqlconnectionstring, mysqlcommandtext);//Daten in die DataGridViwe schreiben
        }

        private void cmdSuchen_Click(object sender, EventArgs e)//Button Erweiterte Suche
        {
            
        }

        private void cmdLoschen_Click(object sender, EventArgs e)//Button Löschen
        {
            string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
            methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
            string ID = methoden.DataGridViweSelectData(0, dgvDaten);//Datensatz ID ermitteln der mackirt worden ist

            if (dgvDaten.DataSource!=null && dgvDaten.SelectedRows.Count > 0 && dgvDaten.SelectedRows[0].Cells[0].Value != null)
            {
                string mysqlcommandtext = "DELETE FROM `" + tabel + "` WHERE `ID` =" + ID + ";";//SQL-Befel zum löschen
                methoden.MySqlCommand(mysqlconnectionstring, mysqlcommandtext);//Datensatz löschen
                wtxtSuche_SelectedIndexChanged(wtxtSuche, e);
                MessageBox.Show("Datensatz erfolgreich gelöscht!", "Hinweis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form_anpassen_an_Rechte()
        {
            string rechte = Speicher.rechte;

            if (rechte == "lesen")
            {
                cmdRoot.Hide();//keine root Rechte
                cmdInput.Hide();//keine schreiben Rechte
                cmdLoschen.Hide();//keine löschen Rechte
            }
            if (rechte == "lesen+löschen")
            {
                cmdRoot.Hide();//keine root Rechte
                cmdInput.Hide();//keine schreiben Rechte
            }
            if (rechte == "lesen+schreiben")
            {
                cmdRoot.Hide();//keine root Rechte
                cmdLoschen.Hide();//keine löschen Rechte
            }
            if (rechte == "lesen+löschen+schreiben")
            {
                cmdRoot.Hide();//keine root Rechte
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }

        private void cmdInput_Click(object sender, EventArgs e)
        {
            new Home_Imput().Show(this);
            this.Hide();
        }

        private void cmdRoot_Click(object sender, EventArgs e)
        {
            new Admin().Show(this);
            this.Hide();
        }

        #region Drucken von einem QR-Code
        private void cmdQR_Click(object sender, EventArgs e)
        {
            int i = 0;
            string ID = dgvDaten.SelectedCells[0].Value.ToString();//Ermitelt die ID der Hardware die ausgewählt wurde

            string mysqlconnectionstring = methoden.MySqlConnectionString();//Angaben um sich an der Datenbank anzumelden
            methoden.MySQL_ping_check(mysqlconnectionstring);//Testabfrage bei der Datenkan
            string mysqlcommandtext = "SELECT * FROM `" + tabel + "` WHERE `ID` = '" + ID + "';";//SQL Abfrage der Daten
            string[] Data = methoden.MySqlToArray(mysqlconnectionstring, mysqlcommandtext);//Erstellt ein Array mit allen Daten zur Hardware
            mysqlcommandtext = "SELECT column_name FROM information_schema.columns WHERE table_name = '" + tabel + "';";//SQL Abfrage der Überschriften
            string[] Header = methoden.MySqlToArray(mysqlconnectionstring, mysqlcommandtext);//Erstellt ein Array mit allen Überschriften zur Hardware

            foreach (string iHeader in Header)
            {
                QR += iHeader + ": " + Data[i] + LF;
                i++;
            }

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
