namespace PC_Hardware_Datenbank
{
    partial class Laufwerk_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laufwerk_Imput));
            this.wtxtID = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.lblTyp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtSchnittstelle = new System.Windows.Forms.ComboBox();
            this.wtxtBauart = new System.Windows.Forms.ComboBox();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wtxtArt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wtxtCache = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wtxtMaxSchreiben = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wtxtMaxLesen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wtxtBrenner = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtID
            // 
            this.wtxtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtID.FormattingEnabled = true;
            this.wtxtID.Location = new System.Drawing.Point(249, 61);
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
            this.pictureBox1.TabIndex = 75;
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
            this.cmdQR.TabIndex = 13;
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
            this.cmdBildEinfugen.TabIndex = 10;
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
            this.cmdClear.TabIndex = 12;
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
            this.cmdSpeichern.TabIndex = 11;
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
            this.cmdBeenden.TabIndex = 14;
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
            this.pcmdMainbord.TabIndex = 74;
            this.pcmdMainbord.TabStop = false;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.ForeColor = System.Drawing.Color.Red;
            this.lblTyp.Location = new System.Drawing.Point(245, 186);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(61, 20);
            this.lblTyp.TabIndex = 68;
            this.lblTyp.Text = "Bauart:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(245, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Schnittstelle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(245, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Bezeichnung:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtHersteller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "Acer",
            "Actima",
            "Afreey",
            "Aopen",
            "Artec",
            "Asus",
            "ASUS Computer",
            "BenQ",
            "BestRunner",
            "BIGtec",
            "Creative",
            "CyberDrive",
            "DEEPOW",
            "Dell",
            "Delta Solution",
            "DOY",
            "Firstcom",
            "Fujitsu-Siemens",
            "Hercules",
            "Hitachi",
            "iAmotus",
            "IBM",
            "LaCie",
            "LEADSTAR",
            "LG",
            "LiteOn",
            "Lite-On IT",
            "Lonedo",
            "Matsushita",
            "Memorex",
            "Mitsumi",
            "MSI",
            "Multiport",
            "NEC",
            "Panasonic",
            "Philips",
            "Pioneer",
            "Plextor",
            "Salcar",
            "Samsung",
            "Shuttle",
            "SONOKA",
            "Sony",
            "Sony NEC Optiarc",
            "Sunreal",
            "Teac",
            "Toshiba",
            "Trust",
            "Zacfton"});
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
            this.label1.TabIndex = 58;
            this.label1.Text = "Hersteller:";
            // 
            // wtxtSchnittstelle
            // 
            this.wtxtSchnittstelle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtSchnittstelle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtSchnittstelle.FormattingEnabled = true;
            this.wtxtSchnittstelle.Items.AddRange(new object[] {
            "BURG",
            "IDE",
            "SATA",
            "SCASI",
            "USB",
            "FireWire"});
            this.wtxtSchnittstelle.Location = new System.Drawing.Point(249, 135);
            this.wtxtSchnittstelle.Name = "wtxtSchnittstelle";
            this.wtxtSchnittstelle.Size = new System.Drawing.Size(146, 28);
            this.wtxtSchnittstelle.TabIndex = 3;
            // 
            // wtxtBauart
            // 
            this.wtxtBauart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtBauart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtBauart.FormattingEnabled = true;
            this.wtxtBauart.Items.AddRange(new object[] {
            "Desktop-PC",
            "Notbock"});
            this.wtxtBauart.Location = new System.Drawing.Point(249, 209);
            this.wtxtBauart.Name = "wtxtBauart";
            this.wtxtBauart.Size = new System.Drawing.Size(146, 28);
            this.wtxtBauart.TabIndex = 5;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Zustand:";
            // 
            // wtxtArt
            // 
            this.wtxtArt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtArt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtArt.FormattingEnabled = true;
            this.wtxtArt.Items.AddRange(new object[] {
            "Floppy",
            "CD",
            "DVD",
            "Blu-ray"});
            this.wtxtArt.Location = new System.Drawing.Point(34, 209);
            this.wtxtArt.Name = "wtxtArt";
            this.wtxtArt.Size = new System.Drawing.Size(146, 28);
            this.wtxtArt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(30, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Geräte Art:";
            // 
            // wtxtCache
            // 
            this.wtxtCache.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtCache.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtCache.FormattingEnabled = true;
            this.wtxtCache.Location = new System.Drawing.Point(249, 283);
            this.wtxtCache.Name = "wtxtCache";
            this.wtxtCache.Size = new System.Drawing.Size(146, 28);
            this.wtxtCache.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(245, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 121;
            this.label6.Text = "Cache:";
            // 
            // wtxtMaxSchreiben
            // 
            this.wtxtMaxSchreiben.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtMaxSchreiben.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtMaxSchreiben.FormattingEnabled = true;
            this.wtxtMaxSchreiben.Location = new System.Drawing.Point(249, 357);
            this.wtxtMaxSchreiben.Name = "wtxtMaxSchreiben";
            this.wtxtMaxSchreiben.Size = new System.Drawing.Size(146, 28);
            this.wtxtMaxSchreiben.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(245, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 123;
            this.label7.Text = "max schreiben";
            // 
            // wtxtMaxLesen
            // 
            this.wtxtMaxLesen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtMaxLesen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtMaxLesen.FormattingEnabled = true;
            this.wtxtMaxLesen.Location = new System.Drawing.Point(34, 357);
            this.wtxtMaxLesen.Name = "wtxtMaxLesen";
            this.wtxtMaxLesen.Size = new System.Drawing.Size(146, 28);
            this.wtxtMaxLesen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 125;
            this.label8.Text = "max lesen";
            // 
            // wtxtBrenner
            // 
            this.wtxtBrenner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtBrenner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtBrenner.FormattingEnabled = true;
            this.wtxtBrenner.Items.AddRange(new object[] {
            "Ja",
            "Nein"});
            this.wtxtBrenner.Location = new System.Drawing.Point(34, 283);
            this.wtxtBrenner.Name = "wtxtBrenner";
            this.wtxtBrenner.Size = new System.Drawing.Size(146, 28);
            this.wtxtBrenner.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(30, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 127;
            this.label9.Text = "Brenner:";
            // 
            // Laufwerk_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtBrenner);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wtxtMaxLesen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wtxtMaxSchreiben);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wtxtCache);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wtxtArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wtxtBauart);
            this.Controls.Add(this.wtxtSchnittstelle);
            this.Controls.Add(this.wtxtID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Laufwerk_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laufwerke";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wtxtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtSchnittstelle;
        private System.Windows.Forms.ComboBox wtxtBauart;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wtxtArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wtxtCache;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox wtxtMaxSchreiben;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox wtxtMaxLesen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox wtxtBrenner;
        private System.Windows.Forms.Label label9;
    }
}