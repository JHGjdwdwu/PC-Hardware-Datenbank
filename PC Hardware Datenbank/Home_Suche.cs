using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PC_Hardware_Datenbank
{
    public partial class Home_Suche : Form
    {
        public Home_Suche()
        {
            InitializeComponent();
        }

        Methoden methoden = new Methoden();

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
            }
            if (wtxtSuche.Text == "CPU")
            {
                img.Image = Properties.Resources.CPU;
                mysqlcommandtext = "SELECT * FROM `cpu`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "RAM")
            {
                img.Image = Properties.Resources.RAM;
                mysqlcommandtext = "SELECT * FROM `ram`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "GPU")
            {
                img.Image = Properties.Resources.GPU;
                mysqlcommandtext = "SELECT * FROM `gpu`;";//SQL Abfrage Befehl;
            }
            if (wtxtSuche.Text == "HDD")
            {
                img.Image = Properties.Resources.HDD;
                mysqlcommandtext = "SELECT * FROM `hdd`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Netzteil")
            {
                img.Image = Properties.Resources.Netzteil;
                mysqlcommandtext = "SELECT * FROM `netzteil`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Gehäuse")
            {
                img.Image = Properties.Resources.Gehause;
                mysqlcommandtext = "SELECT * FROM `gehause`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Soundkarte")
            {
                img.Image = Properties.Resources.Soundkarte;
                mysqlcommandtext = "SELECT * FROM `soundkarte`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Netzwerkkarte")
            {
                img.Image = Properties.Resources.Netzwerkkarte;
                mysqlcommandtext = "SELECT * FROM `netzwerkkarte`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Schnittstellenkarte")
            {
                img.Image = Properties.Resources.Schnittstellenkarte;
                mysqlcommandtext = "SELECT * FROM `schnittstellenkarte`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "TVKarte")
            {
                img.Image = Properties.Resources.TVKarte;
                mysqlcommandtext = "SELECT * FROM `tv-karte`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Raiserkarte")
            {
                img.Image = Properties.Resources.Raiserkarte;
                mysqlcommandtext = "SELECT * FROM `raiserkarte`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Laufwerk")
            {
                img.Image = Properties.Resources.DVDLaufwerk;
                mysqlcommandtext = "SELECT * FROM `laufwerke`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "FrontErweiterung")
            {
                img.Image = Properties.Resources.FrontErweiterung;
                mysqlcommandtext = "SELECT * FROM `fronteinschub`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Lüfter")
            {
                img.Image = Properties.Resources.Lufter;
                mysqlcommandtext = "SELECT * FROM `lufter`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Monitor")
            {
                img.Image = Properties.Resources.Monitor;
                mysqlcommandtext = "SELECT * FROM `monitor`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "USV")
            {
                img.Image = Properties.Resources.USV;
                mysqlcommandtext = "SELECT * FROM `usv`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Kabel")
            {
                img.Image = Properties.Resources.Kabel;
                mysqlcommandtext = "SELECT * FROM `kabel`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Adapter")
            {
                img.Image = Properties.Resources.Adapter;
                mysqlcommandtext = "SELECT * FROM `adapter`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "I/O")
            {
                img.Image = Properties.Resources.I_O;
                mysqlcommandtext = "SELECT * FROM `i-o`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "Sonstiges")
            {
                img.Image = Properties.Resources.Sonstiges;
                mysqlcommandtext = "SELECT * FROM `sonstiges`;";//SQL Abfrage Befehl
            }
            if (wtxtSuche.Text == "alles")
            {
                img.Image = Properties.Resources.Download;
                mysqlcommandtext = "SELECT * FROM `mainboard`;";//SQL Abfrage Befehl
                mysqlcommandtext += "SELECT * FROM `cpu`;";//SQL Abfrage Befehl
            }

            dgvDaten.DataSource = methoden.MySqlDataToDatGrid(mysqlconnectionstring, mysqlcommandtext);//Daten in die DataGridViwe schreiben
        }

        private void cmdSuchen_Click(object sender, EventArgs e)//Button Suchen
        {
            
        }

        private void cmdLoschen_Click(object sender, EventArgs e)
        {

        }
    }
}
