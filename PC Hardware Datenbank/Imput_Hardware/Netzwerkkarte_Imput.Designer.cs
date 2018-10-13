namespace PC_Hardware_Datenbank
{
    partial class Netzwerkkarte_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Netzwerkkarte_Imput));
            this.wtxtGeschwindigkeit = new System.Windows.Forms.ComboBox();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtSchnittstelle = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtWLan = new System.Windows.Forms.CheckBox();
            this.cbtLWL = new System.Windows.Forms.CheckBox();
            this.cbtCoax = new System.Windows.Forms.CheckBox();
            this.cbtRJ45 = new System.Windows.Forms.CheckBox();
            this.nudWLan = new System.Windows.Forms.NumericUpDown();
            this.nudLWL = new System.Windows.Forms.NumericUpDown();
            this.nudCoax = new System.Windows.Forms.NumericUpDown();
            this.nudRJ45 = new System.Windows.Forms.NumericUpDown();
            this.wtxtTyp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLWL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRJ45)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtGeschwindigkeit
            // 
            this.wtxtGeschwindigkeit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtGeschwindigkeit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtGeschwindigkeit.FormattingEnabled = true;
            this.wtxtGeschwindigkeit.Items.AddRange(new object[] {
            "",
            "10Base-T (10Mb/s)",
            "100Base-T (100Mb/s)",
            "1000Base-T (1Gb/s)",
            "2.5GBase-T (2.5Gb/s)",
            "5GBase-T (5Gb/s)",
            "10GBase-T (10Gb/s)",
            "IEEE 802.11",
            "IEEE 802.11a",
            "IEEE 802.11b",
            "IEEE 802.11g",
            "IEEE 802.11n",
            "IEEE 802.11ac",
            "IEEE 802.11ad",
            "IEEE 802.11ah"});
            this.wtxtGeschwindigkeit.Location = new System.Drawing.Point(311, 135);
            this.wtxtGeschwindigkeit.Name = "wtxtGeschwindigkeit";
            this.wtxtGeschwindigkeit.Size = new System.Drawing.Size(229, 28);
            this.wtxtGeschwindigkeit.TabIndex = 3;
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtHersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "",
            "Allied Telesis",
            "Allnet",
            "Apple",
            "ASUS",
            "Asus",
            "ATTO",
            "Belkin",
            "Broadcom",
            "Cisco",
            "D-Link",
            "Dell",
            "DeLOCK",
            "Digitus",
            "Dynamode",
            "Edimax",
            "Eminent",
            "Exsys",
            "Fantec",
            "Fujitsu",
            "Gembird",
            "Hama",
            "HP",
            "i-tec",
            "InLine",
            "Intel",
            "Intellinet",
            "j5create",
            "Kensington",
            "Lenovo",
            "Level One",
            "Lindy",
            "Linksys",
            "LMP",
            "LogiLink",
            "Longshine",
            "Manhattan",
            "Mellanox",
            "Moshi",
            "netis",
            "Planet",
            "Promise",
            "QLogic",
            "QNAP",
            "Sharkoon",
            "Sitecom",
            "Sonnet",
            "StarTech",
            "Supermicro",
            "Synology",
            "Thecus",
            "TP-Link",
            "TRENDnet",
            "Ultron",
            "V7"});
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(229, 28);
            this.wtxtHersteller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Hersteller:";
            // 
            // wtxtSchnittstelle
            // 
            this.wtxtSchnittstelle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtSchnittstelle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtSchnittstelle.FormattingEnabled = true;
            this.wtxtSchnittstelle.Items.AddRange(new object[] {
            "",
            "CardBus",
            "PCIe 1.0 x1",
            "PCIe 1.0 x4",
            "PCIe 1.0 x8",
            "PCIe 2.0 x1",
            "PCIe 2.0 x4",
            "PCIe 2.0 x8",
            "PCIe 2.1 x1",
            "PCIe 2.1 x4",
            "PCIe 2.1 x8",
            "PCIe 3.0 x4",
            "PCIe 3.0 x8",
            "PCIe 3.0 x16",
            "PCI-X",
            "PCI 2.1",
            "PCI 2.2",
            "PCI 2.3",
            "USB-A 2.0",
            "USB-A 3.0",
            "Thunderbolt 1",
            "Thunderbolt 2",
            "Thunderbolt 3",
            "SFP",
            "SFP+",
            "PCI",
            "PCIe",
            "PCIe 1.0",
            "PCIe 2.0",
            "PCIe 2.1",
            "PCIe 3.0",
            "Thunderbolt",
            "USB 2.0",
            "USB 3.0",
            "USB-A",
            "USB Micro-B",
            "USB-C"});
            this.wtxtSchnittstelle.Location = new System.Drawing.Point(311, 61);
            this.wtxtSchnittstelle.Name = "wtxtSchnittstelle";
            this.wtxtSchnittstelle.Size = new System.Drawing.Size(229, 28);
            this.wtxtSchnittstelle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 153;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdQR
            // 
            this.cmdQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQR.Location = new System.Drawing.Point(329, 571);
            this.cmdQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQR.Name = "cmdQR";
            this.cmdQR.Size = new System.Drawing.Size(171, 35);
            this.cmdQR.TabIndex = 9;
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
            this.cmdBildEinfugen.TabIndex = 6;
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
            this.cmdClear.TabIndex = 8;
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
            this.cmdSpeichern.TabIndex = 7;
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
            this.cmdBeenden.TabIndex = 10;
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
            this.pcmdMainbord.TabIndex = 152;
            this.pcmdMainbord.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(307, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 151;
            this.label5.Text = "Schnittstelle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 150;
            this.label2.Text = "Geschwindigkeit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtWLan);
            this.groupBox1.Controls.Add(this.cbtLWL);
            this.groupBox1.Controls.Add(this.cbtCoax);
            this.groupBox1.Controls.Add(this.cbtRJ45);
            this.groupBox1.Controls.Add(this.nudWLan);
            this.groupBox1.Controls.Add(this.nudLWL);
            this.groupBox1.Controls.Add(this.nudCoax);
            this.groupBox1.Controls.Add(this.nudRJ45);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(182, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Externe Schnittstellen";
            // 
            // cbtWLan
            // 
            this.cbtWLan.AutoSize = true;
            this.cbtWLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtWLan.Location = new System.Drawing.Point(17, 133);
            this.cbtWLan.Name = "cbtWLan";
            this.cbtWLan.Size = new System.Drawing.Size(75, 24);
            this.cbtWLan.TabIndex = 29;
            this.cbtWLan.TabStop = false;
            this.cbtWLan.Text = "W-Lan";
            this.cbtWLan.UseVisualStyleBackColor = true;
            this.cbtWLan.CheckedChanged += new System.EventHandler(this.cbtWLan_CheckedChanged);
            // 
            // cbtLWL
            // 
            this.cbtLWL.AutoSize = true;
            this.cbtLWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtLWL.Location = new System.Drawing.Point(17, 104);
            this.cbtLWL.Name = "cbtLWL";
            this.cbtLWL.Size = new System.Drawing.Size(61, 24);
            this.cbtLWL.TabIndex = 26;
            this.cbtLWL.TabStop = false;
            this.cbtLWL.Text = "LWL";
            this.cbtLWL.UseVisualStyleBackColor = true;
            this.cbtLWL.CheckedChanged += new System.EventHandler(this.cbtLWL_CheckedChanged);
            // 
            // cbtCoax
            // 
            this.cbtCoax.AutoSize = true;
            this.cbtCoax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtCoax.Location = new System.Drawing.Point(17, 70);
            this.cbtCoax.Name = "cbtCoax";
            this.cbtCoax.Size = new System.Drawing.Size(64, 24);
            this.cbtCoax.TabIndex = 25;
            this.cbtCoax.TabStop = false;
            this.cbtCoax.Text = "Coax";
            this.cbtCoax.UseVisualStyleBackColor = true;
            this.cbtCoax.CheckedChanged += new System.EventHandler(this.cbtCoax_CheckedChanged);
            // 
            // cbtRJ45
            // 
            this.cbtRJ45.AutoSize = true;
            this.cbtRJ45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtRJ45.Location = new System.Drawing.Point(19, 37);
            this.cbtRJ45.Name = "cbtRJ45";
            this.cbtRJ45.Size = new System.Drawing.Size(71, 24);
            this.cbtRJ45.TabIndex = 66;
            this.cbtRJ45.TabStop = false;
            this.cbtRJ45.Text = "RJ-45";
            this.cbtRJ45.UseVisualStyleBackColor = true;
            this.cbtRJ45.CheckedChanged += new System.EventHandler(this.cbtRJ45_CheckedChanged);
            // 
            // nudWLan
            // 
            this.nudWLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWLan.Location = new System.Drawing.Point(114, 133);
            this.nudWLan.Name = "nudWLan";
            this.nudWLan.Size = new System.Drawing.Size(57, 26);
            this.nudWLan.TabIndex = 3;
            this.nudWLan.ValueChanged += new System.EventHandler(this.nudWLan_ValueChanged);
            // 
            // nudLWL
            // 
            this.nudLWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLWL.Location = new System.Drawing.Point(114, 101);
            this.nudLWL.Name = "nudLWL";
            this.nudLWL.Size = new System.Drawing.Size(57, 26);
            this.nudLWL.TabIndex = 2;
            this.nudLWL.ValueChanged += new System.EventHandler(this.nudLWL_ValueChanged);
            // 
            // nudCoax
            // 
            this.nudCoax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCoax.Location = new System.Drawing.Point(114, 69);
            this.nudCoax.Name = "nudCoax";
            this.nudCoax.Size = new System.Drawing.Size(57, 26);
            this.nudCoax.TabIndex = 1;
            this.nudCoax.ValueChanged += new System.EventHandler(this.nudCoax_ValueChanged);
            // 
            // nudRJ45
            // 
            this.nudRJ45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRJ45.Location = new System.Drawing.Point(114, 37);
            this.nudRJ45.Name = "nudRJ45";
            this.nudRJ45.Size = new System.Drawing.Size(57, 26);
            this.nudRJ45.TabIndex = 0;
            this.nudRJ45.ValueChanged += new System.EventHandler(this.nudRJ45_ValueChanged);
            // 
            // wtxtTyp
            // 
            this.wtxtTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtTyp.FormattingEnabled = true;
            this.wtxtTyp.Location = new System.Drawing.Point(34, 209);
            this.wtxtTyp.Name = "wtxtTyp";
            this.wtxtTyp.Size = new System.Drawing.Size(229, 28);
            this.wtxtTyp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 156;
            this.label3.Text = "Typ:";
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
            this.wtxtZustand.Location = new System.Drawing.Point(34, 135);
            this.wtxtZustand.Name = "wtxtZustand";
            this.wtxtZustand.Size = new System.Drawing.Size(229, 28);
            this.wtxtZustand.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 158;
            this.label4.Text = "Zustand:";
            // 
            // Netzwerkkarte_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wtxtTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wtxtGeschwindigkeit);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wtxtSchnittstelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Netzwerkkarte_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netzwerkkarten";
            this.Load += new System.EventHandler(this.Netzwerkkarte_Imput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLWL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRJ45)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox wtxtGeschwindigkeit;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtSchnittstelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbtWLan;
        private System.Windows.Forms.CheckBox cbtLWL;
        private System.Windows.Forms.CheckBox cbtCoax;
        private System.Windows.Forms.CheckBox cbtRJ45;
        private System.Windows.Forms.NumericUpDown nudWLan;
        private System.Windows.Forms.NumericUpDown nudLWL;
        private System.Windows.Forms.NumericUpDown nudCoax;
        private System.Windows.Forms.NumericUpDown nudRJ45;
        private System.Windows.Forms.ComboBox wtxtTyp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label4;
    }
}