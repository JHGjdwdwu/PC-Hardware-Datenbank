﻿namespace PC_Hardware_Datenbank
{
    partial class Lufter_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lufter_Imput));
            this.label10 = new System.Windows.Forms.Label();
            this.wtxtPinheader = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wtxtDicke = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wtxtArt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wtxtModell = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.wtxtDurchmesser = new System.Windows.Forms.ComboBox();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wtxtMaximaldrehzahl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxtSpannung = new System.Windows.Forms.ComboBox();
            this.nudStrom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrom)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 140;
            this.label10.Text = "Strom (A):";
            // 
            // wtxtPinheader
            // 
            this.wtxtPinheader.FormattingEnabled = true;
            this.wtxtPinheader.Items.AddRange(new object[] {
            "2-Pin",
            "3-Pin",
            "4-Pin"});
            this.wtxtPinheader.Location = new System.Drawing.Point(246, 135);
            this.wtxtPinheader.Name = "wtxtPinheader";
            this.wtxtPinheader.Size = new System.Drawing.Size(146, 28);
            this.wtxtPinheader.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 139;
            this.label6.Text = "Pinheader:";
            // 
            // wtxtDicke
            // 
            this.wtxtDicke.FormattingEnabled = true;
            this.wtxtDicke.Location = new System.Drawing.Point(246, 209);
            this.wtxtDicke.Name = "wtxtDicke";
            this.wtxtDicke.Size = new System.Drawing.Size(146, 28);
            this.wtxtDicke.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(245, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 138;
            this.label9.Text = "Dicke:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(245, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 137;
            this.label8.Text = "Spannung (V):";
            // 
            // wtxtArt
            // 
            this.wtxtArt.FormattingEnabled = true;
            this.wtxtArt.Items.AddRange(new object[] {
            "Gehäuselüfter",
            "CPU-Lüfter",
            "Speicherkühler",
            "Grafikkartenkühler"});
            this.wtxtArt.Location = new System.Drawing.Point(34, 283);
            this.wtxtArt.Name = "wtxtArt";
            this.wtxtArt.Size = new System.Drawing.Size(146, 28);
            this.wtxtArt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(30, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 136;
            this.label7.Text = "Art:";
            // 
            // wtxtModell
            // 
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
            this.pictureBox1.TabIndex = 135;
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
            // wtxtDurchmesser
            // 
            this.wtxtDurchmesser.FormattingEnabled = true;
            this.wtxtDurchmesser.Location = new System.Drawing.Point(34, 209);
            this.wtxtDurchmesser.Name = "wtxtDurchmesser";
            this.wtxtDurchmesser.Size = new System.Drawing.Size(146, 28);
            this.wtxtDurchmesser.TabIndex = 4;
            // 
            // pcmdMainbord
            // 
            this.pcmdMainbord.Image = ((System.Drawing.Image)(resources.GetObject("pcmdMainbord.Image")));
            this.pcmdMainbord.Location = new System.Drawing.Point(663, 14);
            this.pcmdMainbord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcmdMainbord.Name = "pcmdMainbord";
            this.pcmdMainbord.Size = new System.Drawing.Size(450, 450);
            this.pcmdMainbord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcmdMainbord.TabIndex = 134;
            this.pcmdMainbord.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(245, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 133;
            this.label5.Text = "Modell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(30, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 132;
            this.label3.Text = "Durchmesser:";
            // 
            // wtxtMaximaldrehzahl
            // 
            this.wtxtMaximaldrehzahl.FormattingEnabled = true;
            this.wtxtMaximaldrehzahl.Location = new System.Drawing.Point(34, 135);
            this.wtxtMaximaldrehzahl.Name = "wtxtMaximaldrehzahl";
            this.wtxtMaximaldrehzahl.Size = new System.Drawing.Size(146, 28);
            this.wtxtMaximaldrehzahl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 131;
            this.label2.Text = "Maximaldrehzahl:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 61);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "Hersteller:";
            // 
            // wtxtSpannung
            // 
            this.wtxtSpannung.FormattingEnabled = true;
            this.wtxtSpannung.Items.AddRange(new object[] {
            "3V",
            "5V",
            "12V",
            "24V"});
            this.wtxtSpannung.Location = new System.Drawing.Point(246, 285);
            this.wtxtSpannung.Name = "wtxtSpannung";
            this.wtxtSpannung.Size = new System.Drawing.Size(146, 28);
            this.wtxtSpannung.TabIndex = 7;
            // 
            // nudStrom
            // 
            this.nudStrom.DecimalPlaces = 2;
            this.nudStrom.Location = new System.Drawing.Point(34, 357);
            this.nudStrom.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudStrom.Name = "nudStrom";
            this.nudStrom.Size = new System.Drawing.Size(146, 26);
            this.nudStrom.TabIndex = 8;
            // 
            // Lufter_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.nudStrom);
            this.Controls.Add(this.wtxtSpannung);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wtxtPinheader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wtxtDicke);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wtxtArt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wtxtModell);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.wtxtDurchmesser);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wtxtMaximaldrehzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lufter_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lufter_Imput";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox wtxtPinheader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox wtxtDicke;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox wtxtArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox wtxtModell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.ComboBox wtxtDurchmesser;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox wtxtMaximaldrehzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wtxtSpannung;
        private System.Windows.Forms.NumericUpDown nudStrom;
    }
}