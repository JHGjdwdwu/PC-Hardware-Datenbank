namespace PC_Hardware_Datenbank
{
    partial class HDD_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDD_Imput));
            this.wtxtStromversorgung = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wtxtAnschluss = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtID = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wtxtFormfaktor = new System.Windows.Forms.ComboBox();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wtxtGrosse = new System.Windows.Forms.ComboBox();
            this.wtxtBauart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wtxtStromverbrauch = new System.Windows.Forms.ComboBox();
            this.wtxtNAND = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wtxtController = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.wtxtMaxLesen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.wtxtMaxSchreib = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.wtxtTempera = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.wtxtStoss = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtStromversorgung
            // 
            this.wtxtStromversorgung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtStromversorgung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtStromversorgung.FormattingEnabled = true;
            this.wtxtStromversorgung.Items.AddRange(new object[] {
            "Molex-8981",
            "SATA",
            "Molex-8981 & SATA"});
            this.wtxtStromversorgung.Location = new System.Drawing.Point(241, 211);
            this.wtxtStromversorgung.Name = "wtxtStromversorgung";
            this.wtxtStromversorgung.Size = new System.Drawing.Size(146, 28);
            this.wtxtStromversorgung.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 130;
            this.label9.Text = "Stromversorgung:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 129;
            this.label8.Text = "Stromverbrauch:";
            // 
            // wtxtAnschluss
            // 
            this.wtxtAnschluss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtAnschluss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtAnschluss.FormattingEnabled = true;
            this.wtxtAnschluss.Items.AddRange(new object[] {
            "IDE",
            "SATA",
            "SCSI",
            "PCIe",
            "M.2"});
            this.wtxtAnschluss.Location = new System.Drawing.Point(241, 135);
            this.wtxtAnschluss.Name = "wtxtAnschluss";
            this.wtxtAnschluss.Size = new System.Drawing.Size(146, 28);
            this.wtxtAnschluss.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(237, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 128;
            this.label7.Text = "Anschlüsse:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtHersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "HGST",
            "Seagate Technology",
            "Toshiba",
            "Western Digital",
            "Samsung Electronics",
            "Conner Peripherals",
            "Conner Technologies",
            "Control Data Corporation",
            "Digital Equipment Corporation",
            "ExcelStor Technology",
            "Fujitsu",
            "HP Inc.",
            "IBM",
            "LaCie",
            "LenovoEMC",
            "Maxtor Corporation",
            "Micropolis",
            "MiniScribe",
            "NEC Corporation",
            "Quantum Corporation",
            "Shugart Associates",
            "Sony",
            "SyQuest"});
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Hersteller:";
            // 
            // wtxtID
            // 
            this.wtxtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtID.FormattingEnabled = true;
            this.wtxtID.Location = new System.Drawing.Point(241, 61);
            this.wtxtID.Name = "wtxtID";
            this.wtxtID.Size = new System.Drawing.Size(146, 28);
            this.wtxtID.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 126;
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
            this.pcmdMainbord.TabIndex = 125;
            this.pcmdMainbord.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(237, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 124;
            this.label5.Text = "Bezeichnung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Kapazität (GB):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 134;
            this.label3.Text = "Formfaktor:";
            // 
            // wtxtFormfaktor
            // 
            this.wtxtFormfaktor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtFormfaktor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtFormfaktor.FormattingEnabled = true;
            this.wtxtFormfaktor.Items.AddRange(new object[] {
            "3,5",
            "2,5"});
            this.wtxtFormfaktor.Location = new System.Drawing.Point(443, 211);
            this.wtxtFormfaktor.Name = "wtxtFormfaktor";
            this.wtxtFormfaktor.Size = new System.Drawing.Size(146, 28);
            this.wtxtFormfaktor.TabIndex = 8;
            // 
            // wtxtZustand
            // 
            this.wtxtZustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtZustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtZustand.FormattingEnabled = true;
            this.wtxtZustand.Items.AddRange(new object[] {
            "verbaut",
            "auf Lager"});
            this.wtxtZustand.Location = new System.Drawing.Point(443, 61);
            this.wtxtZustand.Name = "wtxtZustand";
            this.wtxtZustand.Size = new System.Drawing.Size(146, 28);
            this.wtxtZustand.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(439, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 136;
            this.label4.Text = "Zustand:";
            // 
            // wtxtGrosse
            // 
            this.wtxtGrosse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtGrosse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtGrosse.FormattingEnabled = true;
            this.wtxtGrosse.Items.AddRange(new object[] {
            "40 GB",
            "60 GB",
            "80 GB",
            "100 GB",
            "120 GB",
            "160 GB",
            "180 GB",
            "200 GB",
            "320 GB",
            "500 GB",
            "750 GB",
            "1 TB",
            "1,5 TB",
            "2 TB",
            "4 TB",
            "6 TB",
            "8 TB",
            "10 TB",
            "12 TB",
            "14 TB ",
            "16 TB",
            "18 TB"});
            this.wtxtGrosse.Location = new System.Drawing.Point(34, 135);
            this.wtxtGrosse.Name = "wtxtGrosse";
            this.wtxtGrosse.Size = new System.Drawing.Size(146, 28);
            this.wtxtGrosse.TabIndex = 3;
            // 
            // wtxtBauart
            // 
            this.wtxtBauart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtBauart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtBauart.FormattingEnabled = true;
            this.wtxtBauart.Items.AddRange(new object[] {
            "HDD",
            "SSD",
            "SSHD"});
            this.wtxtBauart.Location = new System.Drawing.Point(443, 135);
            this.wtxtBauart.Name = "wtxtBauart";
            this.wtxtBauart.Size = new System.Drawing.Size(146, 28);
            this.wtxtBauart.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(439, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 138;
            this.label6.Text = "Bauart:";
            // 
            // wtxtStromverbrauch
            // 
            this.wtxtStromverbrauch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtStromverbrauch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtStromverbrauch.FormattingEnabled = true;
            this.wtxtStromverbrauch.Items.AddRange(new object[] {
            "verbaut",
            "auf Lager"});
            this.wtxtStromverbrauch.Location = new System.Drawing.Point(34, 211);
            this.wtxtStromverbrauch.Name = "wtxtStromverbrauch";
            this.wtxtStromverbrauch.Size = new System.Drawing.Size(146, 28);
            this.wtxtStromverbrauch.TabIndex = 6;
            // 
            // wtxtNAND
            // 
            this.wtxtNAND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtNAND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtNAND.FormattingEnabled = true;
            this.wtxtNAND.Location = new System.Drawing.Point(34, 285);
            this.wtxtNAND.Name = "wtxtNAND";
            this.wtxtNAND.Size = new System.Drawing.Size(146, 28);
            this.wtxtNAND.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 141;
            this.label10.Text = "NAND Flash:";
            // 
            // wtxtController
            // 
            this.wtxtController.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtController.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtController.FormattingEnabled = true;
            this.wtxtController.Location = new System.Drawing.Point(241, 285);
            this.wtxtController.Name = "wtxtController";
            this.wtxtController.Size = new System.Drawing.Size(146, 28);
            this.wtxtController.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 143;
            this.label11.Text = "Controller:";
            // 
            // wtxtMaxLesen
            // 
            this.wtxtMaxLesen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtMaxLesen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtMaxLesen.FormattingEnabled = true;
            this.wtxtMaxLesen.Location = new System.Drawing.Point(443, 285);
            this.wtxtMaxLesen.Name = "wtxtMaxLesen";
            this.wtxtMaxLesen.Size = new System.Drawing.Size(146, 28);
            this.wtxtMaxLesen.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 145;
            this.label12.Text = "max lesen:";
            // 
            // wtxtMaxSchreib
            // 
            this.wtxtMaxSchreib.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtMaxSchreib.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtMaxSchreib.FormattingEnabled = true;
            this.wtxtMaxSchreib.Location = new System.Drawing.Point(34, 361);
            this.wtxtMaxSchreib.Name = "wtxtMaxSchreib";
            this.wtxtMaxSchreib.Size = new System.Drawing.Size(146, 28);
            this.wtxtMaxSchreib.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 147;
            this.label13.Text = "max schreiben:";
            // 
            // wtxtTempera
            // 
            this.wtxtTempera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtTempera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtTempera.FormattingEnabled = true;
            this.wtxtTempera.Location = new System.Drawing.Point(241, 361);
            this.wtxtTempera.Name = "wtxtTempera";
            this.wtxtTempera.Size = new System.Drawing.Size(146, 28);
            this.wtxtTempera.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 20);
            this.label14.TabIndex = 149;
            this.label14.Text = "Betriebstemperatur:";
            // 
            // wtxtStoss
            // 
            this.wtxtStoss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtStoss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtStoss.FormattingEnabled = true;
            this.wtxtStoss.Location = new System.Drawing.Point(443, 361);
            this.wtxtStoss.Name = "wtxtStoss";
            this.wtxtStoss.Size = new System.Drawing.Size(146, 28);
            this.wtxtStoss.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(439, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 20);
            this.label15.TabIndex = 151;
            this.label15.Text = "Stoßfestigkeit:";
            // 
            // HDD_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtStoss);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.wtxtTempera);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.wtxtMaxSchreib);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.wtxtMaxLesen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.wtxtController);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wtxtNAND);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wtxtStromverbrauch);
            this.Controls.Add(this.wtxtBauart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wtxtGrosse);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wtxtFormfaktor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wtxtStromversorgung);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wtxtAnschluss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wtxtID);
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
            this.Name = "HDD_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Festplatten";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox wtxtStromversorgung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox wtxtAnschluss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox wtxtFormfaktor;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wtxtGrosse;
        private System.Windows.Forms.ComboBox wtxtBauart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox wtxtStromverbrauch;
        private System.Windows.Forms.ComboBox wtxtNAND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox wtxtController;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox wtxtMaxLesen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox wtxtMaxSchreib;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox wtxtTempera;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox wtxtStoss;
        private System.Windows.Forms.Label label15;
    }
}