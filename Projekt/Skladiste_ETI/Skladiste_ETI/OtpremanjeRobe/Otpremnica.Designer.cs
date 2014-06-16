namespace Skladiste_ETI.OtpremanjeRobe
{
    partial class frmOtpremnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtpremnica));
            this.btnExit = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.gbOpisOtpremnice = new System.Windows.Forms.GroupBox();
            this.gbArtikliZaOtpremu = new System.Windows.Forms.GroupBox();
            this.lblZaTvrtku = new System.Windows.Forms.Label();
            this.lblIzradio = new System.Windows.Forms.Label();
            this.lblNacinTransporta = new System.Windows.Forms.Label();
            this.lblPremaDokumentu = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.txtNacinDopreme = new System.Windows.Forms.TextBox();
            this.cmbOsnova = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblMasa = new System.Windows.Forms.Label();
            this.cmbNazivArtikla = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.btnUnosOtpremnice = new System.Windows.Forms.Button();
            this.btnUnosStavki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbOpisOtpremnice.SuspendLayout();
            this.gbArtikliZaOtpremu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(9, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 98);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pbSlika
            // 
            this.pbSlika.Image = ((System.Drawing.Image)(resources.GetObject("pbSlika.Image")));
            this.pbSlika.Location = new System.Drawing.Point(12, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(100, 100);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // gbOpisOtpremnice
            // 
            this.gbOpisOtpremnice.Controls.Add(this.btnUnosOtpremnice);
            this.gbOpisOtpremnice.Controls.Add(this.dtpDatum);
            this.gbOpisOtpremnice.Controls.Add(this.cmbOsnova);
            this.gbOpisOtpremnice.Controls.Add(this.txtNacinDopreme);
            this.gbOpisOtpremnice.Controls.Add(this.cmbKorisnik);
            this.gbOpisOtpremnice.Controls.Add(this.cmbPartner);
            this.gbOpisOtpremnice.Controls.Add(this.lblDatum);
            this.gbOpisOtpremnice.Controls.Add(this.lblPremaDokumentu);
            this.gbOpisOtpremnice.Controls.Add(this.lblNacinTransporta);
            this.gbOpisOtpremnice.Controls.Add(this.lblIzradio);
            this.gbOpisOtpremnice.Controls.Add(this.lblZaTvrtku);
            this.gbOpisOtpremnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpisOtpremnice.ForeColor = System.Drawing.Color.Red;
            this.gbOpisOtpremnice.Location = new System.Drawing.Point(118, 12);
            this.gbOpisOtpremnice.Name = "gbOpisOtpremnice";
            this.gbOpisOtpremnice.Size = new System.Drawing.Size(560, 231);
            this.gbOpisOtpremnice.TabIndex = 2;
            this.gbOpisOtpremnice.TabStop = false;
            this.gbOpisOtpremnice.Text = "Opis otpremnice";
            // 
            // gbArtikliZaOtpremu
            // 
            this.gbArtikliZaOtpremu.Controls.Add(this.btnUnosStavki);
            this.gbArtikliZaOtpremu.Controls.Add(this.txtMasa);
            this.gbArtikliZaOtpremu.Controls.Add(this.txtKolicina);
            this.gbArtikliZaOtpremu.Controls.Add(this.cmbNazivArtikla);
            this.gbArtikliZaOtpremu.Controls.Add(this.lblMasa);
            this.gbArtikliZaOtpremu.Controls.Add(this.lblKolicina);
            this.gbArtikliZaOtpremu.Controls.Add(this.lblNaziv);
            this.gbArtikliZaOtpremu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArtikliZaOtpremu.ForeColor = System.Drawing.Color.Red;
            this.gbArtikliZaOtpremu.Location = new System.Drawing.Point(118, 297);
            this.gbArtikliZaOtpremu.Name = "gbArtikliZaOtpremu";
            this.gbArtikliZaOtpremu.Size = new System.Drawing.Size(560, 134);
            this.gbArtikliZaOtpremu.TabIndex = 3;
            this.gbArtikliZaOtpremu.TabStop = false;
            this.gbArtikliZaOtpremu.Text = "Artikli za otpremu";
            // 
            // lblZaTvrtku
            // 
            this.lblZaTvrtku.AutoSize = true;
            this.lblZaTvrtku.Location = new System.Drawing.Point(25, 33);
            this.lblZaTvrtku.Name = "lblZaTvrtku";
            this.lblZaTvrtku.Size = new System.Drawing.Size(71, 16);
            this.lblZaTvrtku.TabIndex = 0;
            this.lblZaTvrtku.Text = "Za tvrtku:";
            // 
            // lblIzradio
            // 
            this.lblIzradio.AutoSize = true;
            this.lblIzradio.Location = new System.Drawing.Point(25, 62);
            this.lblIzradio.Name = "lblIzradio";
            this.lblIzradio.Size = new System.Drawing.Size(141, 16);
            this.lblIzradio.TabIndex = 1;
            this.lblIzradio.Text = "Izradio (skladištar):";
            // 
            // lblNacinTransporta
            // 
            this.lblNacinTransporta.AutoSize = true;
            this.lblNacinTransporta.Location = new System.Drawing.Point(25, 92);
            this.lblNacinTransporta.Name = "lblNacinTransporta";
            this.lblNacinTransporta.Size = new System.Drawing.Size(126, 16);
            this.lblNacinTransporta.TabIndex = 2;
            this.lblNacinTransporta.Text = "Način transporta:";
            // 
            // lblPremaDokumentu
            // 
            this.lblPremaDokumentu.AutoSize = true;
            this.lblPremaDokumentu.Location = new System.Drawing.Point(25, 121);
            this.lblPremaDokumentu.Name = "lblPremaDokumentu";
            this.lblPremaDokumentu.Size = new System.Drawing.Size(199, 16);
            this.lblPremaDokumentu.TabIndex = 3;
            this.lblPremaDokumentu.Text = "Izrađeno prema dokumentu:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(25, 150);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(56, 16);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Datum:";
            // 
            // cmbPartner
            // 
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(233, 30);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(200, 24);
            this.cmbPartner.TabIndex = 5;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(233, 59);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(200, 24);
            this.cmbKorisnik.TabIndex = 6;
            // 
            // txtNacinDopreme
            // 
            this.txtNacinDopreme.Location = new System.Drawing.Point(233, 89);
            this.txtNacinDopreme.Name = "txtNacinDopreme";
            this.txtNacinDopreme.Size = new System.Drawing.Size(200, 22);
            this.txtNacinDopreme.TabIndex = 7;
            // 
            // cmbOsnova
            // 
            this.cmbOsnova.FormattingEnabled = true;
            this.cmbOsnova.Location = new System.Drawing.Point(233, 118);
            this.cmbOsnova.Name = "cmbOsnova";
            this.cmbOsnova.Size = new System.Drawing.Size(200, 24);
            this.cmbOsnova.TabIndex = 8;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(233, 150);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 9;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(25, 32);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 16);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(25, 67);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(67, 16);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Location = new System.Drawing.Point(25, 98);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(50, 16);
            this.lblMasa.TabIndex = 2;
            this.lblMasa.Text = "Masa:";
            // 
            // cmbNazivArtikla
            // 
            this.cmbNazivArtikla.FormattingEnabled = true;
            this.cmbNazivArtikla.Location = new System.Drawing.Point(111, 32);
            this.cmbNazivArtikla.Name = "cmbNazivArtikla";
            this.cmbNazivArtikla.Size = new System.Drawing.Size(121, 24);
            this.cmbNazivArtikla.TabIndex = 3;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(111, 66);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 22);
            this.txtKolicina.TabIndex = 4;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(111, 95);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(121, 22);
            this.txtMasa.TabIndex = 5;
            // 
            // btnUnosOtpremnice
            // 
            this.btnUnosOtpremnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosOtpremnice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnosOtpremnice.Image = ((System.Drawing.Image)(resources.GetObject("btnUnosOtpremnice.Image")));
            this.btnUnosOtpremnice.Location = new System.Drawing.Point(456, 134);
            this.btnUnosOtpremnice.Name = "btnUnosOtpremnice";
            this.btnUnosOtpremnice.Size = new System.Drawing.Size(75, 78);
            this.btnUnosOtpremnice.TabIndex = 10;
            this.btnUnosOtpremnice.UseVisualStyleBackColor = true;
            // 
            // btnUnosStavki
            // 
            this.btnUnosStavki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosStavki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnosStavki.Image = ((System.Drawing.Image)(resources.GetObject("btnUnosStavki.Image")));
            this.btnUnosStavki.Location = new System.Drawing.Point(456, 32);
            this.btnUnosStavki.Name = "btnUnosStavki";
            this.btnUnosStavki.Size = new System.Drawing.Size(75, 77);
            this.btnUnosStavki.TabIndex = 6;
            this.btnUnosStavki.UseVisualStyleBackColor = true;
            // 
            // frmOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(690, 443);
            this.Controls.Add(this.gbArtikliZaOtpremu);
            this.Controls.Add(this.gbOpisOtpremnice);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOtpremnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izrada otpremnice";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbOpisOtpremnice.ResumeLayout(false);
            this.gbOpisOtpremnice.PerformLayout();
            this.gbArtikliZaOtpremu.ResumeLayout(false);
            this.gbArtikliZaOtpremu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.GroupBox gbOpisOtpremnice;
        private System.Windows.Forms.Button btnUnosOtpremnice;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbOsnova;
        private System.Windows.Forms.TextBox txtNacinDopreme;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblPremaDokumentu;
        private System.Windows.Forms.Label lblNacinTransporta;
        private System.Windows.Forms.Label lblIzradio;
        private System.Windows.Forms.Label lblZaTvrtku;
        private System.Windows.Forms.GroupBox gbArtikliZaOtpremu;
        private System.Windows.Forms.Button btnUnosStavki;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbNazivArtikla;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblNaziv;
    }
}