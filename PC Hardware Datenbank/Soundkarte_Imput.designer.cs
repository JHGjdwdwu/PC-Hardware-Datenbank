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
            this.chbTDIF = new System.Windows.Forms.CheckBox();
            this.chbS_PDIF = new System.Windows.Forms.CheckBox();
            this.chbMADI = new System.Windows.Forms.CheckBox();
            this.chbChinch = new System.Windows.Forms.CheckBox();
            this.chbKlinke = new System.Windows.Forms.CheckBox();
            this.chbAES_EBU = new System.Windows.Forms.CheckBox();
            this.chbADAT = new System.Windows.Forms.CheckBox();
            this.grpSonstiges = new System.Windows.Forms.GroupBox();
            this.chbWavetable = new System.Windows.Forms.CheckBox();
            this.chbMikrofon = new System.Windows.Forms.CheckBox();
            this.chbGameport = new System.Windows.Forms.CheckBox();
            this.chbMIDI = new System.Windows.Forms.CheckBox();
            this.chbDSP = new System.Windows.Forms.CheckBox();
            this.chbBreakoutBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wtxtBitaufloesung = new System.Windows.Forms.ComboBox();
            this.wtxtAnschlusssSchnittstelle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtAusgabestandard = new System.Windows.Forms.ComboBox();
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
            this.pcmdMainbord.TabIndex = 90;
            this.pcmdMainbord.TabStop = false;
            // 
            // grpAudioSchnittstellen
            // 
            this.grpAudioSchnittstellen.Controls.Add(this.chbTDIF);
            this.grpAudioSchnittstellen.Controls.Add(this.chbS_PDIF);
            this.grpAudioSchnittstellen.Controls.Add(this.chbMADI);
            this.grpAudioSchnittstellen.Controls.Add(this.chbChinch);
            this.grpAudioSchnittstellen.Controls.Add(this.chbKlinke);
            this.grpAudioSchnittstellen.Controls.Add(this.chbAES_EBU);
            this.grpAudioSchnittstellen.Controls.Add(this.chbADAT);
            this.grpAudioSchnittstellen.Location = new System.Drawing.Point(34, 189);
            this.grpAudioSchnittstellen.Name = "grpAudioSchnittstellen";
            this.grpAudioSchnittstellen.Size = new System.Drawing.Size(159, 293);
            this.grpAudioSchnittstellen.TabIndex = 4;
            this.grpAudioSchnittstellen.TabStop = false;
            this.grpAudioSchnittstellen.Text = "Audioschnittstellen";
            // 
            // chbTDIF
            // 
            this.chbTDIF.AutoSize = true;
            this.chbTDIF.Location = new System.Drawing.Point(15, 257);
            this.chbTDIF.Name = "chbTDIF";
            this.chbTDIF.Size = new System.Drawing.Size(64, 24);
            this.chbTDIF.TabIndex = 6;
            this.chbTDIF.Text = "TDIF";
            this.chbTDIF.UseVisualStyleBackColor = true;
            // 
            // chbS_PDIF
            // 
            this.chbS_PDIF.AutoSize = true;
            this.chbS_PDIF.Location = new System.Drawing.Point(15, 220);
            this.chbS_PDIF.Name = "chbS_PDIF";
            this.chbS_PDIF.Size = new System.Drawing.Size(80, 24);
            this.chbS_PDIF.TabIndex = 5;
            this.chbS_PDIF.Text = "S/PDIF";
            this.chbS_PDIF.UseVisualStyleBackColor = true;
            // 
            // chbMADI
            // 
            this.chbMADI.AutoSize = true;
            this.chbMADI.Location = new System.Drawing.Point(15, 183);
            this.chbMADI.Name = "chbMADI";
            this.chbMADI.Size = new System.Drawing.Size(69, 24);
            this.chbMADI.TabIndex = 4;
            this.chbMADI.Text = "MADI";
            this.chbMADI.UseVisualStyleBackColor = true;
            // 
            // chbChinch
            // 
            this.chbChinch.AutoSize = true;
            this.chbChinch.Location = new System.Drawing.Point(15, 109);
            this.chbChinch.Name = "chbChinch";
            this.chbChinch.Size = new System.Drawing.Size(129, 24);
            this.chbChinch.TabIndex = 2;
            this.chbChinch.Text = "Chinchbuchse";
            this.chbChinch.UseVisualStyleBackColor = true;
            // 
            // chbKlinke
            // 
            this.chbKlinke.AutoSize = true;
            this.chbKlinke.Location = new System.Drawing.Point(15, 146);
            this.chbKlinke.Name = "chbKlinke";
            this.chbKlinke.Size = new System.Drawing.Size(131, 24);
            this.chbKlinke.TabIndex = 3;
            this.chbKlinke.Text = "Klinkenbuchse";
            this.chbKlinke.UseVisualStyleBackColor = true;
            // 
            // chbAES_EBU
            // 
            this.chbAES_EBU.AutoSize = true;
            this.chbAES_EBU.Location = new System.Drawing.Point(15, 72);
            this.chbAES_EBU.Name = "chbAES_EBU";
            this.chbAES_EBU.Size = new System.Drawing.Size(99, 24);
            this.chbAES_EBU.TabIndex = 1;
            this.chbAES_EBU.Text = "AES/EBU";
            this.chbAES_EBU.UseVisualStyleBackColor = true;
            // 
            // chbADAT
            // 
            this.chbADAT.AutoSize = true;
            this.chbADAT.Location = new System.Drawing.Point(15, 35);
            this.chbADAT.Name = "chbADAT";
            this.chbADAT.Size = new System.Drawing.Size(71, 24);
            this.chbADAT.TabIndex = 0;
            this.chbADAT.Text = "ADAT";
            this.chbADAT.UseVisualStyleBackColor = true;
            // 
            // grpSonstiges
            // 
            this.grpSonstiges.Controls.Add(this.chbWavetable);
            this.grpSonstiges.Controls.Add(this.chbMikrofon);
            this.grpSonstiges.Controls.Add(this.chbGameport);
            this.grpSonstiges.Controls.Add(this.chbMIDI);
            this.grpSonstiges.Controls.Add(this.chbDSP);
            this.grpSonstiges.Controls.Add(this.chbBreakoutBox);
            this.grpSonstiges.Location = new System.Drawing.Point(252, 189);
            this.grpSonstiges.Name = "grpSonstiges";
            this.grpSonstiges.Size = new System.Drawing.Size(166, 293);
            this.grpSonstiges.TabIndex = 5;
            this.grpSonstiges.TabStop = false;
            this.grpSonstiges.Text = "Sonstiges";
            // 
            // chbWavetable
            // 
            this.chbWavetable.AutoSize = true;
            this.chbWavetable.Location = new System.Drawing.Point(15, 220);
            this.chbWavetable.Name = "chbWavetable";
            this.chbWavetable.Size = new System.Drawing.Size(103, 24);
            this.chbWavetable.TabIndex = 5;
            this.chbWavetable.Text = "Wavetable";
            this.chbWavetable.UseVisualStyleBackColor = true;
            // 
            // chbMikrofon
            // 
            this.chbMikrofon.AutoSize = true;
            this.chbMikrofon.Location = new System.Drawing.Point(15, 183);
            this.chbMikrofon.Name = "chbMikrofon";
            this.chbMikrofon.Size = new System.Drawing.Size(146, 24);
            this.chbMikrofon.TabIndex = 4;
            this.chbMikrofon.Text = "Mikrofoneingang";
            this.chbMikrofon.UseVisualStyleBackColor = true;
            // 
            // chbGameport
            // 
            this.chbGameport.AutoSize = true;
            this.chbGameport.Location = new System.Drawing.Point(15, 109);
            this.chbGameport.Name = "chbGameport";
            this.chbGameport.Size = new System.Drawing.Size(100, 24);
            this.chbGameport.TabIndex = 2;
            this.chbGameport.Text = "Gameport";
            this.chbGameport.UseVisualStyleBackColor = true;
            // 
            // chbMIDI
            // 
            this.chbMIDI.AutoSize = true;
            this.chbMIDI.Location = new System.Drawing.Point(15, 146);
            this.chbMIDI.Name = "chbMIDI";
            this.chbMIDI.Size = new System.Drawing.Size(63, 24);
            this.chbMIDI.TabIndex = 3;
            this.chbMIDI.Text = "MIDI";
            this.chbMIDI.UseVisualStyleBackColor = true;
            // 
            // chbDSP
            // 
            this.chbDSP.AutoSize = true;
            this.chbDSP.Location = new System.Drawing.Point(15, 72);
            this.chbDSP.Name = "chbDSP";
            this.chbDSP.Size = new System.Drawing.Size(61, 24);
            this.chbDSP.TabIndex = 1;
            this.chbDSP.Text = "DSP";
            this.chbDSP.UseVisualStyleBackColor = true;
            // 
            // chbBreakoutBox
            // 
            this.chbBreakoutBox.AutoSize = true;
            this.chbBreakoutBox.Location = new System.Drawing.Point(15, 35);
            this.chbBreakoutBox.Name = "chbBreakoutBox";
            this.chbBreakoutBox.Size = new System.Drawing.Size(124, 24);
            this.chbBreakoutBox.TabIndex = 0;
            this.chbBreakoutBox.Text = "Breakout Box";
            this.chbBreakoutBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Hersteller:";
            // 
            // wtxtHersteller
            // 
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
            this.wtxtHersteller.Location = new System.Drawing.Point(253, 135);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Bit-Auflösung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(248, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Anschlussschnittstelle:";
            // 
            // wtxtBitaufloesung
            // 
            this.wtxtBitaufloesung.FormattingEnabled = true;
            this.wtxtBitaufloesung.Items.AddRange(new object[] {
            "8",
            "16",
            "24"});
            this.wtxtBitaufloesung.Location = new System.Drawing.Point(34, 135);
            this.wtxtBitaufloesung.Name = "wtxtBitaufloesung";
            this.wtxtBitaufloesung.Size = new System.Drawing.Size(146, 28);
            this.wtxtBitaufloesung.TabIndex = 2;
            // 
            // wtxtAnschlusssSchnittstelle
            // 
            this.wtxtAnschlusssSchnittstelle.FormattingEnabled = true;
            this.wtxtAnschlusssSchnittstelle.Items.AddRange(new object[] {
            "ExpressCard",
            "ISA",
            "PCI",
            "PCI-E",
            "PCMCIA",
            "USB",
            "FireWire"});
            this.wtxtAnschlusssSchnittstelle.Location = new System.Drawing.Point(253, 61);
            this.wtxtAnschlusssSchnittstelle.Name = "wtxtAnschlusssSchnittstelle";
            this.wtxtAnschlusssSchnittstelle.Size = new System.Drawing.Size(146, 28);
            this.wtxtAnschlusssSchnittstelle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Ausgabestandard:";
            // 
            // wtxtAusgabestandard
            // 
            this.wtxtAusgabestandard.FormattingEnabled = true;
            this.wtxtAusgabestandard.Items.AddRange(new object[] {
            "ASIO",
            "DTS-ES",
            "EAX"});
            this.wtxtAusgabestandard.Location = new System.Drawing.Point(34, 61);
            this.wtxtAusgabestandard.Name = "wtxtAusgabestandard";
            this.wtxtAusgabestandard.Size = new System.Drawing.Size(146, 28);
            this.wtxtAusgabestandard.TabIndex = 0;
            // 
            // Soundkarte_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
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
            this.Text = "Soundkarte_Imput";
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
        private System.Windows.Forms.CheckBox chbTDIF;
        private System.Windows.Forms.CheckBox chbS_PDIF;
        private System.Windows.Forms.CheckBox chbMADI;
        private System.Windows.Forms.CheckBox chbChinch;
        private System.Windows.Forms.CheckBox chbKlinke;
        private System.Windows.Forms.CheckBox chbAES_EBU;
        private System.Windows.Forms.CheckBox chbADAT;
        private System.Windows.Forms.GroupBox grpSonstiges;
        private System.Windows.Forms.CheckBox chbWavetable;
        private System.Windows.Forms.CheckBox chbMikrofon;
        private System.Windows.Forms.CheckBox chbGameport;
        private System.Windows.Forms.CheckBox chbMIDI;
        private System.Windows.Forms.CheckBox chbDSP;
        private System.Windows.Forms.CheckBox chbBreakoutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wtxtBitaufloesung;
        private System.Windows.Forms.ComboBox wtxtAnschlusssSchnittstelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtAusgabestandard;
    }
}