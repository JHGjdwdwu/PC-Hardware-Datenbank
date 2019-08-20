namespace PC_Hardware_Datenbank
{
    partial class RAM_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RAM_Imput));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wtxtSlot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtTacktrate = new System.Windows.Forms.ComboBox();
            this.wtxtGrosse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wtxtChiphersteller = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wtxtID = new System.Windows.Forms.ComboBox();
            this.wtxtModultyp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.wtxtBetriebstemperatur = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wtxtLatenz = new System.Windows.Forms.ComboBox();
            this.wtxtBeleuchtung = new System.Windows.Forms.ComboBox();
            this.lbl121 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
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
            this.cmdQR.TabIndex = 14;
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
            this.cmdBildEinfugen.TabIndex = 11;
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
            this.cmdClear.TabIndex = 13;
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
            this.cmdSpeichern.TabIndex = 12;
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
            this.cmdBeenden.TabIndex = 15;
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
            this.pcmdMainbord.TabIndex = 73;
            this.pcmdMainbord.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Taktrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(30, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Größe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(245, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Bezeichnung:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtHersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "Corsair",
            "Kingston Technology",
            "MDT",
            "OCZ",
            "A-Data",
            "Samsung"});
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Hersteller:";
            // 
            // wtxtSlot
            // 
            this.wtxtSlot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtSlot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtSlot.FormattingEnabled = true;
            this.wtxtSlot.Items.AddRange(new object[] {
            "SD-RAM",
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4",
            "DDR5"});
            this.wtxtSlot.Location = new System.Drawing.Point(249, 135);
            this.wtxtSlot.Name = "wtxtSlot";
            this.wtxtSlot.Size = new System.Drawing.Size(146, 28);
            this.wtxtSlot.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(245, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Slot Typ:";
            // 
            // wtxtTacktrate
            // 
            this.wtxtTacktrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtTacktrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtTacktrate.FormattingEnabled = true;
            this.wtxtTacktrate.Items.AddRange(new object[] {
            "400MHz",
            "800MHz",
            "1600MHz",
            "2133MHz",
            "2400MHz",
            "2666MHz",
            "3000MHz",
            "3200MHz",
            "3600MHz",
            "4133MHz"});
            this.wtxtTacktrate.Location = new System.Drawing.Point(34, 283);
            this.wtxtTacktrate.Name = "wtxtTacktrate";
            this.wtxtTacktrate.Size = new System.Drawing.Size(146, 28);
            this.wtxtTacktrate.TabIndex = 6;
            // 
            // wtxtGrosse
            // 
            this.wtxtGrosse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtGrosse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtGrosse.FormattingEnabled = true;
            this.wtxtGrosse.Items.AddRange(new object[] {
            "64MB",
            "128MB",
            "512MB",
            "1GB",
            "2GB",
            "4GB",
            "8GB",
            "16GB"});
            this.wtxtGrosse.Location = new System.Drawing.Point(34, 209);
            this.wtxtGrosse.Name = "wtxtGrosse";
            this.wtxtGrosse.Size = new System.Drawing.Size(146, 28);
            this.wtxtGrosse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Latenz:";
            // 
            // wtxtZustand
            // 
            this.wtxtZustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtZustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtZustand.FormattingEnabled = true;
            this.wtxtZustand.Items.AddRange(new object[] {
            "verbaut",
            "auf Lager"});
            this.wtxtZustand.Location = new System.Drawing.Point(34, 135);
            this.wtxtZustand.Name = "wtxtZustand";
            this.wtxtZustand.Size = new System.Drawing.Size(146, 28);
            this.wtxtZustand.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(30, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Zustand:";
            // 
            // wtxtChiphersteller
            // 
            this.wtxtChiphersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtChiphersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtChiphersteller.FormattingEnabled = true;
            this.wtxtChiphersteller.Items.AddRange(new object[] {
            "Nanya",
            "Hynix Semiconductor",
            "Micron Technology",
            "Promos",
            "Samsung",
            "Toshiba",
            "Winbond",
            "Etron"});
            this.wtxtChiphersteller.Location = new System.Drawing.Point(34, 357);
            this.wtxtChiphersteller.Name = "wtxtChiphersteller";
            this.wtxtChiphersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtChiphersteller.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Chiphersteller:";
            // 
            // wtxtID
            // 
            this.wtxtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtID.FormattingEnabled = true;
            this.wtxtID.Location = new System.Drawing.Point(249, 63);
            this.wtxtID.Name = "wtxtID";
            this.wtxtID.Size = new System.Drawing.Size(146, 28);
            this.wtxtID.TabIndex = 1;
            // 
            // wtxtModultyp
            // 
            this.wtxtModultyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtModultyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtModultyp.FormattingEnabled = true;
            this.wtxtModultyp.Items.AddRange(new object[] {
            "U-DIMM",
            "SO-DIMM",
            "ECC SO-DIMM",
            "ECC U-DIMM",
            "R-DIMM"});
            this.wtxtModultyp.Location = new System.Drawing.Point(249, 209);
            this.wtxtModultyp.Name = "wtxtModultyp";
            this.wtxtModultyp.Size = new System.Drawing.Size(146, 28);
            this.wtxtModultyp.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Modultyp:";
            // 
            // wtxtBetriebstemperatur
            // 
            this.wtxtBetriebstemperatur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtBetriebstemperatur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtBetriebstemperatur.FormattingEnabled = true;
            this.wtxtBetriebstemperatur.Location = new System.Drawing.Point(249, 357);
            this.wtxtBetriebstemperatur.Name = "wtxtBetriebstemperatur";
            this.wtxtBetriebstemperatur.Size = new System.Drawing.Size(146, 28);
            this.wtxtBetriebstemperatur.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "Betriebstemperatur:";
            // 
            // wtxtLatenz
            // 
            this.wtxtLatenz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtLatenz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtLatenz.FormattingEnabled = true;
            this.wtxtLatenz.Location = new System.Drawing.Point(249, 283);
            this.wtxtLatenz.Name = "wtxtLatenz";
            this.wtxtLatenz.Size = new System.Drawing.Size(146, 28);
            this.wtxtLatenz.TabIndex = 7;
            // 
            // wtxtBeleuchtung
            // 
            this.wtxtBeleuchtung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtBeleuchtung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtBeleuchtung.FormattingEnabled = true;
            this.wtxtBeleuchtung.Items.AddRange(new object[] {
            "Ja",
            "Nein"});
            this.wtxtBeleuchtung.Location = new System.Drawing.Point(34, 431);
            this.wtxtBeleuchtung.Name = "wtxtBeleuchtung";
            this.wtxtBeleuchtung.Size = new System.Drawing.Size(146, 28);
            this.wtxtBeleuchtung.TabIndex = 10;
            // 
            // lbl121
            // 
            this.lbl121.AutoSize = true;
            this.lbl121.Location = new System.Drawing.Point(30, 410);
            this.lbl121.Name = "lbl121";
            this.lbl121.Size = new System.Drawing.Size(103, 20);
            this.lbl121.TabIndex = 88;
            this.lbl121.Text = "Beleuchtung:";
            // 
            // RAM_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtBeleuchtung);
            this.Controls.Add(this.lbl121);
            this.Controls.Add(this.wtxtLatenz);
            this.Controls.Add(this.wtxtBetriebstemperatur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wtxtModultyp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wtxtID);
            this.Controls.Add(this.wtxtChiphersteller);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wtxtGrosse);
            this.Controls.Add(this.wtxtTacktrate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxtSlot);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RAM_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbeitsspeicher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wtxtSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtTacktrate;
        private System.Windows.Forms.ComboBox wtxtGrosse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox wtxtChiphersteller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox wtxtID;
        private System.Windows.Forms.ComboBox wtxtModultyp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox wtxtBetriebstemperatur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox wtxtLatenz;
        private System.Windows.Forms.ComboBox wtxtBeleuchtung;
        private System.Windows.Forms.Label lbl121;
    }
}