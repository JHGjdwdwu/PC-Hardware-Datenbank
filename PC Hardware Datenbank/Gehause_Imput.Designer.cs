namespace PC_Hardware_Datenbank
{
    partial class Gehause_Imput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gehause_Imput));
            this.wtxtTyp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wtxtNetzteilPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtBreiteHocheTiefe = new System.Windows.Forms.MaskedTextBox();
            this.nudEinschub5 = new System.Windows.Forms.NumericUpDown();
            this.nudEinschub3 = new System.Windows.Forms.NumericUpDown();
            this.nudHDD3 = new System.Windows.Forms.NumericUpDown();
            this.nudHDD2 = new System.Windows.Forms.NumericUpDown();
            this.cbtKabelsystem = new System.Windows.Forms.CheckBox();
            this.nudFrontUSB = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFrontKlinke = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtBelechtung = new System.Windows.Forms.CheckBox();
            this.cbtFenster = new System.Windows.Forms.CheckBox();
            this.wtxtFormfaktor = new System.Windows.Forms.ComboBox();
            this.fo = new System.Windows.Forms.Label();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinschub5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinschub3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHDD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHDD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontUSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontKlinke)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtTyp
            // 
            this.wtxtTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtTyp.FormattingEnabled = true;
            this.wtxtTyp.Items.AddRange(new object[] {
            "",
            "Ultra-kompakt (NUC)",
            "ITX/DTX",
            "Mini-Tower",
            "Midi-Tower",
            "Big-Tower",
            "Server-Tower",
            "Desktop",
            "Benchtable",
            "Sonderform"});
            this.wtxtTyp.Location = new System.Drawing.Point(249, 135);
            this.wtxtTyp.Name = "wtxtTyp";
            this.wtxtTyp.Size = new System.Drawing.Size(146, 28);
            this.wtxtTyp.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Typ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 133;
            this.label9.Text = "Einschub 3,5 Zoll:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "Einschub 2,5 HDD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 131;
            this.label7.Text = "Einschub 3,5 HDD:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // cmdQR
            // 
            this.cmdQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQR.Location = new System.Drawing.Point(329, 571);
            this.cmdQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQR.Name = "cmdQR";
            this.cmdQR.Size = new System.Drawing.Size(171, 35);
            this.cmdQR.TabIndex = 18;
            this.cmdQR.Text = "QR-Code Drucken";
            this.cmdQR.UseVisualStyleBackColor = false;
            this.cmdQR.Click += new System.EventHandler(this.cmdQR_Click);
            // 
            // cmdBildEinfugen
            // 
            this.cmdBildEinfugen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdBildEinfugen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBildEinfugen.Location = new System.Drawing.Point(827, 474);
            this.cmdBildEinfugen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBildEinfugen.Name = "cmdBildEinfugen";
            this.cmdBildEinfugen.Size = new System.Drawing.Size(150, 35);
            this.cmdBildEinfugen.TabIndex = 15;
            this.cmdBildEinfugen.Text = "Bild einfügen";
            this.cmdBildEinfugen.UseVisualStyleBackColor = false;
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.Yellow;
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(171, 571);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(150, 35);
            this.cmdClear.TabIndex = 17;
            this.cmdClear.Text = "Zurücksetzen";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.BackColor = System.Drawing.Color.Lime;
            this.cmdSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSpeichern.Location = new System.Drawing.Point(13, 571);
            this.cmdSpeichern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(150, 35);
            this.cmdSpeichern.TabIndex = 16;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = false;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.BackColor = System.Drawing.Color.OrangeRed;
            this.cmdBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBeenden.Location = new System.Drawing.Point(963, 571);
            this.cmdBeenden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(150, 35);
            this.cmdBeenden.TabIndex = 19;
            this.cmdBeenden.Text = "Schließen";
            this.cmdBeenden.UseVisualStyleBackColor = false;
            this.cmdBeenden.Click += new System.EventHandler(this.cmdBeenden_Click);
            // 
            // pcmdMainbord
            // 
            this.pcmdMainbord.Image = ((System.Drawing.Image)(resources.GetObject("pcmdMainbord.Image")));
            this.pcmdMainbord.Location = new System.Drawing.Point(663, 14);
            this.pcmdMainbord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcmdMainbord.Name = "pcmdMainbord";
            this.pcmdMainbord.Size = new System.Drawing.Size(450, 450);
            this.pcmdMainbord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcmdMainbord.TabIndex = 128;
            this.pcmdMainbord.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 126;
            this.label3.Text = "Einschub 5,25 Zoll:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Breite-Höhe-Tiefe:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtHersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "",
            "A Power",
            "ADATA",
            "AeroCool",
            "Akasa",
            "Amacrox",
            "Andyson",
            "Antec",
            "ARLT",
            "ASPower",
            "ASUS",
            "AXP",
            "be quiet!",
            "BitFenix",
            "Chieftec",
            "Cisco",
            "CiT",
            "Club 3D",
            "Codegen",
            "CompuCase",
            "Cooler Master",
            "Cooltek",
            "Corsair",
            "DeepCool",
            "Dell",
            "Enermax",
            "EVGA",
            "Fantec",
            "Fractal Design",
            "FSP",
            "Fujitsu",
            "Gigabyte",
            "GlacialPower",
            "High Power",
            "HP",
            "Huntkey",
            "In Win",
            "Intel",
            "Inter-Tech",
            "JCP",
            "Jersey",
            "Jou Jye",
            "Kingwin",
            "Kiss Quiet",
            "Kolink",
            "LC-Power",
            "Lenovo",
            "LEPA",
            "Levicom",
            "Lian Li",
            "Lindy",
            "Linkworld",
            "LogiLink",
            "Logisys ",
            "Mini-Box",
            "Modecom",
            "MS-Tech",
            "NesteQ",
            "Nofan",
            "Nox",
            "NZXT",
            "OCZ",
            "PC Power&Cooling",
            "PowerColor",
            "QNAP",
            "RaidSonic",
            "Rasurbo",
            "Rhombutech",
            "Riotoro",
            "Rosewill",
            "Sapphire",
            "Scythe",
            "Seasonic",
            "SevenTeam",
            "Sharkoon",
            "Shuttle",
            "SilentiumPC",
            "Silver Power",
            "Silverstone",
            "Sparkle",
            "Speedlink",
            "Spire",
            "Streacom",
            "Super Flower",
            "Supermicro",
            "Sure Star",
            "Tacens",
            "Tagan",
            "Techsolo",
            "Thermaltake",
            "Thortech",
            "Tronje",
            "Trust",
            "Ultra",
            "Ultron",
            "XFX",
            "Xigmatek",
            "Xilence",
            "XION",
            "Zalman",
            "Zippy"});
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 135);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 137;
            this.label4.Text = "Hersteller:";
            // 
            // wtxtNetzteilPosition
            // 
            this.wtxtNetzteilPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtNetzteilPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtNetzteilPosition.FormattingEnabled = true;
            this.wtxtNetzteilPosition.Items.AddRange(new object[] {
            "",
            "Oben",
            "Nunten",
            "Extern"});
            this.wtxtNetzteilPosition.Location = new System.Drawing.Point(34, 207);
            this.wtxtNetzteilPosition.Name = "wtxtNetzteilPosition";
            this.wtxtNetzteilPosition.Size = new System.Drawing.Size(146, 28);
            this.wtxtNetzteilPosition.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 139;
            this.label2.Text = "Netzteil Position:";
            // 
            // mtxtBreiteHocheTiefe
            // 
            this.mtxtBreiteHocheTiefe.Location = new System.Drawing.Point(34, 61);
            this.mtxtBreiteHocheTiefe.Name = "mtxtBreiteHocheTiefe";
            this.mtxtBreiteHocheTiefe.Size = new System.Drawing.Size(146, 26);
            this.mtxtBreiteHocheTiefe.TabIndex = 0;
            // 
            // nudEinschub5
            // 
            this.nudEinschub5.Location = new System.Drawing.Point(249, 209);
            this.nudEinschub5.Name = "nudEinschub5";
            this.nudEinschub5.Size = new System.Drawing.Size(146, 26);
            this.nudEinschub5.TabIndex = 5;
            // 
            // nudEinschub3
            // 
            this.nudEinschub3.Location = new System.Drawing.Point(34, 281);
            this.nudEinschub3.Name = "nudEinschub3";
            this.nudEinschub3.Size = new System.Drawing.Size(143, 26);
            this.nudEinschub3.TabIndex = 6;
            // 
            // nudHDD3
            // 
            this.nudHDD3.Location = new System.Drawing.Point(249, 283);
            this.nudHDD3.Name = "nudHDD3";
            this.nudHDD3.Size = new System.Drawing.Size(146, 26);
            this.nudHDD3.TabIndex = 7;
            // 
            // nudHDD2
            // 
            this.nudHDD2.Location = new System.Drawing.Point(34, 357);
            this.nudHDD2.Name = "nudHDD2";
            this.nudHDD2.Size = new System.Drawing.Size(143, 26);
            this.nudHDD2.TabIndex = 8;
            // 
            // cbtKabelsystem
            // 
            this.cbtKabelsystem.AutoSize = true;
            this.cbtKabelsystem.Location = new System.Drawing.Point(462, 63);
            this.cbtKabelsystem.Name = "cbtKabelsystem";
            this.cbtKabelsystem.Size = new System.Drawing.Size(118, 24);
            this.cbtKabelsystem.TabIndex = 12;
            this.cbtKabelsystem.Text = "Kabelsystem";
            this.cbtKabelsystem.UseVisualStyleBackColor = true;
            // 
            // nudFrontUSB
            // 
            this.nudFrontUSB.Location = new System.Drawing.Point(249, 355);
            this.nudFrontUSB.Name = "nudFrontUSB";
            this.nudFrontUSB.Size = new System.Drawing.Size(145, 26);
            this.nudFrontUSB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 145;
            this.label5.Text = "Front USB:";
            // 
            // nudFrontKlinke
            // 
            this.nudFrontKlinke.Location = new System.Drawing.Point(34, 427);
            this.nudFrontKlinke.Name = "nudFrontKlinke";
            this.nudFrontKlinke.Size = new System.Drawing.Size(145, 26);
            this.nudFrontKlinke.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 147;
            this.label10.Text = "Front Klinke:";
            // 
            // cbtBelechtung
            // 
            this.cbtBelechtung.AutoSize = true;
            this.cbtBelechtung.Location = new System.Drawing.Point(462, 137);
            this.cbtBelechtung.Name = "cbtBelechtung";
            this.cbtBelechtung.Size = new System.Drawing.Size(118, 24);
            this.cbtBelechtung.TabIndex = 13;
            this.cbtBelechtung.Text = "Beleuchtung";
            this.cbtBelechtung.UseVisualStyleBackColor = true;
            // 
            // cbtFenster
            // 
            this.cbtFenster.AutoSize = true;
            this.cbtFenster.Location = new System.Drawing.Point(462, 210);
            this.cbtFenster.Name = "cbtFenster";
            this.cbtFenster.Size = new System.Drawing.Size(148, 24);
            this.cbtFenster.TabIndex = 14;
            this.cbtFenster.Text = "Plexiglas Fenster";
            this.cbtFenster.UseVisualStyleBackColor = true;
            // 
            // wtxtFormfaktor
            // 
            this.wtxtFormfaktor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtFormfaktor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtFormfaktor.FormattingEnabled = true;
            this.wtxtFormfaktor.Items.AddRange(new object[] {
            "",
            "E-ATX",
            "ATX",
            "Mini-ITX",
            "µATX",
            "DTX",
            "Mini-DTX",
            "Mini-STX",
            "SSI-CEB"});
            this.wtxtFormfaktor.Location = new System.Drawing.Point(246, 427);
            this.wtxtFormfaktor.Name = "wtxtFormfaktor";
            this.wtxtFormfaktor.Size = new System.Drawing.Size(146, 28);
            this.wtxtFormfaktor.TabIndex = 11;
            // 
            // fo
            // 
            this.fo.AutoSize = true;
            this.fo.Location = new System.Drawing.Point(245, 404);
            this.fo.Name = "fo";
            this.fo.Size = new System.Drawing.Size(91, 20);
            this.fo.TabIndex = 149;
            this.fo.Text = "Formfaktor:";
            // 
            // wtxtZustand
            // 
            this.wtxtZustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtZustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtZustand.FormattingEnabled = true;
            this.wtxtZustand.Items.AddRange(new object[] {
            "",
            "verbaut",
            "auf Lager"});
            this.wtxtZustand.Location = new System.Drawing.Point(249, 61);
            this.wtxtZustand.Name = "wtxtZustand";
            this.wtxtZustand.Size = new System.Drawing.Size(146, 28);
            this.wtxtZustand.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(248, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 151;
            this.label11.Text = "Zustand:";
            // 
            // Gehause_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wtxtFormfaktor);
            this.Controls.Add(this.fo);
            this.Controls.Add(this.cbtFenster);
            this.Controls.Add(this.cbtBelechtung);
            this.Controls.Add(this.nudFrontKlinke);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudFrontUSB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudHDD2);
            this.Controls.Add(this.nudHDD3);
            this.Controls.Add(this.nudEinschub3);
            this.Controls.Add(this.nudEinschub5);
            this.Controls.Add(this.mtxtBreiteHocheTiefe);
            this.Controls.Add(this.wtxtNetzteilPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wtxtTyp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbtKabelsystem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gehause_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gehause_Imput";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinschub5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinschub3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHDD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHDD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontUSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontKlinke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wtxtTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wtxtNetzteilPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtBreiteHocheTiefe;
        private System.Windows.Forms.NumericUpDown nudEinschub5;
        private System.Windows.Forms.NumericUpDown nudEinschub3;
        private System.Windows.Forms.NumericUpDown nudHDD3;
        private System.Windows.Forms.NumericUpDown nudHDD2;
        private System.Windows.Forms.CheckBox cbtKabelsystem;
        private System.Windows.Forms.NumericUpDown nudFrontUSB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFrontKlinke;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbtBelechtung;
        private System.Windows.Forms.CheckBox cbtFenster;
        private System.Windows.Forms.ComboBox wtxtFormfaktor;
        private System.Windows.Forms.Label fo;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label11;
    }
}