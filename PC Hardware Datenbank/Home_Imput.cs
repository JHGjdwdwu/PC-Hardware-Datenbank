using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Hardware_Datenbank
{
    public partial class Home_Imput : Form
    {
        public Home_Imput()
        {
            InitializeComponent();
            Form_anpassen_an_Rechte();
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Beenden
        {
            Application.Exit();
        }

        private void cmdMainbord_Click(object sender, EventArgs e)//Form Mainbord öffnen
        {
            Mainboard_Imput mainbord = new Mainboard_Imput();
            mainbord.Show();
        }

        private void cmdCPU_Click(object sender, EventArgs e)//Form CPU öffnen
        {
            CPU_Imput cpu = new CPU_Imput();
            cpu.Show();
        }

        private void cmdRAM_Click(object sender, EventArgs e)//Form RAM öffnen
        {
            RAM_Imput ram = new RAM_Imput();
            ram.Show();
        }

        private void cmdGPU_Click(object sender, EventArgs e)//Form GPU öffnen
        {
            GPU_Imput gpu = new GPU_Imput();
            gpu.Show();
        }

        private void cmdHDD_Click(object sender, EventArgs e)//Form HDD öffnen
        {
            HDD_Imput hdd = new HDD_Imput();
            hdd.Show();
        }

        private void cmdNetzteil_Click(object sender, EventArgs e)//Form Netzteil öffnen
        {
            Netzteil_Imput netzteil = new Netzteil_Imput();
            netzteil.Show();
        }

        private void cmdGehause_Click(object sender, EventArgs e)//Form Gehäuse öffnen
        {
            Gehause_Imput gehause = new Gehause_Imput();
            gehause.Show();
        }

        private void cmdSoundkarte_Click(object sender, EventArgs e)//Form Soundkarte öffnen
        {
            Soundkarte_Imput soundkarte = new Soundkarte_Imput();
            soundkarte.Show();
        }

        private void cmdNetzwerkkarte_Click(object sender, EventArgs e)//Form Netzwerkkarte öffnen
        {
            Netzwerkkarte_Imput netzwerkkarte = new Netzwerkkarte_Imput();
            netzwerkkarte.Show();
        }

        private void cmdSchnittstellenkarte_Click(object sender, EventArgs e)//Form Schnittstellenkarte öffnen
        {
            Schnittstellenkarte_Imput schnittstellenkarte = new Schnittstellenkarte_Imput();
            schnittstellenkarte.Show();
        }

        private void cmdTVKarte_Click(object sender, EventArgs e)//Form TVKarte öffnen
        {
            TVKarte_Imput tvkarte = new TVKarte_Imput();
            tvkarte.Show();
        }

        private void cmdRaiserkarte_Click(object sender, EventArgs e)//Form Raiserkarte öffnen
        {
            Raiserkarte_Imput raiserkarte = new Raiserkarte_Imput();
            raiserkarte.Show();
        }

        private void cmdLaufwerk_Click(object sender, EventArgs e)//Form Laufwerk öffnen
        {
            Laufwerk_Imput laufwerk = new Laufwerk_Imput();
            laufwerk.Show();
        }

        private void cmdFrontErweiterung_Click(object sender, EventArgs e)//Form FrontErweiterung öffnen
        {
            FrontErweiterung_Imput fronterweiterung = new FrontErweiterung_Imput();
            fronterweiterung.Show();
        }

        private void cmdLufter_Click(object sender, EventArgs e)//Form Lüfter öffnen
        {
            Lufter_Imput lufter = new Lufter_Imput();
            lufter.Show();
        }

        private void cmdMonitor_Click(object sender, EventArgs e)//Form Monitor öffnen
        {
            Monitor_Imput monitor = new Monitor_Imput();
            monitor.Show();
        }

        private void cmdUSV_Click(object sender, EventArgs e)//Form USV öffnen
        {
            USV_Imput usv = new USV_Imput();
            usv.Show();
        }

        private void cmdKabel_Click(object sender, EventArgs e)//Form Kabel öffnen
        {
            Kabel_Imput kabel = new Kabel_Imput();
            kabel.Show();
        }

        private void cmdAdapter_Click(object sender, EventArgs e)//Form Adapter öffnen
        {
            Adapter_Imput adapter = new Adapter_Imput();
            adapter.Show();
        }

        private void cmdI_O_Click(object sender, EventArgs e)//Form I_O öffnen
        {
            I_O_Imput io = new I_O_Imput();
            io.Show();
        }

        private void cmdSonstiges_Click(object sender, EventArgs e)//Form Sonstiges öffnen
        {
            Sonstiges_Imput sonstiges = new Sonstiges_Imput();
            sonstiges.Show();
        }

        private void cmdAdministration_Click(object sender, EventArgs e)
        {
            new Admin().Show(this);
            this.Hide();
        }

        private void Form_anpassen_an_Rechte()
        {
            string rechte = Speicher.rechte;

            if (rechte== "schreiben")
            {
                cmdRoot.Hide();//keine root Rechte
                cmdSuchen.Hide();//keine lesen Rechte
            }
            if (rechte == "lesen+schreiben")
            {
                cmdRoot.Hide();//keine root Rechte
            }
            if (rechte == "lesen+löschen+schreiben")
            {
                cmdRoot.Hide();//keine root Rechte
            }
        }

        private void cmdSuchen_Eingeben_Click(object sender, EventArgs e)
        {
            new Home_Suche().Show(this);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }
    }
}
