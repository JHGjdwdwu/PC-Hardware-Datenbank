namespace PC_Hardware_Datenbank
{
    partial class Monitor_Imput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor_Imput));
            this.wtxtMaxAuflosung = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbtLautsprecher = new System.Windows.Forms.CheckBox();
            this.cbtEingangAudio = new System.Windows.Forms.CheckBox();
            this.cbtEingangRGB = new System.Windows.Forms.CheckBox();
            this.cbtEingangDisplaport = new System.Windows.Forms.CheckBox();
            this.grub = new System.Windows.Forms.GroupBox();
            this.cbtEingangHDMI = new System.Windows.Forms.CheckBox();
            this.cbtEingangDVI = new System.Windows.Forms.CheckBox();
            this.cbtEingangVGA = new System.Windows.Forms.CheckBox();
            this.nudEingangAudio = new System.Windows.Forms.NumericUpDown();
            this.nudEingangRGB = new System.Windows.Forms.NumericUpDown();
            this.nudEingangDisplaport = new System.Windows.Forms.NumericUpDown();
            this.nudEingangHDMI = new System.Windows.Forms.NumericUpDown();
            this.nudEingangDVI = new System.Windows.Forms.NumericUpDown();
            this.nudEingangVGA = new System.Windows.Forms.NumericUpDown();
            this.wtxtModell = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQR = new System.Windows.Forms.Button();
            this.cmdBildEinfugen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.pcmdMainbord = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wtxtTechnik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wtxtHersteller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtEingangUSB = new System.Windows.Forms.CheckBox();
            this.nudEingangUSB = new System.Windows.Forms.NumericUpDown();
            this.cbtHöhenVerstellbar = new System.Windows.Forms.CheckBox();
            this.cbtVESA = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbtAusgangUSB = new System.Windows.Forms.CheckBox();
            this.nudAusgangUSB = new System.Windows.Forms.NumericUpDown();
            this.cbtAusgangAudio = new System.Windows.Forms.CheckBox();
            this.nudAusgangAudio = new System.Windows.Forms.NumericUpDown();
            this.grub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangDisplaport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangHDMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangDVI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangVGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangUSB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAusgangUSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAusgangAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtMaxAuflosung
            // 
            this.wtxtMaxAuflosung.FormattingEnabled = true;
            this.wtxtMaxAuflosung.Location = new System.Drawing.Point(230, 135);
            this.wtxtMaxAuflosung.Name = "wtxtMaxAuflosung";
            this.wtxtMaxAuflosung.Size = new System.Drawing.Size(146, 28);
            this.wtxtMaxAuflosung.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 139;
            this.label6.Text = "Max.Auflösung:";
            // 
            // cbtLautsprecher
            // 
            this.cbtLautsprecher.AutoSize = true;
            this.cbtLautsprecher.Location = new System.Drawing.Point(33, 202);
            this.cbtLautsprecher.Name = "cbtLautsprecher";
            this.cbtLautsprecher.Size = new System.Drawing.Size(122, 24);
            this.cbtLautsprecher.TabIndex = 4;
            this.cbtLautsprecher.Text = "Lautsprecher";
            this.cbtLautsprecher.UseVisualStyleBackColor = true;
            // 
            // cbtEingangAudio
            // 
            this.cbtEingangAudio.AutoSize = true;
            this.cbtEingangAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangAudio.Location = new System.Drawing.Point(17, 195);
            this.cbtEingangAudio.Name = "cbtEingangAudio";
            this.cbtEingangAudio.Size = new System.Drawing.Size(69, 24);
            this.cbtEingangAudio.TabIndex = 31;
            this.cbtEingangAudio.TabStop = false;
            this.cbtEingangAudio.Text = "Audio";
            this.cbtEingangAudio.UseVisualStyleBackColor = true;
            this.cbtEingangAudio.CheckedChanged += new System.EventHandler(this.cbtEingangAudio_CheckedChanged);
            // 
            // cbtEingangRGB
            // 
            this.cbtEingangRGB.AutoSize = true;
            this.cbtEingangRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangRGB.Location = new System.Drawing.Point(17, 163);
            this.cbtEingangRGB.Name = "cbtEingangRGB";
            this.cbtEingangRGB.Size = new System.Drawing.Size(64, 24);
            this.cbtEingangRGB.TabIndex = 30;
            this.cbtEingangRGB.TabStop = false;
            this.cbtEingangRGB.Text = "RGB";
            this.cbtEingangRGB.UseVisualStyleBackColor = true;
            this.cbtEingangRGB.CheckedChanged += new System.EventHandler(this.cbtEingangRGB_CheckedChanged);
            // 
            // cbtEingangDisplaport
            // 
            this.cbtEingangDisplaport.AutoSize = true;
            this.cbtEingangDisplaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangDisplaport.Location = new System.Drawing.Point(17, 131);
            this.cbtEingangDisplaport.Name = "cbtEingangDisplaport";
            this.cbtEingangDisplaport.Size = new System.Drawing.Size(107, 24);
            this.cbtEingangDisplaport.TabIndex = 29;
            this.cbtEingangDisplaport.TabStop = false;
            this.cbtEingangDisplaport.Text = "Displayport";
            this.cbtEingangDisplaport.UseVisualStyleBackColor = true;
            this.cbtEingangDisplaport.CheckedChanged += new System.EventHandler(this.cbtEingangDisplaport_CheckedChanged);
            // 
            // grub
            // 
            this.grub.Controls.Add(this.cbtEingangUSB);
            this.grub.Controls.Add(this.nudEingangUSB);
            this.grub.Controls.Add(this.cbtEingangAudio);
            this.grub.Controls.Add(this.cbtEingangRGB);
            this.grub.Controls.Add(this.cbtEingangDisplaport);
            this.grub.Controls.Add(this.cbtEingangHDMI);
            this.grub.Controls.Add(this.cbtEingangDVI);
            this.grub.Controls.Add(this.cbtEingangVGA);
            this.grub.Controls.Add(this.nudEingangAudio);
            this.grub.Controls.Add(this.nudEingangRGB);
            this.grub.Controls.Add(this.nudEingangDisplaport);
            this.grub.Controls.Add(this.nudEingangHDMI);
            this.grub.Controls.Add(this.nudEingangDVI);
            this.grub.Controls.Add(this.nudEingangVGA);
            this.grub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grub.Location = new System.Drawing.Point(419, 38);
            this.grub.Name = "grub";
            this.grub.Size = new System.Drawing.Size(213, 285);
            this.grub.TabIndex = 7;
            this.grub.TabStop = false;
            this.grub.Text = "Eingänge";
            // 
            // cbtEingangHDMI
            // 
            this.cbtEingangHDMI.AutoSize = true;
            this.cbtEingangHDMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangHDMI.Location = new System.Drawing.Point(17, 99);
            this.cbtEingangHDMI.Name = "cbtEingangHDMI";
            this.cbtEingangHDMI.Size = new System.Drawing.Size(70, 24);
            this.cbtEingangHDMI.TabIndex = 26;
            this.cbtEingangHDMI.TabStop = false;
            this.cbtEingangHDMI.Text = "HDMI";
            this.cbtEingangHDMI.UseVisualStyleBackColor = true;
            this.cbtEingangHDMI.CheckedChanged += new System.EventHandler(this.cbtEingangHDMI_CheckedChanged);
            // 
            // cbtEingangDVI
            // 
            this.cbtEingangDVI.AutoSize = true;
            this.cbtEingangDVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangDVI.Location = new System.Drawing.Point(17, 67);
            this.cbtEingangDVI.Name = "cbtEingangDVI";
            this.cbtEingangDVI.Size = new System.Drawing.Size(56, 24);
            this.cbtEingangDVI.TabIndex = 25;
            this.cbtEingangDVI.TabStop = false;
            this.cbtEingangDVI.Text = "DVI";
            this.cbtEingangDVI.UseVisualStyleBackColor = true;
            this.cbtEingangDVI.CheckedChanged += new System.EventHandler(this.cbtEingangDVI_CheckedChanged);
            // 
            // cbtEingangVGA
            // 
            this.cbtEingangVGA.AutoSize = true;
            this.cbtEingangVGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangVGA.Location = new System.Drawing.Point(17, 35);
            this.cbtEingangVGA.Name = "cbtEingangVGA";
            this.cbtEingangVGA.Size = new System.Drawing.Size(63, 24);
            this.cbtEingangVGA.TabIndex = 66;
            this.cbtEingangVGA.TabStop = false;
            this.cbtEingangVGA.Text = "VGA";
            this.cbtEingangVGA.UseVisualStyleBackColor = true;
            this.cbtEingangVGA.CheckedChanged += new System.EventHandler(this.cbtEingangVGA_CheckedChanged);
            // 
            // nudEingangAudio
            // 
            this.nudEingangAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangAudio.Location = new System.Drawing.Point(130, 194);
            this.nudEingangAudio.Name = "nudEingangAudio";
            this.nudEingangAudio.Size = new System.Drawing.Size(57, 26);
            this.nudEingangAudio.TabIndex = 5;
            this.nudEingangAudio.ValueChanged += new System.EventHandler(this.nudEingangAudio_ValueChanged);
            // 
            // nudEingangRGB
            // 
            this.nudEingangRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangRGB.Location = new System.Drawing.Point(130, 162);
            this.nudEingangRGB.Name = "nudEingangRGB";
            this.nudEingangRGB.Size = new System.Drawing.Size(57, 26);
            this.nudEingangRGB.TabIndex = 4;
            this.nudEingangRGB.ValueChanged += new System.EventHandler(this.nudEingangRGB_ValueChanged);
            // 
            // nudEingangDisplaport
            // 
            this.nudEingangDisplaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangDisplaport.Location = new System.Drawing.Point(130, 130);
            this.nudEingangDisplaport.Name = "nudEingangDisplaport";
            this.nudEingangDisplaport.Size = new System.Drawing.Size(57, 26);
            this.nudEingangDisplaport.TabIndex = 3;
            this.nudEingangDisplaport.ValueChanged += new System.EventHandler(this.nudEingangDisplaport_ValueChanged);
            // 
            // nudEingangHDMI
            // 
            this.nudEingangHDMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangHDMI.Location = new System.Drawing.Point(130, 98);
            this.nudEingangHDMI.Name = "nudEingangHDMI";
            this.nudEingangHDMI.Size = new System.Drawing.Size(57, 26);
            this.nudEingangHDMI.TabIndex = 2;
            this.nudEingangHDMI.ValueChanged += new System.EventHandler(this.nudEingangHDMI_ValueChanged);
            // 
            // nudEingangDVI
            // 
            this.nudEingangDVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangDVI.Location = new System.Drawing.Point(130, 66);
            this.nudEingangDVI.Name = "nudEingangDVI";
            this.nudEingangDVI.Size = new System.Drawing.Size(57, 26);
            this.nudEingangDVI.TabIndex = 1;
            this.nudEingangDVI.ValueChanged += new System.EventHandler(this.nudEingangDVI_ValueChanged);
            // 
            // nudEingangVGA
            // 
            this.nudEingangVGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangVGA.Location = new System.Drawing.Point(130, 34);
            this.nudEingangVGA.Name = "nudEingangVGA";
            this.nudEingangVGA.Size = new System.Drawing.Size(57, 26);
            this.nudEingangVGA.TabIndex = 0;
            this.nudEingangVGA.ValueChanged += new System.EventHandler(this.nudEingangVGA_ValueChanged);
            // 
            // wtxtModell
            // 
            this.wtxtModell.FormattingEnabled = true;
            this.wtxtModell.Location = new System.Drawing.Point(233, 61);
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
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(229, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 133;
            this.label5.Text = "Modell:";
            // 
            // wtxtTechnik
            // 
            this.wtxtTechnik.FormattingEnabled = true;
            this.wtxtTechnik.Items.AddRange(new object[] {
            "LED",
            "LED-IPS",
            "IPS",
            "LED-LCD",
            "LCD",
            "Röhre"});
            this.wtxtTechnik.Location = new System.Drawing.Point(34, 135);
            this.wtxtTechnik.Name = "wtxtTechnik";
            this.wtxtTechnik.Size = new System.Drawing.Size(146, 28);
            this.wtxtTechnik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 131;
            this.label2.Text = "Technik:";
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
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "Hersteller:";
            // 
            // cbtEingangUSB
            // 
            this.cbtEingangUSB.AutoSize = true;
            this.cbtEingangUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtEingangUSB.Location = new System.Drawing.Point(17, 227);
            this.cbtEingangUSB.Name = "cbtEingangUSB";
            this.cbtEingangUSB.Size = new System.Drawing.Size(62, 24);
            this.cbtEingangUSB.TabIndex = 68;
            this.cbtEingangUSB.TabStop = false;
            this.cbtEingangUSB.Text = "USB";
            this.cbtEingangUSB.UseVisualStyleBackColor = true;
            this.cbtEingangUSB.CheckedChanged += new System.EventHandler(this.cbtEingangUSB_CheckedChanged);
            // 
            // nudEingangUSB
            // 
            this.nudEingangUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEingangUSB.Location = new System.Drawing.Point(130, 226);
            this.nudEingangUSB.Name = "nudEingangUSB";
            this.nudEingangUSB.Size = new System.Drawing.Size(57, 26);
            this.nudEingangUSB.TabIndex = 6;
            this.nudEingangUSB.ValueChanged += new System.EventHandler(this.nudEingangUSB_ValueChanged);
            // 
            // cbtHöhenVerstellbar
            // 
            this.cbtHöhenVerstellbar.AutoSize = true;
            this.cbtHöhenVerstellbar.Location = new System.Drawing.Point(33, 232);
            this.cbtHöhenVerstellbar.Name = "cbtHöhenVerstellbar";
            this.cbtHöhenVerstellbar.Size = new System.Drawing.Size(152, 24);
            this.cbtHöhenVerstellbar.TabIndex = 5;
            this.cbtHöhenVerstellbar.Text = "Höhen verstellbar";
            this.cbtHöhenVerstellbar.UseVisualStyleBackColor = true;
            // 
            // cbtVESA
            // 
            this.cbtVESA.AutoSize = true;
            this.cbtVESA.Location = new System.Drawing.Point(33, 262);
            this.cbtVESA.Name = "cbtVESA";
            this.cbtVESA.Size = new System.Drawing.Size(146, 24);
            this.cbtVESA.TabIndex = 6;
            this.cbtVESA.Text = "VESA Halterung";
            this.cbtVESA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtAusgangUSB);
            this.groupBox2.Controls.Add(this.nudAusgangUSB);
            this.groupBox2.Controls.Add(this.cbtAusgangAudio);
            this.groupBox2.Controls.Add(this.nudAusgangAudio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 126);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ausgänge";
            // 
            // cbtAusgangUSB
            // 
            this.cbtAusgangUSB.AutoSize = true;
            this.cbtAusgangUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtAusgangUSB.Location = new System.Drawing.Point(17, 68);
            this.cbtAusgangUSB.Name = "cbtAusgangUSB";
            this.cbtAusgangUSB.Size = new System.Drawing.Size(62, 24);
            this.cbtAusgangUSB.TabIndex = 68;
            this.cbtAusgangUSB.TabStop = false;
            this.cbtAusgangUSB.Text = "USB";
            this.cbtAusgangUSB.UseVisualStyleBackColor = true;
            this.cbtAusgangUSB.CheckedChanged += new System.EventHandler(this.cbtAusgangUSB_CheckedChanged);
            // 
            // nudAusgangUSB
            // 
            this.nudAusgangUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAusgangUSB.Location = new System.Drawing.Point(130, 67);
            this.nudAusgangUSB.Name = "nudAusgangUSB";
            this.nudAusgangUSB.Size = new System.Drawing.Size(57, 26);
            this.nudAusgangUSB.TabIndex = 1;
            this.nudAusgangUSB.ValueChanged += new System.EventHandler(this.nudAusgangUSB_ValueChanged);
            // 
            // cbtAusgangAudio
            // 
            this.cbtAusgangAudio.AutoSize = true;
            this.cbtAusgangAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtAusgangAudio.Location = new System.Drawing.Point(17, 36);
            this.cbtAusgangAudio.Name = "cbtAusgangAudio";
            this.cbtAusgangAudio.Size = new System.Drawing.Size(69, 24);
            this.cbtAusgangAudio.TabIndex = 31;
            this.cbtAusgangAudio.TabStop = false;
            this.cbtAusgangAudio.Text = "Audio";
            this.cbtAusgangAudio.UseVisualStyleBackColor = true;
            this.cbtAusgangAudio.CheckedChanged += new System.EventHandler(this.cbtAusgangAudio_CheckedChanged);
            // 
            // nudAusgangAudio
            // 
            this.nudAusgangAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAusgangAudio.Location = new System.Drawing.Point(130, 35);
            this.nudAusgangAudio.Name = "nudAusgangAudio";
            this.nudAusgangAudio.Size = new System.Drawing.Size(57, 26);
            this.nudAusgangAudio.TabIndex = 0;
            this.nudAusgangAudio.ValueChanged += new System.EventHandler(this.nudAusgangAudio_ValueChanged);
            // 
            // Monitor_Imput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbtVESA);
            this.Controls.Add(this.cbtHöhenVerstellbar);
            this.Controls.Add(this.wtxtMaxAuflosung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbtLautsprecher);
            this.Controls.Add(this.grub);
            this.Controls.Add(this.wtxtModell);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdBildEinfugen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.pcmdMainbord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wtxtTechnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wtxtHersteller);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Monitor_Imput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor_Imput";
            this.grub.ResumeLayout(false);
            this.grub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangDisplaport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangHDMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangDVI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangVGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcmdMainbord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEingangUSB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAusgangUSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAusgangAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox wtxtMaxAuflosung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbtLautsprecher;
        private System.Windows.Forms.CheckBox cbtEingangAudio;
        private System.Windows.Forms.CheckBox cbtEingangRGB;
        private System.Windows.Forms.CheckBox cbtEingangDisplaport;
        private System.Windows.Forms.GroupBox grub;
        private System.Windows.Forms.CheckBox cbtEingangHDMI;
        private System.Windows.Forms.CheckBox cbtEingangDVI;
        private System.Windows.Forms.CheckBox cbtEingangVGA;
        private System.Windows.Forms.NumericUpDown nudEingangAudio;
        private System.Windows.Forms.NumericUpDown nudEingangRGB;
        private System.Windows.Forms.NumericUpDown nudEingangDisplaport;
        private System.Windows.Forms.NumericUpDown nudEingangHDMI;
        private System.Windows.Forms.NumericUpDown nudEingangDVI;
        private System.Windows.Forms.NumericUpDown nudEingangVGA;
        private System.Windows.Forms.ComboBox wtxtModell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQR;
        private System.Windows.Forms.Button cmdBildEinfugen;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.PictureBox pcmdMainbord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wtxtTechnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wtxtHersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbtEingangUSB;
        private System.Windows.Forms.NumericUpDown nudEingangUSB;
        private System.Windows.Forms.CheckBox cbtHöhenVerstellbar;
        private System.Windows.Forms.CheckBox cbtVESA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtAusgangUSB;
        private System.Windows.Forms.NumericUpDown nudAusgangUSB;
        private System.Windows.Forms.CheckBox cbtAusgangAudio;
        private System.Windows.Forms.NumericUpDown nudAusgangAudio;
    }
}