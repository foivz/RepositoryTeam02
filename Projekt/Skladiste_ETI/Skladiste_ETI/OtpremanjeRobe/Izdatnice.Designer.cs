namespace Skladiste_ETI
{
    partial class frmIzdatnice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzdatnice));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnosIzdatnice = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOsnova = new System.Windows.Forms.TextBox();
            this.txtNacinDopreme = new System.Windows.Forms.TextBox();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnosStavki = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.cmbNazivArtikla = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(13, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 98);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnosIzdatnice);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOsnova);
            this.groupBox1.Controls.Add(this.txtNacinDopreme);
            this.groupBox1.Controls.Add(this.cmbKorisnik);
            this.groupBox1.Controls.Add(this.cmbPartner);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(122, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 278);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opis Izdatnice";
            // 
            // btnUnosIzdatnice
            // 
            this.btnUnosIzdatnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosIzdatnice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnosIzdatnice.Image = ((System.Drawing.Image)(resources.GetObject("btnUnosIzdatnice.Image")));
            this.btnUnosIzdatnice.Location = new System.Drawing.Point(400, 184);
            this.btnUnosIzdatnice.Name = "btnUnosIzdatnice";
            this.btnUnosIzdatnice.Size = new System.Drawing.Size(103, 77);
            this.btnUnosIzdatnice.TabIndex = 9;
            this.btnUnosIzdatnice.UseVisualStyleBackColor = true;
            this.btnUnosIzdatnice.Click += new System.EventHandler(this.btnUnosIzdatnice_Click);
            this.btnUnosIzdatnice.MouseHover += new System.EventHandler(this.btnUnosIzdatnice_MouseHover);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(303, 146);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Datum:";
            // 
            // txtOsnova
            // 
            this.txtOsnova.Location = new System.Drawing.Point(303, 116);
            this.txtOsnova.Name = "txtOsnova";
            this.txtOsnova.Size = new System.Drawing.Size(200, 22);
            this.txtOsnova.TabIndex = 7;
            // 
            // txtNacinDopreme
            // 
            this.txtNacinDopreme.Location = new System.Drawing.Point(303, 88);
            this.txtNacinDopreme.Name = "txtNacinDopreme";
            this.txtNacinDopreme.Size = new System.Drawing.Size(200, 22);
            this.txtNacinDopreme.TabIndex = 6;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(303, 58);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(200, 24);
            this.cmbKorisnik.TabIndex = 5;
            // 
            // cmbPartner
            // 
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(303, 28);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(200, 24);
            this.cmbPartner.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Izrađeno prema dokumentu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Način transporta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izradio (skladištar):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Za tvrtku:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnUnosStavki);
            this.groupBox2.Controls.Add(this.txtKolicina);
            this.groupBox2.Controls.Add(this.txtMasa);
            this.groupBox2.Controls.Add(this.cmbNazivArtikla);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(122, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikli izdatnice";
            // 
            // btnUnosStavki
            // 
            this.btnUnosStavki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosStavki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnosStavki.Image = ((System.Drawing.Image)(resources.GetObject("btnUnosStavki.Image")));
            this.btnUnosStavki.Location = new System.Drawing.Point(400, 41);
            this.btnUnosStavki.Name = "btnUnosStavki";
            this.btnUnosStavki.Size = new System.Drawing.Size(103, 77);
            this.btnUnosStavki.TabIndex = 8;
            this.btnUnosStavki.UseVisualStyleBackColor = true;
            this.btnUnosStavki.Click += new System.EventHandler(this.btnUnosStavki_Click);
            this.btnUnosStavki.MouseHover += new System.EventHandler(this.btnUnosStavki_MouseHover);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(97, 65);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(266, 22);
            this.txtKolicina.TabIndex = 6;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(97, 90);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(266, 22);
            this.txtMasa.TabIndex = 5;
            // 
            // cmbNazivArtikla
            // 
            this.cmbNazivArtikla.FormattingEnabled = true;
            this.cmbNazivArtikla.Location = new System.Drawing.Point(97, 38);
            this.cmbNazivArtikla.Name = "cmbNazivArtikla";
            this.cmbNazivArtikla.Size = new System.Drawing.Size(266, 24);
            this.cmbNazivArtikla.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Masa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Naziv:";
            // 
            // frmIzdatnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(686, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIzdatnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izrada izdatnice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnosIzdatnice;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOsnova;
        private System.Windows.Forms.TextBox txtNacinDopreme;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUnosStavki;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.ComboBox cmbNazivArtikla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}