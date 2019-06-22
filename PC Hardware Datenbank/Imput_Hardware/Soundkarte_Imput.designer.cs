namespace PC_Hardware_Datenbank
{
    partial class Soundkarte_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soundkarte_Imput));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.grpAudioSchnittstellen = new System.Windows.Forms.GroupBox();
            this.cbtS_PDIFc = new System.Windows.Forms.CheckBox();
            this.cbtTDIF = new System.Windows.Forms.CheckBox();
            this.cbtS_PDIFo = new System.Windows.Forms.CheckBox();
            this.cbtMADI = new System.Windows.Forms.CheckBox();
            this.cbtChinch = new System.Windows.Forms.CheckBox();
            this.cbtKlinke = new System.Windows.Forms.CheckBox();
            this.cbtAES_EBU = new System.Windows.Forms.CheckBox();
            this.cbtADAT = new System.Windows.Forms.CheckBox();
            this.grpSonstiges = new System.Windows.Forms.GroupBox();
            this.cbtWavetable = new System.Windows.Forms.CheckBox();
            this.cbtMikrofon = new System.Windows.Forms.CheckBox();
            this.cbtGameport = new System.Windows.Forms.CheckBox();
            this.cbtMIDI = new System.Windows.Forms.CheckBox();
            this.cbtDSP = new System.Windows.Forms.CheckBox();
            this.cbtBreakoutBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wtxtBitaufloesung = new System.Windows.Forms.ComboBox();
            this.wtxtAnschlusssSchnittstelle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtAusgabestandard = new System.Windows.Forms.ComboBox();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wtxtID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.grpAudioSchnittstellen.SuspendLayout();
            this.grpSonstiges.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
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
            this.cmdQR.TabIndex = 11;
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
            this.cmdBildEinfugen.TabIndex = 8;
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
            this.cmdClear.TabIndex = 10;
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
            this.cmdSpeichern.TabIndex = 9;
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
            this.cmdBeenden.TabIndex = 12;
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
            this.pcmdMainbord.TabIndex = 90;
            this.pcmdMainbord.TabStop = false;
            // 
            // grpAudioSchnittstellen
            // 
            this.grpAudioSchnittstellen.Controls.Add(this.cbtS_PDIFc);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtTDIF);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtS_PDIFo);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtMADI);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtChinch);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtKlinke);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtAES_EBU);
            this.grpAudioSchnittstellen.Controls.Add(this.cbtADAT);
            this.grpAudioSchnittstellen.Location = new System.Drawing.Point(34, 189);
            this.grpAudioSchnittstellen.Name = "grpAudioSchnittstellen";
            this.grpAudioSchnittstellen.Size = new System.Drawing.Size(159, 339);
            this.grpAudioSchnittstellen.TabIndex = 6;
            this.grpAudioSchnittstellen.TabStop = false;
            this.grpAudioSchnittstellen.Text = "Audioschnittstellen";
            // 
            // cbtS_PDIFc
            // 
            this.cbtS_PDIFc.AutoSize = true;
            this.cbtS_PDIFc.Location = new System.Drawing.Point(15, 260);
            this.cbtS_PDIFc.Name = "cbtS_PDIFc";
            this.cbtS_PDIFc.Size = new System.Drawing.Size(121, 24);
            this.cbtS_PDIFc.TabIndex = 6;
            this.cbtS_PDIFc.Text = "S/PDIF cinch";
            this.cbtS_PDIFc.UseVisualStyleBackColor = true;
            // 
            // cbtTDIF
            // 
            this.cbtTDIF.AutoSize = true;
            this.cbtTDIF.Location = new System.Drawing.Point(15, 296);
            this.cbtTDIF.Name = "cbtTDIF";
            this.cbtTDIF.Size = new System.Drawing.Size(64, 24);
            this.cbtTDIF.TabIndex = 7;
            this.cbtTDIF.Text = "TDIF";
            this.cbtTDIF.UseVisualStyleBackColor = true;
            // 
            // cbtS_PDIFo
            // 
            this.cbtS_PDIFo.AutoSize = true;
            this.cbtS_PDIFo.Location = new System.Drawing.Point(15, 220);
            this.cbtS_PDIFo.Name = "cbtS_PDIFo";
            this.cbtS_PDIFo.Size = new System.Drawing.Size(130, 24);
            this.cbtS_PDIFo.TabIndex = 5;
            this.cbtS_PDIFo.Text = "S/PDIF optical";
            this.cbtS_PDIFo.UseVisualStyleBackColor = true;
            // 
            // cbtMADI
            // 
            this.cbtMADI.AutoSize = true;
            this.cbtMADI.Location = new System.Drawing.Point(15, 183);
            this.cbtMADI.Name = "cbtMADI";
            this.cbtMADI.Size = new System.Drawing.Size(69, 24);
            this.cbtMADI.TabIndex = 4;
            this.cbtMADI.Text = "MADI";
            this.cbtMADI.UseVisualStyleBackColor = true;
            // 
            // cbtChinch
            // 
            this.cbtChinch.AutoSize = true;
            this.cbtChinch.Location = new System.Drawing.Point(15, 109);
            this.cbtChinch.Name = "cbtChinch";
            this.cbtChinch.Size = new System.Drawing.Size(129, 24);
            this.cbtChinch.TabIndex = 2;
            this.cbtChinch.Text = "Chinchbuchse";
            this.cbtChinch.UseVisualStyleBackColor = true;
            // 
            // cbtKlinke
            // 
            this.cbtKlinke.AutoSize = true;
            this.cbtKlinke.Location = new System.Drawing.Point(15, 146);
            this.cbtKlinke.Name = "cbtKlinke";
            this.cbtKlinke.Size = new System.Drawing.Size(131, 24);
            this.cbtKlinke.TabIndex = 3;
            this.cbtKlinke.Text = "Klinkenbuchse";
            this.cbtKlinke.UseVisualStyleBackColor = true;
            // 
            // cbtAES_EBU
            // 
            this.cbtAES_EBU.AutoSize = true;
            this.cbtAES_EBU.Location = new System.Drawing.Point(15, 72);
            this.cbtAES_EBU.Name = "cbtAES_EBU";
            this.cbtAES_EBU.Size = new System.Drawing.Size(99, 24);
            this.cbtAES_EBU.TabIndex = 1;
            this.cbtAES_EBU.Text = "AES/EBU";
            this.cbtAES_EBU.UseVisualStyleBackColor = true;
            // 
            // cbtADAT
            // 
            this.cbtADAT.AutoSize = true;
            this.cbtADAT.Location = new System.Drawing.Point(15, 35);
            this.cbtADAT.Name = "cbtADAT";
            this.cbtADAT.Size = new System.Drawing.Size(71, 24);
            this.cbtADAT.TabIndex = 0;
            this.cbtADAT.Text = "ADAT";
            this.cbtADAT.UseVisualStyleBackColor = true;
            // 
            // grpSonstiges
            // 
            this.grpSonstiges.Controls.Add(this.cbtWavetable);
            this.grpSonstiges.Controls.Add(this.cbtMikrofon);
            this.grpSonstiges.Controls.Add(this.cbtGameport);
            this.grpSonstiges.Controls.Add(this.cbtMIDI);
            this.grpSonstiges.Controls.Add(this.cbtDSP);
            this.grpSonstiges.Controls.Add(this.cbtBreakoutBox);
            this.grpSonstiges.Location = new System.Drawing.Point(244, 189);
            this.grpSonstiges.Name = "grpSonstiges";
            this.grpSonstiges.Size = new System.Drawing.Size(166, 339);
            this.grpSonstiges.TabIndex = 7;
            this.grpSonstiges.TabStop = false;
            this.grpSonstiges.Text = "Sonstiges";
            // 
            // cbtWavetable
            // 
            this.cbtWavetable.AutoSize = true;
            this.cbtWavetable.Location = new System.Drawing.Point(15, 220);
            this.cbtWavetable.Name = "cbtWavetable";
            this.cbtWavetable.Size = new System.Drawing.Size(103, 24);
            this.cbtWavetable.TabIndex = 5;
            this.cbtWavetable.Text = "Wavetable";
            this.cbtWavetable.UseVisualStyleBackColor = true;
            // 
            // cbtMikrofon
            // 
            this.cbtMikrofon.AutoSize = true;
            this.cbtMikrofon.Location = new System.Drawing.Point(15, 183);
            this.cbtMikrofon.Name = "cbtMikrofon";
            this.cbtMikrofon.Size = new System.Drawing.Size(146, 24);
            this.cbtMikrofon.TabIndex = 4;
            this.cbtMikrofon.Text = "Mikrofoneingang";
            this.cbtMikrofon.UseVisualStyleBackColor = true;
            // 
            // cbtGameport
            // 
            this.cbtGameport.AutoSize = true;
            this.cbtGameport.Location = new System.Drawing.Point(15, 109);
            this.cbtGameport.Name = "cbtGameport";
            this.cbtGameport.Size = new System.Drawing.Size(100, 24);
            this.cbtGameport.TabIndex = 2;
            this.cbtGameport.Text = "Gameport";
            this.cbtGameport.UseVisualStyleBackColor = true;
            // 
            // cbtMIDI
            // 
            this.cbtMIDI.AutoSize = true;
            this.cbtMIDI.Location = new System.Drawing.Point(15, 146);
            this.cbtMIDI.Name = "cbtMIDI";
            this.cbtMIDI.Size = new System.Drawing.Size(63, 24);
            this.cbtMIDI.TabIndex = 3;
            this.cbtMIDI.Text = "MIDI";
            this.cbtMIDI.UseVisualStyleBackColor = true;
            // 
            // cbtDSP
            // 
            this.cbtDSP.AutoSize = true;
            this.cbtDSP.Location = new System.Drawing.Point(15, 72);
            this.cbtDSP.Name = "cbtDSP";
            this.cbtDSP.Size = new System.Drawing.Size(61, 24);
            this.cbtDSP.TabIndex = 1;
            this.cbtDSP.Text = "DSP";
            this.cbtDSP.UseVisualStyleBackColor = true;
            // 
            // cbtBreakoutBox
            // 
            this.cbtBreakoutBox.AutoSize = true;
            this.cbtBreakoutBox.Location = new System.Drawing.Point(15, 35);
            this.cbtBreakoutBox.Name = "cbtBreakoutBox";
            this.cbtBreakoutBox.Size = new System.Drawing.Size(124, 24);
            this.cbtBreakoutBox.TabIndex = 0;
            this.cbtBreakoutBox.Text = "Breakout Box";
            this.cbtBreakoutBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Hersteller:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtHersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "AdLib",
            "Akai",
            "Analog Devices",
            "Apogee Electronics",
            "Asus",
            "Avid / Digidesign",
            "Behringer",
            "Club 3D",
            "Creative Labs",
            "Focusrite",
            "Gravis",
            "Guillemot Corporation",
            "M-Audio",
            "MOTU (Mark Of The Unicorn)",
            "Native Instruments",
            "Nvidia",
            "Philips",
            "RME",
            "Realtek",
            "Roland",
            "Steinberg",
            "TerraTec",
            "Universal Audio",
            "VIA Technologies",
            "Yamaha professional Audio"});
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Bit-Auflösung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(29, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Anschlussschnittstelle:";
            // 
            // wtxtBitaufloesung
            // 
            this.wtxtBitaufloesung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtBitaufloesung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtBitaufloesung.FormattingEnabled = true;
            this.wtxtBitaufloesung.Items.AddRange(new object[] {
            "8",
            "16",
            "24"});
            this.wtxtBitaufloesung.Location = new System.Drawing.Point(456, 135);
            this.wtxtBitaufloesung.Name = "wtxtBitaufloesung";
            this.wtxtBitaufloesung.Size = new System.Drawing.Size(146, 28);
            this.wtxtBitaufloesung.TabIndex = 5;
            // 
            // wtxtAnschlusssSchnittstelle
            // 
            this.wtxtAnschlusssSchnittstelle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtAnschlusssSchnittstelle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtAnschlusssSchnittstelle.FormattingEnabled = true;
            this.wtxtAnschlusssSchnittstelle.Items.AddRange(new object[] {
            "ExpressCard",
            "ISA",
            "PCI",
            "PCI-E",
            "PCMCIA",
            "USB",
            "FireWire"});
            this.wtxtAnschlusssSchnittstelle.Location = new System.Drawing.Point(34, 135);
            this.wtxtAnschlusssSchnittstelle.Name = "wtxtAnschlusssSchnittstelle";
            this.wtxtAnschlusssSchnittstelle.Size = new System.Drawing.Size(146, 28);
            this.wtxtAnschlusssSchnittstelle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(241, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Ausgabestandard:";
            // 
            // wtxtAusgabestandard
            // 
            this.wtxtAusgabestandard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtAusgabestandard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtAusgabestandard.FormattingEnabled = true;
            this.wtxtAusgabestandard.Items.AddRange(new object[] {
            "ASIO",
            "DTS-ES",
            "EAX"});
            this.wtxtAusgabestandard.Location = new System.Drawing.Point(245, 135);
            this.wtxtAusgabestandard.Name = "wtxtAusgabestandard";
            this.wtxtAusgabestandard.Size = new System.Drawing.Size(146, 28);
            this.wtxtAusgabestandard.TabIndex = 4;
            // 
            // wtxtZustand
            // 
            this.wtxtZustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtZustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtZustand.FormattingEnabled = true;
            this.wtxtZustand.Items.AddRange(new object[] {
            "verbaut",
            "auf Lager"});
            this.wtxtZustand.Location = new System.Drawing.Point(456, 61);
            this.wtxtZustand.Name = "wtxtZustand";
            this.wtxtZustand.Size = new System.Drawing.Size(146, 28);
            this.wtxtZustand.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(452, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Zustand:";
            // 
            // wtxtID
            // 
            this.wtxtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtID.FormattingEnabled = true;
            this.wtxtID.Location = new System.Drawing.Point(244, 61);
            this.wtxtID.Name = "wtxtID";
            this.wtxtID.Size = new System.Drawing.Size(146, 28);
            this.wtxtID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(240, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 119;
            this.label6.Text = "Bezeichnung:";
            // 
            // Soundkarte_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wtxtAusgabestandard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wtxtAnschlusssSchnittstelle);
            this.Controls.Add(this.grpSonstiges);
            this.Controls.Add(this.wtxtBitaufloesung);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.grpAudioSchnittstellen);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Soundkarte_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundkarten";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            this.grpAudioSchnittstellen.ResumeLayout(false);
            this.grpAudioSchnittstellen.PerformLayout();
            this.grpSonstiges.ResumeLayout(false);
            this.grpSonstiges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.GroupBox grpAudioSchnittstellen;
        private System.Windows.Forms.CheckBox cbtTDIF;
        private System.Windows.Forms.CheckBox cbtS_PDIFo;
        private System.Windows.Forms.CheckBox cbtMADI;
        private System.Windows.Forms.CheckBox cbtChinch;
        private System.Windows.Forms.CheckBox cbtKlinke;
        private System.Windows.Forms.CheckBox cbtAES_EBU;
        private System.Windows.Forms.CheckBox cbtADAT;
        private System.Windows.Forms.GroupBox grpSonstiges;
        private System.Windows.Forms.CheckBox cbtWavetable;
        private System.Windows.Forms.CheckBox cbtMikrofon;
        private System.Windows.Forms.CheckBox cbtGameport;
        private System.Windows.Forms.CheckBox cbtMIDI;
        private System.Windows.Forms.CheckBox cbtDSP;
        private System.Windows.Forms.CheckBox cbtBreakoutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wtxtBitaufloesung;
        private System.Windows.Forms.ComboBox wtxtAnschlusssSchnittstelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtAusgabestandard;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbtS_PDIFc;
        private System.Windows.Forms.ComboBox wtxtID;
        private System.Windows.Forms.Label label6;
    }
}