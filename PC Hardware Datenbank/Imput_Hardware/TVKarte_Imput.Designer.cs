namespace PC_Hardware_Datenbank
{
    partial class TVKarte_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVKarte_Imput));
            this.wtxtAnschluss = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wtxtModell = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wtxtKartenhersteller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtDVB_S = new System.Windows.Forms.CheckBox();
            this.cbtDVB_T = new System.Windows.Forms.CheckBox();
            this.cbtDVB_C = new System.Windows.Forms.CheckBox();
            this.cbtAnalog = new System.Windows.Forms.CheckBox();
            this.nudDVB_S = new System.Windows.Forms.NumericUpDown();
            this.nudDVB_T = new System.Windows.Forms.NumericUpDown();
            this.nudDVB_C = new System.Windows.Forms.NumericUpDown();
            this.nudAnalog = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbtCinch = new System.Windows.Forms.CheckBox();
            this.cbtSVideo = new System.Windows.Forms.CheckBox();
            this.cbtScart = new System.Windows.Forms.CheckBox();
            this.cbtHDMI = new System.Windows.Forms.CheckBox();
            this.cbtODT = new System.Windows.Forms.CheckBox();
            this.cbtKlinke = new System.Windows.Forms.CheckBox();
            this.nudCinch = new System.Windows.Forms.NumericUpDown();
            this.nudSVideo = new System.Windows.Forms.NumericUpDown();
            this.nudScart = new System.Windows.Forms.NumericUpDown();
            this.nudHDMI = new System.Windows.Forms.NumericUpDown();
            this.nudODT = new System.Windows.Forms.NumericUpDown();
            this.nudKlinke = new System.Windows.Forms.NumericUpDown();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDVB_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDVB_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDVB_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalog)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCinch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHDMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudODT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKlinke)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtAnschluss
            // 
            this.wtxtAnschluss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtAnschluss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtAnschluss.FormattingEnabled = true;
            this.wtxtAnschluss.Items.AddRange(new object[] {
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
            this.wtxtAnschluss.Location = new System.Drawing.Point(249, 135);
            this.wtxtAnschluss.Name = "wtxtAnschluss";
            this.wtxtAnschluss.Size = new System.Drawing.Size(146, 28);
            this.wtxtAnschluss.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Anschlussart:";
            // 
            // wtxtModell
            // 
            this.wtxtModell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtModell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtModell.FormattingEnabled = true;
            this.wtxtModell.Location = new System.Drawing.Point(249, 61);
            this.wtxtModell.Name = "wtxtModell";
            this.wtxtModell.Size = new System.Drawing.Size(146, 28);
            this.wtxtModell.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 150;
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
            this.pcmdMainbord.TabIndex = 149;
            this.pcmdMainbord.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(245, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 148;
            this.label5.Text = "Modell:";
            // 
            // wtxtKartenhersteller
            // 
            this.wtxtKartenhersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtKartenhersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtKartenhersteller.FormattingEnabled = true;
            this.wtxtKartenhersteller.Items.AddRange(new object[] {
            "",
            "Adaptec",
            "ADS Tech",
            "AJA",
            "AMD / ATI",
            "Anubis",
            "Artec",
            "Askey",
            "Asus",
            "Atelco Computer",
            "AVerMedia",
            "Avid",
            "Brainwave",
            "Canopus",
            "Compro",
            "Datavideo",
            "Dazzle",
            "Dexatek",
            "Digital Devices",
            "Digital Everywhere",
            "Digital Rise",
            "Digitus",
            "DNT",
            "Electronic Design",
            "Elgato",
            "Elta",
            "Ewent",
            "F&V",
            "Fast Multimedia",
            "Formac",
            "FreenetTV",
            "Fujitsu",
            "Fujitsu-Siemens",
            "Gainward",
            "Gefen",
            "Geniatech",
            "Genius Europe",
            "Hauppauge",
            "Hercules",
            "HMP",
            "ICY BOX",
            "Kjaerulff1",
            "KNC One",
            "Kworld",
            "Leadtek",
            "Lenco",
            "LifeView",
            "LogiLink",
            "Lorenzen",
            "Manhattan",
            "Matrox",
            "Maxfield",
            "MCFTec",
            "Media 100",
            "Miro",
            "MSI",
            "Nvidia",
            "PCTV",
            "Pearl",
            "Pinnacle Systems",
            "Pixelview",
            "Plextor",
            "Point of View",
            "Prolink",
            "Roxio",
            "Sapphire",
            "Satelco",
            "Siemens",
            "Skymaster",
            "Startech",
            "Technaxx",
            "TechniSat",
            "Techno Trend",
            "Telestar",
            "TerraTec",
            "Toshiba",
            "Transcend",
            "Trust",
            "Twinhan",
            "Typhoon",
            "Ultron",
            "Videologic",
            "Videomate",
            "VisionPlus",
            "Vobis",
            "Vstream",
            "X3M Digital",
            "Yakumo",
            "Yamada",
            "Yuan"});
            this.wtxtKartenhersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtKartenhersteller.Name = "wtxtKartenhersteller";
            this.wtxtKartenhersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtKartenhersteller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 147;
            this.label1.Text = "Kartenhersteller:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtDVB_S);
            this.groupBox1.Controls.Add(this.cbtDVB_T);
            this.groupBox1.Controls.Add(this.cbtDVB_C);
            this.groupBox1.Controls.Add(this.cbtAnalog);
            this.groupBox1.Controls.Add(this.nudDVB_S);
            this.groupBox1.Controls.Add(this.nudDVB_T);
            this.groupBox1.Controls.Add(this.nudDVB_C);
            this.groupBox1.Controls.Add(this.nudAnalog);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 239);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empfänger";
            // 
            // cbtDVB_S
            // 
            this.cbtDVB_S.AutoSize = true;
            this.cbtDVB_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtDVB_S.Location = new System.Drawing.Point(17, 131);
            this.cbtDVB_S.Name = "cbtDVB_S";
            this.cbtDVB_S.Size = new System.Drawing.Size(78, 24);
            this.cbtDVB_S.TabIndex = 29;
            this.cbtDVB_S.TabStop = false;
            this.cbtDVB_S.Text = "DVB-S";
            this.cbtDVB_S.UseVisualStyleBackColor = true;
            this.cbtDVB_S.CheckedChanged += new System.EventHandler(this.cbtDVB_S_CheckedChanged);
            // 
            // cbtDVB_T
            // 
            this.cbtDVB_T.AutoSize = true;
            this.cbtDVB_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtDVB_T.Location = new System.Drawing.Point(17, 99);
            this.cbtDVB_T.Name = "cbtDVB_T";
            this.cbtDVB_T.Size = new System.Drawing.Size(76, 24);
            this.cbtDVB_T.TabIndex = 26;
            this.cbtDVB_T.TabStop = false;
            this.cbtDVB_T.Text = "DVB-T";
            this.cbtDVB_T.UseVisualStyleBackColor = true;
            this.cbtDVB_T.CheckedChanged += new System.EventHandler(this.cbtCVB_T_CheckedChanged);
            // 
            // cbtDVB_C
            // 
            this.cbtDVB_C.AutoSize = true;
            this.cbtDVB_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtDVB_C.Location = new System.Drawing.Point(17, 67);
            this.cbtDVB_C.Name = "cbtDVB_C";
            this.cbtDVB_C.Size = new System.Drawing.Size(78, 24);
            this.cbtDVB_C.TabIndex = 25;
            this.cbtDVB_C.TabStop = false;
            this.cbtDVB_C.Text = "DVB-C";
            this.cbtDVB_C.UseVisualStyleBackColor = true;
            this.cbtDVB_C.CheckedChanged += new System.EventHandler(this.cbtDVB_C_CheckedChanged);
            // 
            // cbtAnalog
            // 
            this.cbtAnalog.AutoSize = true;
            this.cbtAnalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtAnalog.Location = new System.Drawing.Point(17, 35);
            this.cbtAnalog.Name = "cbtAnalog";
            this.cbtAnalog.Size = new System.Drawing.Size(78, 24);
            this.cbtAnalog.TabIndex = 66;
            this.cbtAnalog.TabStop = false;
            this.cbtAnalog.Text = "Analog";
            this.cbtAnalog.UseVisualStyleBackColor = true;
            this.cbtAnalog.CheckedChanged += new System.EventHandler(this.cbtAnalog_CheckedChanged);
            // 
            // nudDVB_S
            // 
            this.nudDVB_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDVB_S.Location = new System.Drawing.Point(130, 130);
            this.nudDVB_S.Name = "nudDVB_S";
            this.nudDVB_S.Size = new System.Drawing.Size(57, 26);
            this.nudDVB_S.TabIndex = 3;
            this.nudDVB_S.ValueChanged += new System.EventHandler(this.nudDVB_S_ValueChanged);
            // 
            // nudDVB_T
            // 
            this.nudDVB_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDVB_T.Location = new System.Drawing.Point(130, 98);
            this.nudDVB_T.Name = "nudDVB_T";
            this.nudDVB_T.Size = new System.Drawing.Size(57, 26);
            this.nudDVB_T.TabIndex = 2;
            this.nudDVB_T.ValueChanged += new System.EventHandler(this.nudCVB_T_ValueChanged);
            // 
            // nudDVB_C
            // 
            this.nudDVB_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDVB_C.Location = new System.Drawing.Point(130, 66);
            this.nudDVB_C.Name = "nudDVB_C";
            this.nudDVB_C.Size = new System.Drawing.Size(57, 26);
            this.nudDVB_C.TabIndex = 1;
            this.nudDVB_C.ValueChanged += new System.EventHandler(this.nudDVB_C_ValueChanged);
            // 
            // nudAnalog
            // 
            this.nudAnalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnalog.Location = new System.Drawing.Point(130, 34);
            this.nudAnalog.Name = "nudAnalog";
            this.nudAnalog.Size = new System.Drawing.Size(57, 26);
            this.nudAnalog.TabIndex = 0;
            this.nudAnalog.ValueChanged += new System.EventHandler(this.nudAnalog_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtCinch);
            this.groupBox2.Controls.Add(this.cbtSVideo);
            this.groupBox2.Controls.Add(this.cbtScart);
            this.groupBox2.Controls.Add(this.cbtHDMI);
            this.groupBox2.Controls.Add(this.cbtODT);
            this.groupBox2.Controls.Add(this.cbtKlinke);
            this.groupBox2.Controls.Add(this.nudCinch);
            this.groupBox2.Controls.Add(this.nudSVideo);
            this.groupBox2.Controls.Add(this.nudScart);
            this.groupBox2.Controls.Add(this.nudHDMI);
            this.groupBox2.Controls.Add(this.nudODT);
            this.groupBox2.Controls.Add(this.nudKlinke);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(287, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Externe Schnittstellen";
            // 
            // cbtCinch
            // 
            this.cbtCinch.AutoSize = true;
            this.cbtCinch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtCinch.Location = new System.Drawing.Point(17, 195);
            this.cbtCinch.Name = "cbtCinch";
            this.cbtCinch.Size = new System.Drawing.Size(68, 24);
            this.cbtCinch.TabIndex = 31;
            this.cbtCinch.TabStop = false;
            this.cbtCinch.Text = "Cinch";
            this.cbtCinch.UseVisualStyleBackColor = true;
            this.cbtCinch.CheckedChanged += new System.EventHandler(this.cbtCinch_CheckedChanged);
            // 
            // cbtSVideo
            // 
            this.cbtSVideo.AutoSize = true;
            this.cbtSVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtSVideo.Location = new System.Drawing.Point(17, 163);
            this.cbtSVideo.Name = "cbtSVideo";
            this.cbtSVideo.Size = new System.Drawing.Size(85, 24);
            this.cbtSVideo.TabIndex = 30;
            this.cbtSVideo.TabStop = false;
            this.cbtSVideo.Text = "S-Video";
            this.cbtSVideo.UseVisualStyleBackColor = true;
            this.cbtSVideo.CheckedChanged += new System.EventHandler(this.cbtSVideo_CheckedChanged);
            // 
            // cbtScart
            // 
            this.cbtScart.AutoSize = true;
            this.cbtScart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtScart.Location = new System.Drawing.Point(17, 131);
            this.cbtScart.Name = "cbtScart";
            this.cbtScart.Size = new System.Drawing.Size(66, 24);
            this.cbtScart.TabIndex = 29;
            this.cbtScart.TabStop = false;
            this.cbtScart.Text = "Scart";
            this.cbtScart.UseVisualStyleBackColor = true;
            this.cbtScart.CheckedChanged += new System.EventHandler(this.cbtScart_CheckedChanged);
            // 
            // cbtHDMI
            // 
            this.cbtHDMI.AutoSize = true;
            this.cbtHDMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtHDMI.Location = new System.Drawing.Point(17, 99);
            this.cbtHDMI.Name = "cbtHDMI";
            this.cbtHDMI.Size = new System.Drawing.Size(70, 24);
            this.cbtHDMI.TabIndex = 26;
            this.cbtHDMI.TabStop = false;
            this.cbtHDMI.Text = "HDMI";
            this.cbtHDMI.UseVisualStyleBackColor = true;
            this.cbtHDMI.CheckedChanged += new System.EventHandler(this.cbtHDMI_CheckedChanged);
            // 
            // cbtODT
            // 
            this.cbtODT.AutoSize = true;
            this.cbtODT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtODT.Location = new System.Drawing.Point(17, 67);
            this.cbtODT.Name = "cbtODT";
            this.cbtODT.Size = new System.Drawing.Size(61, 24);
            this.cbtODT.TabIndex = 25;
            this.cbtODT.TabStop = false;
            this.cbtODT.Text = "ODT";
            this.cbtODT.UseVisualStyleBackColor = true;
            this.cbtODT.CheckedChanged += new System.EventHandler(this.cbtODT_CheckedChanged);
            // 
            // cbtKlinke
            // 
            this.cbtKlinke.AutoSize = true;
            this.cbtKlinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtKlinke.Location = new System.Drawing.Point(17, 35);
            this.cbtKlinke.Name = "cbtKlinke";
            this.cbtKlinke.Size = new System.Drawing.Size(70, 24);
            this.cbtKlinke.TabIndex = 66;
            this.cbtKlinke.TabStop = false;
            this.cbtKlinke.Text = "Klinke";
            this.cbtKlinke.UseVisualStyleBackColor = true;
            this.cbtKlinke.CheckedChanged += new System.EventHandler(this.cbtKlinke_CheckedChanged);
            // 
            // nudCinch
            // 
            this.nudCinch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCinch.Location = new System.Drawing.Point(130, 194);
            this.nudCinch.Name = "nudCinch";
            this.nudCinch.Size = new System.Drawing.Size(57, 26);
            this.nudCinch.TabIndex = 5;
            this.nudCinch.ValueChanged += new System.EventHandler(this.nudCinch_ValueChanged);
            // 
            // nudSVideo
            // 
            this.nudSVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSVideo.Location = new System.Drawing.Point(130, 162);
            this.nudSVideo.Name = "nudSVideo";
            this.nudSVideo.Size = new System.Drawing.Size(57, 26);
            this.nudSVideo.TabIndex = 4;
            this.nudSVideo.ValueChanged += new System.EventHandler(this.nudSVideo_ValueChanged);
            // 
            // nudScart
            // 
            this.nudScart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudScart.Location = new System.Drawing.Point(130, 130);
            this.nudScart.Name = "nudScart";
            this.nudScart.Size = new System.Drawing.Size(57, 26);
            this.nudScart.TabIndex = 3;
            this.nudScart.ValueChanged += new System.EventHandler(this.nudScart_ValueChanged);
            // 
            // nudHDMI
            // 
            this.nudHDMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHDMI.Location = new System.Drawing.Point(130, 98);
            this.nudHDMI.Name = "nudHDMI";
            this.nudHDMI.Size = new System.Drawing.Size(57, 26);
            this.nudHDMI.TabIndex = 2;
            this.nudHDMI.ValueChanged += new System.EventHandler(this.nudHDMI_ValueChanged);
            // 
            // nudODT
            // 
            this.nudODT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudODT.Location = new System.Drawing.Point(130, 66);
            this.nudODT.Name = "nudODT";
            this.nudODT.Size = new System.Drawing.Size(57, 26);
            this.nudODT.TabIndex = 1;
            this.nudODT.ValueChanged += new System.EventHandler(this.nudODT_ValueChanged);
            // 
            // nudKlinke
            // 
            this.nudKlinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKlinke.Location = new System.Drawing.Point(130, 34);
            this.nudKlinke.Name = "nudKlinke";
            this.nudKlinke.Size = new System.Drawing.Size(57, 26);
            this.nudKlinke.TabIndex = 0;
            this.nudKlinke.ValueChanged += new System.EventHandler(this.nudKlinke_ValueChanged);
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
            this.wtxtZustand.Size = new System.Drawing.Size(146, 28);
            this.wtxtZustand.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 153;
            this.label4.Text = "Zustand:";
            // 
            // TVKarte_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wtxtAnschluss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wtxtModell);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wtxtKartenhersteller);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TVKarte_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TVKarte_Imput";
            this.Load += new System.EventHandler(this.TVKarte_Imput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDVB_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDVB_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDVB_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCinch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHDMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudODT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKlinke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox wtxtAnschluss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox wtxtModell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wtxtKartenhersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbtDVB_S;
        private System.Windows.Forms.CheckBox cbtDVB_T;
        private System.Windows.Forms.CheckBox cbtDVB_C;
        private System.Windows.Forms.CheckBox cbtAnalog;
        private System.Windows.Forms.NumericUpDown nudDVB_S;
        private System.Windows.Forms.NumericUpDown nudDVB_T;
        private System.Windows.Forms.NumericUpDown nudDVB_C;
        private System.Windows.Forms.NumericUpDown nudAnalog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtCinch;
        private System.Windows.Forms.CheckBox cbtSVideo;
        private System.Windows.Forms.CheckBox cbtScart;
        private System.Windows.Forms.CheckBox cbtHDMI;
        private System.Windows.Forms.CheckBox cbtODT;
        private System.Windows.Forms.CheckBox cbtKlinke;
        private System.Windows.Forms.NumericUpDown nudCinch;
        private System.Windows.Forms.NumericUpDown nudSVideo;
        private System.Windows.Forms.NumericUpDown nudScart;
        private System.Windows.Forms.NumericUpDown nudHDMI;
        private System.Windows.Forms.NumericUpDown nudODT;
        private System.Windows.Forms.NumericUpDown nudKlinke;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label4;
    }
}