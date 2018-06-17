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
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.wtxtTacktrate = new System.Windows.Forms.ComboBox();
            this.wtxtGrosse = new System.Windows.Forms.ComboBox();
            this.txtLatenz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtECC = new System.Windows.Forms.CheckBox();
            this.cbtSO_DIMM = new System.Windows.Forms.CheckBox();
            this.cbtRegistered = new System.Windows.Forms.CheckBox();
            this.cbtUnbuffered = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1053, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
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
            this.pcmdMainbord.TabIndex = 73;
            this.pcmdMainbord.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Taktrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(245, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Größe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Typ:";
            // 
            // wtxtHersteller
            // 
            this.wtxtHersteller.FormattingEnabled = true;
            this.wtxtHersteller.Location = new System.Drawing.Point(34, 135);
            this.wtxtHersteller.Name = "wtxtHersteller";
            this.wtxtHersteller.Size = new System.Drawing.Size(146, 28);
            this.wtxtHersteller.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Hersteller:";
            // 
            // wtxtSlot
            // 
            this.wtxtSlot.FormattingEnabled = true;
            this.wtxtSlot.Items.AddRange(new object[] {
            "SDRAM",
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4",
            "DDR5"});
            this.wtxtSlot.Location = new System.Drawing.Point(34, 61);
            this.wtxtSlot.Name = "wtxtSlot";
            this.wtxtSlot.Size = new System.Drawing.Size(146, 28);
            this.wtxtSlot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Slot:";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(249, 135);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(146, 26);
            this.txtTyp.TabIndex = 3;
            // 
            // wtxtTacktrate
            // 
            this.wtxtTacktrate.FormattingEnabled = true;
            this.wtxtTacktrate.Location = new System.Drawing.Point(34, 209);
            this.wtxtTacktrate.Name = "wtxtTacktrate";
            this.wtxtTacktrate.Size = new System.Drawing.Size(146, 28);
            this.wtxtTacktrate.TabIndex = 4;
            // 
            // wtxtGrosse
            // 
            this.wtxtGrosse.FormattingEnabled = true;
            this.wtxtGrosse.Items.AddRange(new object[] {
            "64MB",
            "128MB",
            "512MB",
            "1GB",
            "2GB",
            "4GB",
            "8GB"});
            this.wtxtGrosse.Location = new System.Drawing.Point(249, 61);
            this.wtxtGrosse.Name = "wtxtGrosse";
            this.wtxtGrosse.Size = new System.Drawing.Size(146, 28);
            this.wtxtGrosse.TabIndex = 1;
            // 
            // txtLatenz
            // 
            this.txtLatenz.Location = new System.Drawing.Point(249, 209);
            this.txtLatenz.Name = "txtLatenz";
            this.txtLatenz.Size = new System.Drawing.Size(146, 26);
            this.txtLatenz.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Latenz:";
            // 
            // cbtECC
            // 
            this.cbtECC.AutoSize = true;
            this.cbtECC.Location = new System.Drawing.Point(457, 93);
            this.cbtECC.Name = "cbtECC";
            this.cbtECC.Size = new System.Drawing.Size(61, 24);
            this.cbtECC.TabIndex = 7;
            this.cbtECC.Text = "ECC";
            this.cbtECC.UseVisualStyleBackColor = true;
            // 
            // cbtSO_DIMM
            // 
            this.cbtSO_DIMM.AutoSize = true;
            this.cbtSO_DIMM.Location = new System.Drawing.Point(457, 63);
            this.cbtSO_DIMM.Name = "cbtSO_DIMM";
            this.cbtSO_DIMM.Size = new System.Drawing.Size(99, 24);
            this.cbtSO_DIMM.TabIndex = 6;
            this.cbtSO_DIMM.Text = "SO-DIMM";
            this.cbtSO_DIMM.UseVisualStyleBackColor = true;
            // 
            // cbtRegistered
            // 
            this.cbtRegistered.AutoSize = true;
            this.cbtRegistered.Location = new System.Drawing.Point(457, 123);
            this.cbtRegistered.Name = "cbtRegistered";
            this.cbtRegistered.Size = new System.Drawing.Size(106, 24);
            this.cbtRegistered.TabIndex = 8;
            this.cbtRegistered.Text = "Registered";
            this.cbtRegistered.UseVisualStyleBackColor = true;
            // 
            // cbtUnbuffered
            // 
            this.cbtUnbuffered.AutoSize = true;
            this.cbtUnbuffered.Location = new System.Drawing.Point(457, 153);
            this.cbtUnbuffered.Name = "cbtUnbuffered";
            this.cbtUnbuffered.Size = new System.Drawing.Size(109, 24);
            this.cbtUnbuffered.TabIndex = 9;
            this.cbtUnbuffered.Text = "Unbuffered";
            this.cbtUnbuffered.UseVisualStyleBackColor = true;
            // 
            // RAM_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.cbtUnbuffered);
            this.Controls.Add(this.cbtRegistered);
            this.Controls.Add(this.cbtSO_DIMM);
            this.Controls.Add(this.cbtECC);
            this.Controls.Add(this.txtLatenz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wtxtGrosse);
            this.Controls.Add(this.wtxtTacktrate);
            this.Controls.Add(this.txtTyp);
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
            this.Text = "RAM_Imput";
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
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.ComboBox wtxtTacktrate;
        private System.Windows.Forms.ComboBox wtxtGrosse;
        private System.Windows.Forms.TextBox txtLatenz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbtECC;
        private System.Windows.Forms.CheckBox cbtSO_DIMM;
        private System.Windows.Forms.CheckBox cbtRegistered;
        private System.Windows.Forms.CheckBox cbtUnbuffered;
    }
}