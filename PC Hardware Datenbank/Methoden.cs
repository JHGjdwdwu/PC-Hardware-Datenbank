using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PC_Hardware_Datenbank
{
    class Methoden
    {
        public string MySqlConnectionString()//Methode: MySQL Verbindungs Daten
        {
            //string myConnectionString = "SERVER=127.0.0.1;" + einstelungen.Server + ";" +
            //                "DATABASE=" + einstelungen.Datenbank + ";" +
            //                "UID=" + einstelungen.Password + ";" +
            //                "PASSWORD=" + einstelungen.Password + ";";

            string myConnectionString = "SERVER=127.0.0.1;DATABASE=pc-hardware-datenbank;UID=root;PASSWORD=;Charset=utf8";
            return myConnectionString;
        }


        public void MySQL_ping_check(string MySqlConnectionString)//Methode: Prüfen ob DB erreicht werden kann.
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM `sonstiges` WHERE `Hersteller`='abc';";
            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank aufgebaut werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return null;
            }
        }


        public string[] MySqlToString(string MySqlConnectionString, string MySqlCommandText)//Metod: MySQL-Daten als Array ausgeben
        {
            //string[] Daten = new string[3];
            MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = MySqlCommandText;
            MySqlDataReader Reader;

            try
            {
                connection.Open();
                Reader = command.ExecuteReader();
                string[] Daten = new string[Reader.FieldCount];
                while (Reader.Read())
                {
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        Daten[i] = Reader.GetValue(i).ToString();
                    }
                }
                connection.Close();
                return Daten;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Fahlscher SQL Befehl!");
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
    }
}
