namespace PC_Hardware_Datenbank
{
    partial class Home_Suche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Suche));
            this.label4 = new System.Windows.Forms.Label();
            this.wtxtSuche = new System.Windows.Forms.ComboBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.cmdSuchen = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.dgvDaten = new System.Windows.Forms.DataGridView();
            this.cmdLoschen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdRoot = new System.Windows.Forms.Button();
            this.cmdInput = new System.Windows.Forms.Button();
            this.cmdQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Was gesucht wird:";
            // 
            // wtxtSuche
            // 
            this.wtxtSuche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtSuche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtSuche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wtxtSuche.FormattingEnabled = true;
            this.wtxtSuche.Items.AddRange(new object[] {
            "Mainboard",
            "CPU",
            "RAM",
            "GPU",
            "HDD",
            "Netzteil",
            "Gehäuse",
            "Soundkarte",
            "Netzwerkkarte",
            "Schnittstellenkarte",
            "TVKarte",
            "Raiserkarte",
            "Laufwerk",
            "FrontErweiterung",
            "Lüfter",
            "Monitor",
            "USV",
            "Kabel",
            "Adapter",
            "I/O",
            "Sonstiges"});
            this.wtxtSuche.Location = new System.Drawing.Point(152, 317);
            this.wtxtSuche.Name = "wtxtSuche";
            this.wtxtSuche.Size = new System.Drawing.Size(159, 28);
            this.wtxtSuche.TabIndex = 0;
            this.wtxtSuche.SelectedIndexChanged += new System.EventHandler(this.wtxtSuche_SelectedIndexChanged);
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(12, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(299, 299);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 15;
            this.img.TabStop = false;
            // 
            // cmdSuchen
            // 
            this.cmdSuchen.BackColor = System.Drawing.Color.Lime;
            this.cmdSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuchen.Location = new System.Drawing.Point(13, 571);
            this.cmdSuchen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSuchen.Name = "cmdSuchen";
            this.cmdSuchen.Size = new System.Drawing.Size(171, 35);
            this.cmdSuchen.TabIndex = 2;
            this.cmdSuchen.Text = "Erweiterte Suche";
            this.cmdSuchen.UseVisualStyleBackColor = false;
            this.cmdSuchen.Visible = false;
            this.cmdSuchen.Click += new System.EventHandler(this.cmdSuchen_Click);
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.BackColor = System.Drawing.Color.Red;
            this.cmdBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBeenden.Location = new System.Drawing.Point(949, 571);
            this.cmdBeenden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(150, 35);
            this.cmdBeenden.TabIndex = 6;
            this.cmdBeenden.Text = "Beenden";
            this.cmdBeenden.UseVisualStyleBackColor = false;
            this.cmdBeenden.Click += new System.EventHandler(this.cmdBeenden_Click);
            // 
            // dgvDaten
            // 
            this.dgvDaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaten.Location = new System.Drawing.Point(317, 12);
            this.dgvDaten.Name = "dgvDaten";
            this.dgvDaten.ReadOnly = true;
            this.dgvDaten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaten.Size = new System.Drawing.Size(782, 551);
            this.dgvDaten.TabIndex = 1;
            this.dgvDaten.TabStop = false;
            // 
            // cmdLoschen
            // 
            this.cmdLoschen.BackColor = System.Drawing.Color.Red;
            this.cmdLoschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoschen.Location = new System.Drawing.Point(192, 571);
            this.cmdLoschen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLoschen.Name = "cmdLoschen";
            this.cmdLoschen.Size = new System.Drawing.Size(171, 35);
            this.cmdLoschen.TabIndex = 3;
            this.cmdLoschen.Text = "Löschen";
            this.cmdLoschen.UseVisualStyleBackColor = false;
            this.cmdLoschen.Click += new System.EventHandler(this.cmdLoschen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdRoot
            // 
            this.cmdRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRoot.Location = new System.Drawing.Point(591, 571);
            this.cmdRoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRoot.Name = "cmdRoot";
            this.cmdRoot.Size = new System.Drawing.Size(171, 35);
            this.cmdRoot.TabIndex = 4;
            this.cmdRoot.Text = "Administration";
            this.cmdRoot.UseVisualStyleBackColor = false;
            this.cmdRoot.Click += new System.EventHandler(this.cmdRoot_Click);
            // 
            // cmdInput
            // 
            this.cmdInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInput.Location = new System.Drawing.Point(770, 571);
            this.cmdInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdInput.Name = "cmdInput";
            this.cmdInput.Size = new System.Drawing.Size(171, 35);
            this.cmdInput.TabIndex = 5;
            this.cmdInput.Text = "Hardware einfügen";
            this.cmdInput.UseVisualStyleBackColor = false;
            this.cmdInput.Click += new System.EventHandler(this.cmdInput_Click);
            // 
            // cmdQR
            // 
            this.cmdQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQR.Location = new System.Drawing.Point(371, 571);
            this.cmdQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQR.Name = "cmdQR";
            this.cmdQR.Size = new System.Drawing.Size(171, 35);
            this.cmdQR.TabIndex = 41;
            this.cmdQR.Text = "QR-Code Drucken";
            this.cmdQR.UseVisualStyleBackColor = false;
            this.cmdQR.Click += new System.EventHandler(this.cmdQR_Click);
            // 
            // Home_Suche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 620);
            this.Controls.Add(this.cmdQR);
            this.Controls.Add(this.cmdRoot);
            this.Controls.Add(this.cmdInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdLoschen);
            this.Controls.Add(this.dgvDaten);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.cmdSuchen);
            this.Controls.Add(this.img);
            this.Controls.Add(this.wtxtSuche);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home_Suche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware finden";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wtxtSuche;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button cmdSuchen;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.DataGridView dgvDaten;
        private System.Windows.Forms.Button cmdLoschen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdRoot;
        private System.Windows.Forms.Button cmdInput;
        private System.Windows.Forms.Button cmdQR;
    }
}