namespace PC_Hardware_Datenbank
{
    partial class CPU_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU_Imput));
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.wtxtSockelAMD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.mtxtTaktrate = new System.Windows.Forms.MaskedTextBox();
            this.nudKerne = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCach1 = new System.Windows.Forms.NumericUpDown();
            this.nudCach2 = new System.Windows.Forms.NumericUpDown();
            this.nudCach3 = new System.Windows.Forms.NumericUpDown();
            this.nudCach4 = new System.Windows.Forms.NumericUpDown();
            this.wtxtSockelINTEL = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKerne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hersteller:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Items.AddRange(new object[] {
            "Intel",
            "AMD"});
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 0;
            this.wtxtHersteller.SelectedIndexChanged += new System.EventHandler(this.wtxtHersteller_SelectedIndexChanged);
            // 
            // wtxtSockelAMD
            // 
            this.wtxtSockelAMD.FormattingEnabled = true;
            this.wtxtSockelAMD.Items.AddRange(new object[] {
            "7",
            "Slot A",
            "A/462",
            "563",
            "754",
            "939",
            "940",
            "F/1207",
            "S1",
            "AM2",
            "AM2+",
            "AM3",
            "AM3+",
            "AM4",
            "FM1",
            "FM2",
            "FM2+",
            "TR4"});
            this.wtxtSockelAMD.Location = new System.Drawing.Point(34, 135);
            this.wtxtSockelAMD.Name = "wtxtSockelAMD";
            this.wtxtSockelAMD.Size = new System.Drawing.Size(146, 28);
            this.wtxtSockelAMD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sockel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Taktrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(245, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Typ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Anzahl Kerne:";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(249, 61);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(146, 26);
            this.txtTyp.TabIndex = 1;
            // 
            // mtxtTaktrate
            // 
            this.mtxtTaktrate.Location = new System.Drawing.Point(249, 135);
            this.mtxtTaktrate.Name = "mtxtTaktrate";
            this.mtxtTaktrate.Size = new System.Drawing.Size(146, 26);
            this.mtxtTaktrate.TabIndex = 3;
            // 
            // nudKerne
            // 
            this.nudKerne.Location = new System.Drawing.Point(34, 209);
            this.nudKerne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKerne.Name = "nudKerne";
            this.nudKerne.Size = new System.Drawing.Size(146, 26);
            this.nudKerne.TabIndex = 4;
            this.nudKerne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // cmdQR
            // 
            this.cmdQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQR.Location = new System.Drawing.Point(329, 571);
            this.cmdQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQR.Name = "cmdQR";
            this.cmdQR.Size = new System.Drawing.Size(171, 35);
            this.cmdQR.TabIndex = 12;
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
            this.cmdBildEinfugen.TabIndex = 9;
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
            this.cmdClear.TabIndex = 11;
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
            this.cmdSpeichern.TabIndex = 10;
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
            this.cmdBeenden.TabIndex = 13;
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
            this.pcmdMainbord.TabIndex = 40;
            this.pcmdMainbord.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Level1 Cache:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Level2 Cache:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Level3 Cache:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Level4 Cache:";
            // 
            // nudCach1
            // 
            this.nudCach1.Location = new System.Drawing.Point(249, 209);
            this.nudCach1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCach1.Name = "nudCach1";
            this.nudCach1.Size = new System.Drawing.Size(146, 26);
            this.nudCach1.TabIndex = 5;
            // 
            // nudCach2
            // 
            this.nudCach2.Location = new System.Drawing.Point(34, 281);
            this.nudCach2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCach2.Name = "nudCach2";
            this.nudCach2.Size = new System.Drawing.Size(146, 26);
            this.nudCach2.TabIndex = 6;
            // 
            // nudCach3
            // 
            this.nudCach3.Location = new System.Drawing.Point(249, 281);
            this.nudCach3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCach3.Name = "nudCach3";
            this.nudCach3.Size = new System.Drawing.Size(146, 26);
            this.nudCach3.TabIndex = 7;
            // 
            // nudCach4
            // 
            this.nudCach4.Location = new System.Drawing.Point(34, 353);
            this.nudCach4.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCach4.Name = "nudCach4";
            this.nudCach4.Size = new System.Drawing.Size(146, 26);
            this.nudCach4.TabIndex = 8;
            // 
            // wtxtSockelINTEL
            // 
            this.wtxtSockelINTEL.FormattingEnabled = true;
            this.wtxtSockelINTEL.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "463/NextGen",
            "8",
            "Slot 1",
            "479",
            "M",
            "P",
            "370",
            "µPGA2",
            "Slot 2",
            "495",
            "603",
            "604",
            "771/J",
            "1356/B2",
            "441",
            "423",
            "478",
            "1150",
            "1151",
            "1155",
            "1156",
            "1567",
            "2011",
            "2011-3",
            "3647/P3",
            "775/T",
            "989/G1",
            "1366"});
            this.wtxtSockelINTEL.Location = new System.Drawing.Point(34, 135);
            this.wtxtSockelINTEL.Name = "wtxtSockelINTEL";
            this.wtxtSockelINTEL.Size = new System.Drawing.Size(146, 28);
            this.wtxtSockelINTEL.TabIndex = 2;
            // 
            // CPU_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.wtxtSockelINTEL);
            this.Controls.Add(this.nudCach4);
            this.Controls.Add(this.nudCach3);
            this.Controls.Add(this.nudCach2);
            this.Controls.Add(this.nudCach1);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.nudKerne);
            this.Controls.Add(this.mtxtTaktrate);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wtxtSockelAMD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CPU_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU_Imput";
            ((System.ComponentModel.ISupportInitialize)(this.nudKerne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCach4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.ComboBox wtxtSockelAMD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.MaskedTextBox mtxtTaktrate;
        private System.Windows.Forms.NumericUpDown nudKerne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCach1;
        private System.Windows.Forms.NumericUpDown nudCach2;
        private System.Windows.Forms.NumericUpDown nudCach3;
        private System.Windows.Forms.NumericUpDown nudCach4;
        private System.Windows.Forms.ComboBox wtxtSockelINTEL;
    }
}