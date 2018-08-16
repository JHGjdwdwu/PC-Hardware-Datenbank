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
        private string Suche = null;

        public Home_Suche()
        {
            InitializeComponent();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Button Beenden
        {
            Application.Exit();
        }

        private void wtxtSuche_SelectedIndexChanged(object sender, EventArgs e)//wtxtSuchen ListTextBox Bild je nach wahl zuweisen
        {
            if (wtxtSuche.Text == "Mainboard")
            {
                img.Image = Properties.Resources.Mainboard;
                Suche = "Mainbord_Datenbank.csv";
            }
            if (wtxtSuche.Text == "CPU")
            {
                img.Image = Properties.Resources.CPU;
                Suche = "CPU_Datenbank.csv";
            }
            if (wtxtSuche.Text == "RAM")
            {
                img.Image = Properties.Resources.RAM;
                Suche = "RAM_Datenbank.csv";
            }
            if (wtxtSuche.Text == "GPU")
            {
                img.Image = Properties.Resources.GPU;
                Suche = "GPU_Datenbank.csv";
            }
            if (wtxtSuche.Text == "HDD")
            {
                img.Image = Properties.Resources.HDD;
                Suche = "HDD_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Netzteil")
            {
                img.Image = Properties.Resources.Netzteil;
                Suche = "Netzteil_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Gehäuse")
            {
                img.Image = Properties.Resources.Gehause;
                Suche = "Gehause_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Soundkarte")
            {
                img.Image = Properties.Resources.Soundkarte;
                Suche = "Soundkarte_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Netzwerkkarte")
            {
                img.Image = Properties.Resources.Netzwerkkarte;
                Suche = "Netzwerkkarte_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Schnittstellenkarte")
            {
                img.Image = Properties.Resources.Schnittstellenkarte;
                Suche = "Schnittstellenkarte_Datenbank.csv";
            }
            if (wtxtSuche.Text == "TVKarte")
            {
                img.Image = Properties.Resources.TVKarte;
                Suche = "TVKarte_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Raiserkarte")
            {
                img.Image = Properties.Resources.Raiserkarte;
                Suche = "Raiserkarte_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Laufwerk")
            {
                img.Image = Properties.Resources.DVDLaufwerk;
                Suche = "Laufwerke_Datenbank.csv";
            }
            if (wtxtSuche.Text == "FrontErweiterung")
            {
                img.Image = Properties.Resources.FrontErweiterung;
                Suche = "FrontErweiterung_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Lüfter")
            {
                img.Image = Properties.Resources.Lufter;
                Suche = "Lufter_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Monitor")
            {
                img.Image = Properties.Resources.Monitor;
                Suche = "Monitor_Datenbank.csv";
            }
            if (wtxtSuche.Text == "USV")
            {
                img.Image = Properties.Resources.USV;
                Suche = "USV_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Kabel")
            {
                img.Image = Properties.Resources.Kabel;
                Suche = "Kabel_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Adapter")
            {
                img.Image = Properties.Resources.Adapter;
                Suche = "Adapter_Datenbank.csv";
            }
            if (wtxtSuche.Text == "I/O")
            {
                img.Image = Properties.Resources.I_O;
                Suche = "I_O_Datenbank.csv";
            }
            if (wtxtSuche.Text == "Sonstiges")
            {
                img.Image = Properties.Resources.Sonstiges;
                Suche = "Sonstiges_Datenbank.csv";
            }
            if (wtxtSuche.Text == "")
            {
                img.Image = Properties.Resources.Download;
                Suche = "";
            }
        }

        private void cmdSuchen_Click(object sender, EventArgs e)//Button Suchen
        {
            string DateiPfad = File.ReadAllText(@"./settings");
            string Pfad = DateiPfad + "\\" + Suche;//C: \Users\User\Desktop\Mainbord_Datenbank.csv
            lblTest.Text = Pfad;
        }
    }
}
