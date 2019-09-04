using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace PC_Hardware_Datenbank
{
    class Methoden
    {
        public string MySqlConnectionString()//Methode: MySQL Verbindungs Daten
        {
            string[] ConnectionData = null;
            string user = null, key = null;

            if (File.Exists(@"./settings.ini"))
            {
                ConnectionData = File.ReadAllText(@"./settings.ini").Split(';');
                Crypto_AES crypto = new Crypto_AES();//Methode zu Verschlusselung von Daten
                user = crypto.decrypt(ConnectionData[3]);//der entschlüsselte User
                key = crypto.decrypt(ConnectionData[4]);//das entschlüsselte Password
            }
            else
            {
                MessageBox.Show("Es wurde noch keine Datenbank angeben. Bitte geben Sie eine Datenbank an!", "Datenkank angeben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

            if (ConnectionData[0]=="MySQL" || ConnectionData[0] == "MariaDB")
            {
                string myConnectionString = "SERVER=" + ConnectionData[1] + ";DATABASE=" + ConnectionData[2] + ";UID=" + user + ";PASSWORD=" + key + ";Charset=utf8";
                return myConnectionString;
            }
            return null;
        }


        public string MySQL_ping_check(string MySqlConnectionString)//Methode: Prüfen ob DB erreicht werden kann.
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand command = connection.CreateCommand();
            string sqlping = command.CommandText = "SELECT * FROM `sonstiges` WHERE `Hersteller`='abc';";
            try
            {
                connection.Open();
                connection.Close();
                return sqlping;
            }
            catch
            {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank aufgebaut werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public string MySqlCommand(string MySqlConnectionString, string MySqlCommandText)//Methode: MySQL-Befehl
        {
            //Error wen Null!!! Kann nicht gelöscht werden Fehler Code: MySql.Data.MySqlClient.MySqlException
            try
            {
                MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = MySqlCommandText;
                connection.Open();//Behfel schreiben
                command.ExecuteReader();//Behfel ausfüren
                connection.Close();
                return null;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                DialogResult dialogresult = MessageBox.Show("Ein unbekanter Fehler! Das Programm wird beendet.","Fehler",MessageBoxButtons.OK);
                if (dialogresult == DialogResult.OK)
                {
                    Application.Exit();
                }
                return null;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Fahlscher SQL-Behfel");
                return null;
            }
        }


        public DataTable MySqlDataToDatGrid(string MySqlConnectionString, string MySqlCommandText)//Metod: MySQL-Daten in DataGridViwe schreiben
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = MySqlCommandText;

                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
                DataTable TableData = new DataTable();
                sqlDataAdap.Fill(TableData);
                connection.Close();
                return TableData;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Es konnte keine verbindung zum SQL-Server aufgebaut werden");
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Es wurde nichts ausgewählt!");
            }
            return null;
        }


        public string[] MySqlToArray(string MySqlConnectionString, string MySqlCommand)
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnectionString);//Variabe zum verbinden mit MySQL
            MySqlCommand command = new MySqlCommand(MySqlCommand, connection);//Variable zum ausfüren von MySQL Behfelen

            try
            {
                connection.Open();//verbindung aufbauen zu MySQL
                MySqlDataReader reader = command.ExecuteReader();//die Ergebnise des Abrage
                string data = null;
                while (reader.Read())//Zeile für Zeile die Ergebnise aus der SQL Abfrage abarbeiten
                {
                    for (int i = 0; i < reader.FieldCount; i++)//so offt wiederholen wie es daten giebt
                    {
                        data += reader.GetValue(i).ToString() + ";";//erzeugt ein String mit allen Daten
                    }
                }
                connection.Clone();//MySQL verbindung schließen
                if (data!=null)
                {
                    string[] dataarray = data.Split(';');//macht aus dem String ein Array
                    Array.Resize(ref dataarray, dataarray.Length - 1);//entfernt den letzte überflüssige Eintrag im Array
                    return dataarray;
                }
                string[] noll = new string[] { null };
                return noll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        /* Objekte die auf einer Form sind werden Addirt
         * Man kann ein Trenzeichen angeben
         * Man muss die Form angeben auf der die Objekte sich befinden
         * Es werden keine Button und Label bearbeitet
         */
        public string ObjekteTextToString(string splitICO, Form form)
        {
            string data = null;
            var controls = form.Controls;
            foreach (var control in controls.OfType<Control>().OrderBy(x => x.TabIndex))
            {
                if (control is TextBox)
                {
                    TextBox txt = control as TextBox;
                    if (txt.TabStop == true)
                    {
                        data += "'" + txt.Text + "'" + splitICO;
                    }
                }
                if (control is MaskedTextBox)
                {
                    MaskedTextBox mtxt = control as MaskedTextBox;
                    if (mtxt.TabStop == true)
                    {
                        data += "'" + mtxt.Text + "'" + splitICO;
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox cbt = control as ComboBox;
                    if (cbt.TabStop == true)
                    {
                        data += "'" + cbt.Text + "'" + splitICO;
                    }
                }
                if (control is NumericUpDown)
                {
                    NumericUpDown nud = control as NumericUpDown;
                    if (nud.TabStop == true)
                    {
                        data += "'" + nud.Value + "'" + splitICO;
                    }
                }
                if (control is CheckBox)
                {
                    CheckBox cbt = control as CheckBox;
                    if (cbt.TabStop == true)
                    {
                        if (cbt.Checked == true)
                        {
                            data += "'" + "Ja" + "'" + splitICO;
                        }
                        else
                        {
                            data += "'" + "Nein" + "'" + splitICO;
                        }
                    }
                }

                if (control is FlowLayoutPanel)
                {
                    foreach (var con in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))//Control con in control.Controls
                    {
                        if (con is TextBox)
                        {
                            TextBox txt = con as TextBox;
                            if (txt.TabStop == true)
                            {
                                data += "'" + txt.Text + "'" + splitICO;
                            }
                        }
                        if (con is MaskedTextBox)
                        {
                            MaskedTextBox mtxt = con as MaskedTextBox;
                            if (mtxt.TabStop == true)
                            {
                                data += "'" + mtxt.Text + "'" + splitICO;
                            }
                        }
                        if (con is ComboBox)
                        {
                            ComboBox cbt = con as ComboBox;
                            if (cbt.TabStop == true)
                            {
                                data += "'" + cbt.Text + "'" + splitICO;
                            }
                        }
                        if (con is NumericUpDown)
                        {
                            NumericUpDown nud = con as NumericUpDown;
                            if (nud.TabStop == true)
                            {
                                data += "'" + nud.Value + "'" + splitICO;
                            }
                        }
                        if (con is CheckBox)
                        {
                            CheckBox cbt = con as CheckBox;
                            if (cbt.TabStop == true)
                            {
                                if (cbt.Checked == true)
                                {
                                    data += "'" + "Ja" + "'" + splitICO;
                                }
                                else
                                {
                                    data += "'" + "Nein" + "'" + splitICO;
                                }
                            }
                        }
                    }
                }
                if (control is GroupBox)
                {
                    foreach (var con in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))//Control con in control.Controls
                    {
                        if (con is TextBox)
                        {
                            TextBox txt = con as TextBox;
                            if (txt.TabStop == true)
                            {
                                data += "'" + txt.Text + "'" + splitICO;
                            }
                        }
                        if (con is MaskedTextBox)
                        {
                            MaskedTextBox mtxt = con as MaskedTextBox;
                            if (mtxt.TabStop == true)
                            {
                                data += "'" + mtxt.Text + "'" + splitICO;
                            }
                        }
                        if (con is ComboBox)
                        {
                            ComboBox cbt = con as ComboBox;
                            if (cbt.TabStop == true)
                            {
                                data += "'" + cbt.Text + "'" + splitICO;
                            }
                        }
                        if (con is NumericUpDown)
                        {
                            NumericUpDown nud = con as NumericUpDown;
                            if (nud.TabStop == true)
                            {
                                data += "'" + nud.Value + "'" + splitICO;
                            }
                        }
                        if (con is CheckBox)
                        {
                            CheckBox cbt = con as CheckBox;
                            if (cbt.TabStop == true)
                            {
                                if (cbt.Checked == true)
                                {
                                    data += "'" + "Ja" + "'" + splitICO;
                                }
                                else
                                {
                                    data += "'" + "Nein" + "'" + splitICO;
                                }
                            }
                        }
                    }
                }
                if (control is Panel)
                {
                    foreach (var con in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))//Control con in control.Controls
                    {
                        if (con is TextBox)
                        {
                            TextBox txt = con as TextBox;
                            if (txt.TabStop == true)
                            {
                                data += "'" + txt.Text + "'" + splitICO;
                            }
                        }
                        if (con is MaskedTextBox)
                        {
                            MaskedTextBox mtxt = con as MaskedTextBox;
                            if (mtxt.TabStop == true)
                            {
                                data += "'" + mtxt.Text + "'" + splitICO;
                            }
                        }
                        if (con is ComboBox)
                        {
                            ComboBox cbt = con as ComboBox;
                            if (cbt.TabStop == true)
                            {
                                data += "'" + cbt.Text + "'" + splitICO;
                            }
                        }
                        if (con is NumericUpDown)
                        {
                            NumericUpDown nud = con as NumericUpDown;
                            if (nud.TabStop == true)
                            {
                                data += "'" + nud.Value + "'" + splitICO;
                            }
                        }
                        if (con is CheckBox)
                        {
                            CheckBox cbt = con as CheckBox;
                            if (cbt.TabStop == true)
                            {
                                if (cbt.Checked == true)
                                {
                                    data += "'" + "Ja" + "'" + splitICO;
                                }
                                else
                                {
                                    data += "'" + "Nein" + "'" + splitICO;
                                }
                            }
                        }
                    }
                }
                if (control is SplitContainer)
                {
                    foreach (var con in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))//Control con in control.Controls
                    {
                        if (con is TextBox)
                        {
                            TextBox txt = con as TextBox;
                            if (txt.TabStop == true)
                            {
                                data += "'" + txt.Text + "'" + splitICO;
                            }
                        }
                        if (con is MaskedTextBox)
                        {
                            MaskedTextBox mtxt = con as MaskedTextBox;
                            if (mtxt.TabStop == true)
                            {
                                data += "'" + mtxt.Text + "'" + splitICO;
                            }
                        }
                        if (con is ComboBox)
                        {
                            ComboBox cbt = con as ComboBox;
                            if (cbt.TabStop == true)
                            {
                                data += "'" + cbt.Text + "'" + splitICO;
                            }
                        }
                        if (con is NumericUpDown)
                        {
                            NumericUpDown nud = con as NumericUpDown;
                            if (nud.TabStop == true)
                            {
                                data += "'" + nud.Value + "'" + splitICO;
                            }
                        }
                        if (con is CheckBox)
                        {
                            CheckBox cbt = con as CheckBox;
                            if (cbt.TabStop == true)
                            {
                                if (cbt.Checked == true)
                                {
                                    data += "'" + "Ja" + "'" + splitICO;
                                }
                                else
                                {
                                    data += "'" + "Nein" + "'" + splitICO;
                                }
                            }
                        }
                    }
                }
                if (control is TabControl)
                {
                    foreach (var con in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))//Control con in control.Controls
                    {
                        foreach (var cont in con.Controls.OfType<Control>().OrderBy(x => x.TabIndex))
                        {
                            if (cont is TextBox)
                            {
                                TextBox txt = cont as TextBox;
                                if (txt.TabStop==true)
                                {
                                    data += "'" + txt.Text + "'" + splitICO;
                                }
                            }
                            if (cont is MaskedTextBox)
                            {
                                MaskedTextBox mtxt = cont as MaskedTextBox;
                                if (mtxt.TabStop==true)
                                {
                                    data += "'" + mtxt.Text + "'" + splitICO;
                                }
                            }
                            if (cont is ComboBox)
                            {
                                ComboBox cbt = cont as ComboBox;
                                if (cbt.TabStop==true)
                                {
                                    data += "'" + cbt.Text + "'" + splitICO;
                                }
                            }
                            if (cont is NumericUpDown)
                            {
                                NumericUpDown nud = cont as NumericUpDown;
                                if (nud.TabStop==true)
                                {
                                    data += "'" + nud.Value + "'" + splitICO;
                                }
                            }
                            if (cont is CheckBox)
                            {
                                CheckBox cbt = cont as CheckBox;
                                if (cbt.TabStop==true)
                                {
                                    if (cbt.Checked == true)
                                    {
                                        data += "'" + "Ja" + "'" + splitICO;
                                    }
                                    else
                                    {
                                        data += "'" + "Nein" + "'" + splitICO;
                                    }
                                }
                            }
                        }
                    }
                }
                if (control is TableLayoutPanel)
                {
                    foreach (var con in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))//Control con in control.Controls
                    {
                        if (con is TextBox)
                        {
                            TextBox txt = con as TextBox;
                            if (txt.TabStop == true)
                            {
                                data += "'" + txt.Text + "'" + splitICO;
                            }
                        }
                        if (con is MaskedTextBox)
                        {
                            MaskedTextBox mtxt = con as MaskedTextBox;
                            if (mtxt.TabStop == true)
                            {
                                data += "'" + mtxt.Text + "'" + splitICO;
                            }
                        }
                        if (con is ComboBox)
                        {
                            ComboBox cbt = con as ComboBox;
                            if (cbt.TabStop == true)
                            {
                                data += "'" + cbt.Text + "'" + splitICO;
                            }
                        }
                        if (con is NumericUpDown)
                        {
                            NumericUpDown nud = con as NumericUpDown;
                            if (nud.TabStop == true)
                            {
                                data += "'" + nud.Value + "'" + splitICO;
                            }
                        }
                        if (con is CheckBox)
                        {
                            CheckBox cbt = con as CheckBox;
                            if (cbt.TabStop == true)
                            {
                                if (cbt.Checked == true)
                                {
                                    data += "'" + "Ja" + "'" + splitICO;
                                }
                                else
                                {
                                    data += "'" + "Nein" + "'" + splitICO;
                                }
                            }
                        }
                    }
                }
            }
            return data;
        }


        public string StringToSha512(string Text)//erzeugt einen Hash nach SHA512
        {
            byte[] bytekey = Encoding.UTF8.GetBytes(Text);
            SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();
            byte[] bytehash = sha512.ComputeHash(bytekey);
            string hash = BitConverter.ToString(bytehash);
            return hash;
        }


        public string DataGridViweSelectData(int Spalte, DataGridView DataGridViwe)//Metod: DataGridView Celle auslessen
        {
            if (DataGridViwe.DataSource!=null)//Prüft ob überhaupt Daten in der DataGridViwe sind
            {
                if (DataGridViwe.SelectedRows.Count > 0)//Prüft ob eine Zeile ausgewählt worden ist
                {
                    if (DataGridViwe.SelectedRows[0].Cells[Spalte].Value!=null)
                    {
                        try
                        {
                            string[] Cellen = Convert.ToString(DataGridViwe.SelectedRows[0].Cells[Spalte].Value).Split(',');
                            string Celle = Cellen[0];
                            return Celle;
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Es konnte nichts gelöscht werden!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es konnten keine Daten gefunden werden!", "Hinweis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden keine zeilen ausgewählt!", "Hinweis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Es existiren keine Daten!", "Hinweis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
    }
}
