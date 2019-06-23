namespace PC_Hardware_Datenbank
{
    partial class DB_Setings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_Setings));
            this.wtxtDB_Typ = new System.Windows.Forms.ComboBox();
            this.label0 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDB_IP = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wtxtDB_Typ
            // 
            this.wtxtDB_Typ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wtxtDB_Typ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wtxtDB_Typ.FormattingEnabled = true;
            this.wtxtDB_Typ.Items.AddRange(new object[] {
            "MySQL",
            "MariaDB"});
            this.wtxtDB_Typ.Location = new System.Drawing.Point(165, 58);
            this.wtxtDB_Typ.Name = "wtxtDB_Typ";
            this.wtxtDB_Typ.Size = new System.Drawing.Size(159, 28);
            this.wtxtDB_Typ.TabIndex = 121;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.ForeColor = System.Drawing.Color.Red;
            this.label0.Location = new System.Drawing.Point(38, 61);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(121, 20);
            this.label0.TabIndex = 123;
            this.label0.Text = "Datenbank Typ:";
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Red;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(227, 348);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(150, 35);
            this.cmdClose.TabIndex = 122;
            this.cmdClose.Text = "Schließen";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Server Adresse:";
            // 
            // txtDB_IP
            // 
            this.txtDB_IP.Location = new System.Drawing.Point(165, 92);
            this.txtDB_IP.Name = "txtDB_IP";
            this.txtDB_IP.Size = new System.Drawing.Size(159, 26);
            this.txtDB_IP.TabIndex = 125;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(165, 124);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(159, 26);
            this.txtDB.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Datenbank:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(165, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(159, 26);
            this.txtUser.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(41, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 128;
            this.label3.Text = "Benutzername:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(165, 188);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(159, 26);
            this.txtKey.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(77, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 130;
            this.label4.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Lime;
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(13, 348);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(150, 35);
            this.cmdSave.TabIndex = 133;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // DB_Setings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 397);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDB_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wtxtDB_Typ);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.cmdClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_Setings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_Setings";
            this.Load += new System.EventHandler(this.DB_Setings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wtxtDB_Typ;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDB_IP;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdSave;
    }
}