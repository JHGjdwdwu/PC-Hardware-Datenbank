namespace PC_Hardware_Datenbank
{
    partial class Kabel_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kabel_Imput));
            this.nudLange = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.wtxtKabelendeA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.wtxtKabelendeB = new System.Windows.Forms.ComboBox();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtSchaltbar = new System.Windows.Forms.CheckBox();
            this.wtxtZustand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLange
            // 
            this.nudLange.DecimalPlaces = 2;
            this.nudLange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLange.Location = new System.Drawing.Point(251, 155);
            this.nudLange.Name = "nudLange";
            this.nudLange.Size = new System.Drawing.Size(109, 26);
            this.nudLange.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(362, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 181;
            this.label5.Text = "Kabelende:";
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.BackColor = System.Drawing.Color.OrangeRed;
            this.cmdBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBeenden.Location = new System.Drawing.Point(963, 571);
            this.cmdBeenden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(150, 35);
            this.cmdBeenden.TabIndex = 9;
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
            this.pcmdMainbord.TabIndex = 182;
            this.pcmdMainbord.TabStop = false;
            // 
            // wtxtKabelendeA
            // 
            this.wtxtKabelendeA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtKabelendeA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtKabelendeA.FormattingEnabled = true;
            this.wtxtKabelendeA.Items.AddRange(new object[] {
            "Kaltgerätestecker",
            "kaltgerätekupplung",
            "RJ11",
            "RJ45",
            "Klinke",
            "VGA Stecker",
            "VGA Kupplung",
            "DVI Stecker",
            "DVI Kupplung",
            "HDMI Stecker",
            "HDMI Kupplung",
            "Displayport Stecker",
            "Displayport Kupplung",
            "Chinch Stecker",
            "Chinch Kupplung",
            "USB-A Stecker",
            "USB-A Kupplung",
            "USB-Mini-A Stecker",
            "USB-Mini-A Kupplung",
            "USB-B Stecker",
            "USB-B Kupplung",
            "USB-Mini-B Stecker",
            "USB-Mini-B Kupplung",
            "USB-Micro-A Stecker",
            "USB-Micro-A Kupplung",
            "IDE Stecker",
            "IDE Kupplung",
            "SATA",
            "Floppy",
            "F-Stecker",
            "Coax",
            "BNC Stecker",
            "BNC Kupplung",
            "SCSI",
            "3-Pin",
            "Schukostecker",
            "Eurostecker",
            "Mehrfachsteckdose 2-fach",
            "Mehrfachsteckdose 3-fach",
            "Mehrfachsteckdose 4-fach",
            "Mehrfachsteckdose 6-fach"});
            this.wtxtKabelendeA.Location = new System.Drawing.Point(40, 154);
            this.wtxtKabelendeA.Name = "wtxtKabelendeA";
            this.wtxtKabelendeA.Size = new System.Drawing.Size(205, 28);
            this.wtxtKabelendeA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 180;
            this.label1.Text = "Kabelende:";
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.BackColor = System.Drawing.Color.Lime;
            this.cmdSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSpeichern.Location = new System.Drawing.Point(13, 571);
            this.cmdSpeichern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(150, 35);
            this.cmdSpeichern.TabIndex = 6;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = false;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 183;
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
            this.cmdQR.TabIndex = 8;
            this.cmdQR.Text = "QR-Code Drucken";
            this.cmdQR.UseVisualStyleBackColor = false;
            this.cmdQR.Click += new System.EventHandler(this.cmdQR_Click);
            // 
            // wtxtKabelendeB
            // 
            this.wtxtKabelendeB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtKabelendeB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtKabelendeB.FormattingEnabled = true;
            this.wtxtKabelendeB.Items.AddRange(new object[] {
            "Kaltgerätestecker",
            "kaltgerätekupplung",
            "RJ11",
            "RJ45",
            "Klinke",
            "VGA Stecker",
            "VGA Kupplung",
            "DVI Stecker",
            "DVI Kupplung",
            "HDMI Stecker",
            "HDMI Kupplung",
            "Displayport Stecker",
            "Displayport Kupplung",
            "Chinch Stecker",
            "Chinch Kupplung",
            "USB-A Stecker",
            "USB-A Kupplung",
            "USB-Mini-A Stecker",
            "USB-Mini-A Kupplung",
            "USB-B Stecker",
            "USB-B Kupplung",
            "USB-Mini-B Stecker",
            "USB-Mini-B Kupplung",
            "USB-Micro-A Stecker",
            "USB-Micro-A Kupplung",
            "IDE Stecker",
            "IDE Kupplung",
            "SATA",
            "Floppy",
            "F-Stecker",
            "Coax",
            "BNC Stecker",
            "BNC Kupplung",
            "SCSI",
            "3-Pin",
            "Schukostecker",
            "Eurostecker",
            "Mehrfachsteckdose 2-fach",
            "Mehrfachsteckdose 3-fach",
            "Mehrfachsteckdose 4-fach",
            "Mehrfachsteckdose 6-fach"});
            this.wtxtKabelendeB.Location = new System.Drawing.Point(366, 153);
            this.wtxtKabelendeB.Name = "wtxtKabelendeB";
            this.wtxtKabelendeB.Size = new System.Drawing.Size(205, 28);
            this.wtxtKabelendeB.TabIndex = 3;
            // 
            // cmdBildEinfugen
            // 
            this.cmdBildEinfugen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdBildEinfugen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBildEinfugen.Location = new System.Drawing.Point(827, 474);
            this.cmdBildEinfugen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBildEinfugen.Name = "cmdBildEinfugen";
            this.cmdBildEinfugen.Size = new System.Drawing.Size(150, 35);
            this.cmdBildEinfugen.TabIndex = 5;
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
            this.cmdClear.TabIndex = 7;
            this.cmdClear.Text = "Zurücksetzen";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(247, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 184;
            this.label2.Text = "Länge (m):";
            // 
            // cbtSchaltbar
            // 
            this.cbtSchaltbar.AutoSize = true;
            this.cbtSchaltbar.Location = new System.Drawing.Point(251, 208);
            this.cbtSchaltbar.Name = "cbtSchaltbar";
            this.cbtSchaltbar.Size = new System.Drawing.Size(96, 24);
            this.cbtSchaltbar.TabIndex = 4;
            this.cbtSchaltbar.Text = "Schaltbar";
            this.cbtSchaltbar.UseVisualStyleBackColor = true;
            // 
            // wtxtZustand
            // 
            this.wtxtZustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtZustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtZustand.FormattingEnabled = true;
            this.wtxtZustand.Items.AddRange(new object[] {
            "verbaut",
            "auf Lager"});
            this.wtxtZustand.Location = new System.Drawing.Point(40, 81);
            this.wtxtZustand.Name = "wtxtZustand";
            this.wtxtZustand.Size = new System.Drawing.Size(146, 28);
            this.wtxtZustand.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(36, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 187;
            this.label4.Text = "Zustand:";
            // 
            // Kabel_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtZustand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbtSchaltbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.wtxtKabelendeA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.wtxtKabelendeB);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.nudLange);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kabel_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kabel";
            ((System.ComponentModel.ISupportInitialize)(this.nudLange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudLange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.ComboBox wtxtKabelendeA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.ComboBox wtxtKabelendeB;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbtSchaltbar;
        private System.Windows.Forms.ComboBox wtxtZustand;
        private System.Windows.Forms.Label label4;
    }
}