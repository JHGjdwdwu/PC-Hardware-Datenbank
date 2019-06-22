namespace PC_Hardware_Datenbank
{
    partial class Benutzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Benutzer));
            this.cmdErstellen = new System.Windows.Forms.Button();
            this.cmdLoschen = new System.Windows.Forms.Button();
            this.cmdSchliessen = new System.Windows.Forms.Button();
            this.wtxtRechte = new System.Windows.Forms.ListBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdErstellen
            // 
            this.cmdErstellen.Location = new System.Drawing.Point(484, 69);
            this.cmdErstellen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdErstellen.Name = "cmdErstellen";
            this.cmdErstellen.Size = new System.Drawing.Size(112, 35);
            this.cmdErstellen.TabIndex = 3;
            this.cmdErstellen.Text = "&Erstellen";
            this.cmdErstellen.UseVisualStyleBackColor = true;
            this.cmdErstellen.Click += new System.EventHandler(this.cmdErstellen_Click);
            // 
            // cmdLoschen
            // 
            this.cmdLoschen.Location = new System.Drawing.Point(484, 114);
            this.cmdLoschen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLoschen.Name = "cmdLoschen";
            this.cmdLoschen.Size = new System.Drawing.Size(112, 35);
            this.cmdLoschen.TabIndex = 4;
            this.cmdLoschen.Text = "&Löschen";
            this.cmdLoschen.UseVisualStyleBackColor = true;
            this.cmdLoschen.Click += new System.EventHandler(this.cmdLoschen_Click);
            // 
            // cmdSchliessen
            // 
            this.cmdSchliessen.Location = new System.Drawing.Point(479, 535);
            this.cmdSchliessen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSchliessen.Name = "cmdSchliessen";
            this.cmdSchliessen.Size = new System.Drawing.Size(117, 35);
            this.cmdSchliessen.TabIndex = 5;
            this.cmdSchliessen.Text = "&Schließen";
            this.cmdSchliessen.UseVisualStyleBackColor = false;
            this.cmdSchliessen.Click += new System.EventHandler(this.cmdSchliessen_Click);
            // 
            // wtxtRechte
            // 
            this.wtxtRechte.FormattingEnabled = true;
            this.wtxtRechte.ImeMode = System.Windows.Forms.ImeMode.On;
            this.wtxtRechte.ItemHeight = 20;
            this.wtxtRechte.Items.AddRange(new object[] {
            "lesen",
            "schreiben",
            "root"});
            this.wtxtRechte.Location = new System.Drawing.Point(321, 73);
            this.wtxtRechte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wtxtRechte.Name = "wtxtRechte";
            this.wtxtRechte.ScrollAlwaysVisible = true;
            this.wtxtRechte.Size = new System.Drawing.Size(148, 24);
            this.wtxtRechte.TabIndex = 2;
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.CausesValidation = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(13, 159);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.ShowEditingIcon = false;
            this.dgvUser.Size = new System.Drawing.Size(583, 366);
            this.dgvUser.TabIndex = 6;
            this.dgvUser.TabStop = false;
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rechte:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 73);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(166, 73);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(148, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Namen Markieren um ihn zu löschen:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 535);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(354, 535);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(117, 35);
            this.cmdClear.TabIndex = 14;
            this.cmdClear.Text = "&Zurücksetzen";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Benutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 584);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.wtxtRechte);
            this.Controls.Add(this.cmdSchliessen);
            this.Controls.Add(this.cmdLoschen);
            this.Controls.Add(this.cmdErstellen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Benutzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer";
            this.Load += new System.EventHandler(this.Benutzer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdErstellen;
        private System.Windows.Forms.Button cmdLoschen;
        private System.Windows.Forms.Button cmdSchliessen;
        private System.Windows.Forms.ListBox wtxtRechte;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdClear;
    }
}