namespace Skladiste_ETI.Administracija
{
    partial class frmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.idkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbDodajZaposlenika = new System.Windows.Forms.GroupBox();
            this.chkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.grbDodajZaposlenika.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkorisnikaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.brtelefonaDataGridViewTextBoxColumn,
            this.korimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn,
            this.tipkorisnikaDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.korisnikBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(212, 151);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(647, 255);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // idkorisnikaDataGridViewTextBoxColumn
            // 
            this.idkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.HeaderText = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.Name = "idkorisnikaDataGridViewTextBoxColumn";
            this.idkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brtelefonaDataGridViewTextBoxColumn
            // 
            this.brtelefonaDataGridViewTextBoxColumn.DataPropertyName = "br_telefona";
            this.brtelefonaDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.brtelefonaDataGridViewTextBoxColumn.Name = "brtelefonaDataGridViewTextBoxColumn";
            this.brtelefonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korimeDataGridViewTextBoxColumn
            // 
            this.korimeDataGridViewTextBoxColumn.DataPropertyName = "kor_ime";
            this.korimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korimeDataGridViewTextBoxColumn.Name = "korimeDataGridViewTextBoxColumn";
            this.korimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipkorisnikaidtipaDataGridViewTextBoxColumn
            // 
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn.DataPropertyName = "tip_korisnika_id_tipa";
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn.HeaderText = "tip_korisnika_id_tipa";
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn.Name = "tipkorisnikaidtipaDataGridViewTextBoxColumn";
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkorisnikaidtipaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipkorisnikaDataGridViewTextBoxColumn
            // 
            this.tipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.HeaderText = "tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.Name = "tipkorisnikaDataGridViewTextBoxColumn";
            this.tipkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Skladiste_ETI.korisnik);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(48, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 102);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(48, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 101);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(48, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 101);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // grbDodajZaposlenika
            // 
            this.grbDodajZaposlenika.Controls.Add(this.chkBoxAdmin);
            this.grbDodajZaposlenika.Controls.Add(this.txtStatus);
            this.grbDodajZaposlenika.Controls.Add(this.txtLozinka);
            this.grbDodajZaposlenika.Controls.Add(this.txtKorIme);
            this.grbDodajZaposlenika.Controls.Add(this.txtBrTelefona);
            this.grbDodajZaposlenika.Controls.Add(this.txtPrezime);
            this.grbDodajZaposlenika.Controls.Add(this.txtIme);
            this.grbDodajZaposlenika.Controls.Add(this.label6);
            this.grbDodajZaposlenika.Controls.Add(this.label5);
            this.grbDodajZaposlenika.Controls.Add(this.label4);
            this.grbDodajZaposlenika.Controls.Add(this.label3);
            this.grbDodajZaposlenika.Controls.Add(this.label2);
            this.grbDodajZaposlenika.Controls.Add(this.label1);
            this.grbDodajZaposlenika.Controls.Add(this.btnOK);
            this.grbDodajZaposlenika.Location = new System.Drawing.Point(212, 12);
            this.grbDodajZaposlenika.Name = "grbDodajZaposlenika";
            this.grbDodajZaposlenika.Size = new System.Drawing.Size(647, 133);
            this.grbDodajZaposlenika.TabIndex = 4;
            this.grbDodajZaposlenika.TabStop = false;
            this.grbDodajZaposlenika.Text = "Unos zaposlenika";
            // 
            // chkBoxAdmin
            // 
            this.chkBoxAdmin.AutoSize = true;
            this.chkBoxAdmin.Location = new System.Drawing.Point(395, 110);
            this.chkBoxAdmin.Name = "chkBoxAdmin";
            this.chkBoxAdmin.Size = new System.Drawing.Size(88, 17);
            this.chkBoxAdmin.TabIndex = 13;
            this.chkBoxAdmin.Text = "Adiministrator";
            this.chkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(395, 76);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(128, 20);
            this.txtStatus.TabIndex = 12;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(395, 51);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(128, 20);
            this.txtLozinka.TabIndex = 11;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(395, 22);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(128, 20);
            this.txtKorIme.TabIndex = 10;
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Location = new System.Drawing.Point(117, 76);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(129, 20);
            this.txtBrTelefona.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(117, 50);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(129, 20);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(117, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(129, 20);
            this.txtIme.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lozinka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj telefona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(545, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 89);
            this.btnOK.TabIndex = 0;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseHover += new System.EventHandler(this.btnOK_MouseHover);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "tip_korisnika";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "Uloga";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 418);
            this.Controls.Add(this.grbDodajZaposlenika);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvZaposlenici);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija zaposlenika";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.grbDodajZaposlenika.ResumeLayout(false);
            this.grbDodajZaposlenika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbDodajZaposlenika;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtBrTelefona;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkBoxAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkorisnikaidtipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    }
}