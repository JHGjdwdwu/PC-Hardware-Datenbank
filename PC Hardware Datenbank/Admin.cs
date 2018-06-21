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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            #region Prüfen ob es die Datenbank schon giebt
            if (File.Exists(@"./Mainbord_Datenbank.csv") == true)
            {
                faMainbord.BackColor = Color.Green;
            }
            if (File.Exists(@"./CPU_Datenbank.csv") == true)
            {
                faCPU.BackColor = Color.Green;
            }
            if (File.Exists(@"./RAM_Datenbank.csv") == true)
            {
                faRAM.BackColor = Color.Green;
            }
            if (File.Exists(@"./GPU_Datenbank.csv") == true)
            {
                faGPU.BackColor = Color.Green;
            }
            if (File.Exists(@"./HDD_Datenbank.csv") == true)
            {
                faHDD.BackColor = Color.Green;
            }
            if (File.Exists(@"./Netzteil_Datenbank.csv") == true)
            {
                faNetzteil.BackColor = Color.Green;
            }
            if (File.Exists(@"./Gehause_Datenbank.csv") == true)
            {
                faGehause.BackColor = Color.Green;
            }
            if (File.Exists(@"./Soundkarte_Datenbank.csv") == true)
            {
                faSoundkarte.BackColor = Color.Green;
            }
            if (File.Exists(@"./Netzwerkkarte_Datenbank.csv") == true)
            {
                faNetzwerkkarte.BackColor = Color.Green;
            }
            if (File.Exists(@"./Schnittstellenkarte_Datenbank.csv") == true)
            {
                faSchnittstellenkarte.BackColor = Color.Green;
            }
            if (File.Exists(@"./TVKarte_Datenbank.csv") == true)
            {
                faTVKarte.BackColor = Color.Green;
            }
            if (File.Exists(@"./Raiserkarte_Datenbank.csv") == true)
            {
                faRaiserkarte.BackColor = Color.Green;
            }
            if (File.Exists(@"./Laufwerke_Datenbank.csv") == true)
            {
                faLaufwerk.BackColor = Color.Green;
            }
            if (File.Exists(@"./FrontErweiterung_Datenbank.csv") == true)
            {
                faFrontErweiterung.BackColor = Color.Green;
            }
            if (File.Exists(@"./Lufter_Datenbank.csv") == true)
            {
                faLufter.BackColor = Color.Green;
            }
            if (File.Exists(@"./Monitor_Datenbank.csv") == true)
            {
                faMonitor.BackColor = Color.Green;
            }
            if (File.Exists(@"./USV_Datenbank.csv") == true)
            {
                faUSV.BackColor = Color.Green;
            }


            #endregion
        }

        private void cmdBeenden_Click(object sender, EventArgs e)//Programm Beenden
        {
            Application.Exit();
        }

        private void cmdEingabe_Click(object sender, EventArgs e)//HomeImput
        {
            new Home_Imput().Show(this);
            this.Hide();
        }

        private void cmdLogout_Click(object sender, EventArgs e)//Logut
        {
            new Login().Show(this);
            this.Hide();
        }

        #region Datenbank erstellen
        private void cmdMainbord_Click(object sender, EventArgs e)//Mainbord_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Mainbord_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Mainbord_Datenbank.csv", "Hersteller;Typ;Sockel;RAM;Bauform;Sonstiges;AGP;PCI;PCIe x1;PCIe x4;PCIe x8;PCIe x16;PCIe x64;IDE;SATA;ISA;PS2;USB2;USB3;RJ45;Klinke;VGA;DVI;HDMI;DisplayPort;MidiPort;FireWire;Thunderbolt;RS232;Bluetooth;WLan;LPT1;eSATA;Infrarot");
                faMainbord.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdCPU_Click(object sender, EventArgs e)//CPU_Datenbank.csv erstellen
        {
            if (File.Exists(@"./CPU_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./CPU_Datenbank.csv", "Hersteller;Typ;Sockel;Taktrate;Anzahl-Kerne;Level1-Cache;Level2-Cache;Level3-Cache;Level4-Cache");
                faCPU.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdRAM_Click(object sender, EventArgs e)//RAM_Datenbank.csv erstellen
        {
            if (File.Exists(@"./RAM_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./RAM_Datenbank.csv", "Slot;Größe;Hersteller;Typ;Taktrate;Latenz;SO-DIMM;ECC;Registered;Unbuffered");
                faRAM.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdGPU_Click(object sender, EventArgs e)//GPU_Datenbank.csv erstellen
        {
            if (File.Exists(@"./GPU_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./GPU_Datenbank.csv", "Kartenhersteller;Modell;Speichergröße;Speichertyp;Kühlertyp;Stromversorgung;Anschlussart;Stromverbrauch;Taktrate;Multi-Grafikkarten-Betrieb;VGA;DVI;HDMI;Displaport;S-Video;Cinch");
                faGPU.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdHDDClick(object sender, EventArgs e)//HDD_Datenbank.csv erstellen
        {
            if (File.Exists(@"./HDD_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./HDD_Datenbank.csv", "Hersteller;Typ;Speichergröße;Anschlüsse;Stromverbrauch;Stromversorgung;Baugröße;SSD;SSHD");
                faHDD.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdNetzteil_Click(object sender, EventArgs e)//Netzteil_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Netzteil_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Netzteil_Datenbank.csv", "Hersteller;Typ;Anzahl-Lüfter;Breite-Tiefe-Höhe;Leistung;max-Ampere-12V;max-Ampere-5V;Stromausgang;Netzschalter;110V-Schalter;110V-Betrieb-möglich;Molex-8981;SATA;AT;ATX;BTX;ATX-large;CFX;SFX;TFX;LFX;2x2-12V;2x3-12V;2x4-12V;BERG");
                faNetzteil.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdGehause_Click(object sender, EventArgs e)//Gehause_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Gehause_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Gehause_Datenbank.csv", "Breite-Höhe-Tiefe;Hersteller;Typ;Netzteil-Position;Einschub-5,25-Zoll;Einschub-3,5-Zoll;Einschub-3,5-HDD;Einschub-2,5-HDD;Front-USB;Front-Klinke;Formfaktor;Kabelsystem;Beleuchtung;Plexiglas-Fenster");
                faGehause.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdSoundkarte_Click(object sender, EventArgs e)//Soundkarte_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Soundkarte_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Soundkarte_Datenbank.csv", "Ausgabestandard;Anschlussschnittstelle;Bit-Aufloesung;Hersteller;ADAT;AES/EBU;Chinchbuchse;Klinkenbuchse;MADI;S/PDIF;TDIF;Breakout Box;DSP;Gameport;MIDI;Mikrofoneingang;Wavetable");
                faSoundkarte.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdNetzwerkkarte_Click(object sender, EventArgs e)//Netzwerkkarte_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Netzwerkkarte_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Netzwerkkarte_Datenbank.csv", "Hersteller;Schnittstelle;Geschwindigkeit;Typ;RJ-45;Coax;LWL;WLAN");
                faNetzwerkkarte.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdSchnittstellenkarte_Click(object sender, EventArgs e)//Schnittstellenkarte_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Schnittstellenkarte_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Schnittstellenkarte_Datenbank.csv", "Hersteller;Modell;Anschlussart;Bemerkungen");
                faSchnittstellenkarte.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdTVKarte_Click(object sender, EventArgs e)//TVKarte_Datenbank.csv erstellen
        {
            if (File.Exists(@"./TVKarte_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./TVKarte_Datenbank.csv", "Hersteller;Modell;Anschlussart;Analog;DVB-C;DVB-T;DVB-S;Klinge;ODT;HDMI;Scart;S-Video;Cinch");
                faTVKarte.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdRaiserkarte_Click(object sender, EventArgs e)//Raiserkarte_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Raiserkarte_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Raiserkarte_Datenbank.csv", "Steckverbindung;Steckverbindung Anzahl;Schnittstelle;Anzahl;Ausrichtung");
                faRaiserkarte.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdDVDLaufwerk_Click(object sender, EventArgs e)//Laufwerke_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Laufwerke_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Laufwerke_Datenbank.csv", "Hersteller;Schnittstelle;Typ;Bauart;Brenner");
                faLaufwerk.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdFrontErweiterung_Click(object sender, EventArgs e)//FrontErweiterung_Datenbank.csv erstellen
        {
            if (File.Exists(@"./FrontErweiterung_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./FrontErweiterung_Datenbank.csv", "Hersteller;Modell;Cardreader;USB2.0-extern;USB3.0-extern;USB3.1-extern;Audio-extern;FireWire-extern;Thunderbolt-extern;USB2.0;USB3.0;USB3.1;Audio;Firewire;Thunderbolt");
                faFrontErweiterung.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdLufter_Click(object sender, EventArgs e)//Lufter_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Lufter_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Lufter_Datenbank.csv", "Hersteller;Modell;Maximaldrehzahl;Pinheader;Durchmesser;Dicke;Art;Spannung;Strom");
                faLufter.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdMonitor_Click(object sender, EventArgs e)//Monitor_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Monitor_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Monitor_Datenbank.csv", "Hersteller;Modell;Technik;Max Aufloesung;Lautsprecher; Hoehenverstellbar;VESA Halterung;VGA;DVI;HDMI;Displayport;RGB;Audio;USB;Audio-Ausgang;USB-Ausgang");
                faMonitor.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdUSV_Click(object sender, EventArgs e)//USV_Datenbank.csv erstellen
        {
            if (File.Exists(@"./USV_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./USV_Datenbank.csv", "Hersteller;Modell;Watt;Volt-Ampere;Arbeitsweise;Akkutyp;Akkuanzahl;USB-Anschluesse;COM");
                faUSV.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdKabel_Click(object sender, EventArgs e)//Kabel_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Kabel_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Kabel_Datenbank.csv", "Kabelende;Länge;Kabelende;Schaltbar");
                faKabel.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdAdapter_Click(object sender, EventArgs e)//Adapter_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Adapter_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Adapter_Datenbank.csv", "Von;Auf");
                faAdapter.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdI_O_Click(object sender, EventArgs e)//I_O_Datenbank.csv erstellen
        {
            if (File.Exists(@"./I_O_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./I_O_Datenbank.csv", "Hersteller;Gerät;Anschluss;Bemerkung");
                faI_O.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }

        private void cmdSonstiges_Click(object sender, EventArgs e)//Sonstiges_Datenbank.csv erstellen
        {
            if (File.Exists(@"./Sonstiges_Datenbank.csv") == false)
            {
                File.WriteAllText(@"./Sonstiges_Datenbank.csv", "Hersteller;Was ist das?;Anschluss;Bemerkung");
                faSonstiges.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Die Datenbank gibt es schon!");
            }
        }
            #endregion


            #region Datenbanck Löschen
            private void cmdMainbordLoschen_Click(object sender, EventArgs e)//Lösche Mainbord_Datenbank.csv
        {
            File.Delete(@"./Mainbord_Datenbank.csv");
            faMainbord.BackColor = Color.Red;
        }

        private void cmdCPUloschen_Click(object sender, EventArgs e)//Lösche CPU_Datenbank.csv
        {
            File.Delete(@"./CPU_Datenbank.csv");
            faCPU.BackColor = Color.Red;
        }

        private void cmdRAMloschen_Click(object sender, EventArgs e)//Lösche RAM_Datenbank.csv
        {
            File.Delete(@"./RAM_Datenbank.csv");
            faRAM.BackColor = Color.Red;
        }

        private void cmdGPUloschen_Click(object sender, EventArgs e)//Lösche GPU_Datenbank.csv
        {
            File.Delete(@"./GPU_Datenbank.csv");
            faGPU.BackColor = Color.Red;
        }

        private void HDDloschen_Click(object sender, EventArgs e)//Lösche HDD_Datenbank.csv
        {
            File.Delete(@"./HDD_Datenbank.csv");
            faHDD.BackColor = Color.Red;
        }

        private void cmdNetzteilLoschen_Click(object sender, EventArgs e)//Lösche Netzteil_Datenbank.csv
        {
            File.Delete(@"./Netzteil_Datenbank.csv");
            faNetzteil.BackColor = Color.Red;
        }

        private void cmdGehauseLoschen_Click(object sender, EventArgs e)//Lösche Gehause_Datenbank.csv
        {
            File.Delete(@"./Gehause_Datenbank.csv");
            faGehause.BackColor = Color.Red;
        }

        private void cmdSoundkarteLoschen_Click(object sender, EventArgs e)//Lösche Soundkarte_Datenbank.csv
        {
            File.Delete(@"./Soundkarte_Datenbank.csv");
            faSoundkarte.BackColor = Color.Red;
        }

        private void cmdNetzwerkkarteLoschen_Click(object sender, EventArgs e)//Lösche Netzwerkkarte_Datenbank.csv
        {
            File.Delete(@"./Netzwerkkarte_Datenbank.csv");
            faNetzwerkkarte.BackColor = Color.Red;
        }

        private void cmdSchnittstellenkarteLoschen_Click(object sender, EventArgs e)//Lösche chnittstellenkarte_Datenbank.csv
        {
            File.Delete(@"./Schnittstellenkarte_Datenbank.csv");
            faSchnittstellenkarte.BackColor = Color.Red;
        }

        private void cmdTVKarteLoschen_Click(object sender, EventArgs e)//Lösche TVKarte_Datenbank.csv
        {
            File.Delete(@"./TVKarte_Datenbank.csv");
            faTVKarte.BackColor = Color.Red;
        }

        private void cmdRaiserkarteLoschen_Click(object sender, EventArgs e)//Lösche Raiserkarte_Datenbank.csv
        {
            File.Delete(@"./Raiserkarte_Datenbank.csv");
            faRaiserkarte.BackColor = Color.Red;
        }

        private void cmdDVDLaufwerkLoschen_Click(object sender, EventArgs e)//Lösche Laufwerke_Datenbank.csv
        {
            File.Delete(@"./Laufwerke_Datenbank.csv");
            faLaufwerk.BackColor = Color.Red;
        }

        private void cmdFrontErweiterungLoschen_Click(object sender, EventArgs e)//Lösche FrontErweiterung_Datenbank.csv
        {
            File.Delete(@"./FrontErweiterung_Datenbank.csv");
            faFrontErweiterung.BackColor = Color.Red;
        }

        private void cmdLufterLoschen_Click(object sender, EventArgs e)//Lösche Lufter_Datenbank.csv
        {
            File.Delete(@"./Lufter_Datenbank.csv");
            faLufter.BackColor = Color.Red;
        }

        private void cmdMonitorLoschen_Click(object sender, EventArgs e)//Lösche Monitor_Datenbank.csv
        {
            File.Delete(@"./Monitor_Datenbank.csv");
            faMonitor.BackColor = Color.Red;
        }

        private void cmdUSVloschen_Click(object sender, EventArgs e)//Lösche USV_Datenbank.csv
        {
            File.Delete(@"./USV_Datenbank.csv");
            faUSV.BackColor = Color.Red;
        }

        private void cmdKabelLoschen_Click(object sender, EventArgs e)//Lösche Kabel_Datenbank.csv
        {
            File.Delete(@"./Kabel_Datenbank.csv");
            faKabel.BackColor = Color.Red;
        }

        private void cmdAdapterLoschen_Click(object sender, EventArgs e)//Lösche Adapter_Datenbank.csv
        {
            File.Delete(@"./Adapter_Datenbank.csv");
            faAdapter.BackColor = Color.Red;
        }

        private void cmdI_Oloschen_Click(object sender, EventArgs e)//Lösche I_O_Datenbank.csv
        {
            File.Delete(@"./I_O_Datenbank.csv");
            faI_O.BackColor = Color.Red;
        }

        private void cmdSonstigesLoschen_Click(object sender, EventArgs e)//Lösche Sonstiges_Datenbank.csv
        {
            File.Delete(@"./Sonstiges_Datenbank.csv");
            faSonstiges.BackColor = Color.Red;
        }
        #endregion
    }
}
