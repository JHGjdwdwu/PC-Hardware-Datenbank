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

        private void button1_Click(object sender, EventArgs e)//Button Benutzer erstellen / löschen
        {
            Benutzer User = new Benutzer();
            User.Show();
        }

        private void cmdBetrachten_Click(object sender, EventArgs e)//Daten suchen
        {
            new Home_Suche().Show(this);
            this.Hide();
        }

        private void cmdPfad_Click(object sender, EventArgs e)//Datenbank einstellungen
        {

        }
    }
}
