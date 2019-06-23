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
    public partial class DB_Setings : Form
    {
        public DB_Setings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JHGjdwdwu");
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Crypto_AES crypto = new Crypto_AES();//Methode zu Verschlusselung von Daten
            string CryptoUser = crypto.encrypt(txtUser.Text);//User verschlüsseln
            string CryptoKey = crypto.encrypt(txtKey.Text);//Password verschlüsseln

            File.WriteAllText(@"./settings.ini", wtxtDB_Typ.Text + ";" + txtDB_IP.Text + ";" + txtDB.Text + ";" + CryptoUser + ";" + CryptoKey);//Datei schreiben mir den Daten zum aufbau einer Verbindung zur Datenbank
            MessageBox.Show("Daten wurden erfolgreich gespeichert", "Daten gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DB_Setings_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"./settings.ini"))
            {
                string[] ConnectionData = File.ReadAllText(@"./settings.ini").Split(';');//Array erzeugen mit den Daten zum aufbau einer Verbindung mit einer Datenbank
                Crypto_AES crypto = new Crypto_AES();//Methode zu Verschlusselung von Daten

                wtxtDB_Typ.Text = ConnectionData[0];
                txtDB_IP.Text = ConnectionData[1];
                txtDB.Text = ConnectionData[2];
                txtUser.Text = crypto.decrypt(ConnectionData[3]);
                txtKey.Text = crypto.decrypt(ConnectionData[4]);
            }
        }
    }
}
