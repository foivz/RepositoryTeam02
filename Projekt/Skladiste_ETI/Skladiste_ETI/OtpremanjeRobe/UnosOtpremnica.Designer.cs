namespace Skladiste_ETI.OtpremanjeRobe
{
    partial class frmUnosOtpremnica
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
            this.components = new System.ComponentModel.Container();
            this.lblIDArtikla = new System.Windows.Forms.Label();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.lblBrojSerije = new System.Windows.Forms.Label();
            this.lblIDSektora = new System.Windows.Forms.Label();
            this.lblPoslovniPartner = new System.Windows.Forms.Label();
            this.lblJedinicnaCijena = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.dataSet1 = new Skladiste_ETI.DataSet1();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new Skladiste_ETI.DataSet1TableAdapters.artikliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDArtikla
            // 
            this.lblIDArtikla.AutoSize = true;
            this.lblIDArtikla.Location = new System.Drawing.Point(38, 40);
            this.lblIDArtikla.Name = "lblIDArtikla";
            this.lblIDArtikla.Size = new System.Drawing.Size(52, 13);
            this.lblIDArtikla.TabIndex = 0;
            this.lblIDArtikla.Text = "ID artikla:";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(38, 62);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(68, 13);
            this.lblNazivArtikla.TabIndex = 1;
            this.lblNazivArtikla.Text = "Naziv artikla:";
            // 
            // lblBrojSerije
            // 
            this.lblBrojSerije.AutoSize = true;
            this.lblBrojSerije.Location = new System.Drawing.Point(38, 85);
            this.lblBrojSerije.Name = "lblBrojSerije";
            this.lblBrojSerije.Size = new System.Drawing.Size(55, 13);
            this.lblBrojSerije.TabIndex = 2;
            this.lblBrojSerije.Text = "Broj serije:";
            // 
            // lblIDSektora
            // 
            this.lblIDSektora.AutoSize = true;
            this.lblIDSektora.Location = new System.Drawing.Point(38, 109);
            this.lblIDSektora.Name = "lblIDSektora";
            this.lblIDSektora.Size = new System.Drawing.Size(59, 13);
            this.lblIDSektora.TabIndex = 3;
            this.lblIDSektora.Text = "ID sektora:";
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.Location = new System.Drawing.Point(38, 203);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(86, 13);
            this.lblPoslovniPartner.TabIndex = 4;
            this.lblPoslovniPartner.Text = "Poslovni partner:";
            // 
            // lblJedinicnaCijena
            // 
            this.lblJedinicnaCijena.AutoSize = true;
            this.lblJedinicnaCijena.Location = new System.Drawing.Point(38, 133);
            this.lblJedinicnaCijena.Name = "lblJedinicnaCijena";
            this.lblJedinicnaCijena.Size = new System.Drawing.Size(86, 13);
            this.lblJedinicnaCijena.TabIndex = 5;
            this.lblJedinicnaCijena.Text = "Jedinična cijena:";
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(38, 180);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(79, 13);
            this.lblUkupnaCijena.TabIndex = 6;
            this.lblUkupnaCijena.Text = "Ukupna cijena:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(38, 157);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 7;
            this.lblKolicina.Text = "Količina:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.artikliBindingSource;
            this.comboBox1.DisplayMember = "id_artikla";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(122, 154);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 9;
            this.txtKolicina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKolicina_KeyUp);
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(122, 177);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(100, 20);
            this.txtUkupnaCijena.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 200);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(122, 130);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(100, 20);
            this.txtJedinicnaCijena.TabIndex = 12;
            this.txtJedinicnaCijena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJedinicnaCijena_KeyUp);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "artikli";
            this.artikliBindingSource.DataSource = this.dataSet1;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // frmUnosOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 390);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.lblJedinicnaCijena);
            this.Controls.Add(this.lblPoslovniPartner);
            this.Controls.Add(this.lblIDSektora);
            this.Controls.Add(this.lblBrojSerije);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.lblIDArtikla);
            this.Name = "frmUnosOtpremnica";
            this.Text = "UnosOtpremnica";
            this.Load += new System.EventHandler(this.frmUnosOtpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDArtikla;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.Label lblBrojSerije;
        private System.Windows.Forms.Label lblIDSektora;
        private System.Windows.Forms.Label lblPoslovniPartner;
        private System.Windows.Forms.Label lblJedinicnaCijena;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private DataSet1TableAdapters.artikliTableAdapter artikliTableAdapter;

    }
}