namespace Skladiste_ETI
{
    partial class frmArtikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtikli));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvMjesto = new System.Windows.Forms.DataGridView();
            this.idmjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoidmjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.txtSektor = new System.Windows.Forms.TextBox();
            this.txtPolica = new System.Windows.Forms.TextBox();
            this.lblSektor = new System.Windows.Forms.Label();
            this.lblPolica = new System.Windows.Forms.Label();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.grbUnosArtikla = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMjesto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbUnosArtikla.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(37, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 105);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(38, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 103);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnchange
            // 
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnchange.Image = ((System.Drawing.Image)(resources.GetObject("btnchange.Image")));
            this.btnchange.Location = new System.Drawing.Point(38, 274);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(111, 93);
            this.btnchange.TabIndex = 2;
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            this.btnchange.MouseHover += new System.EventHandler(this.btnchange_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(37, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 100);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // dgvMjesto
            // 
            this.dgvMjesto.AllowUserToAddRows = false;
            this.dgvMjesto.AllowUserToDeleteRows = false;
            this.dgvMjesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMjesto.AutoGenerateColumns = false;
            this.dgvMjesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmjestaDataGridViewTextBoxColumn,
            this.policaDataGridViewTextBoxColumn,
            this.sektorDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn});
            this.dgvMjesto.DataSource = this.mjestoBindingSource;
            this.dgvMjesto.Location = new System.Drawing.Point(373, 12);
            this.dgvMjesto.Name = "dgvMjesto";
            this.dgvMjesto.ReadOnly = true;
            this.dgvMjesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjesto.Size = new System.Drawing.Size(374, 132);
            this.dgvMjesto.TabIndex = 4;
            this.dgvMjesto.SelectionChanged += new System.EventHandler(this.dgvMjesto_SelectionChanged);
            // 
            // idmjestaDataGridViewTextBoxColumn
            // 
            this.idmjestaDataGridViewTextBoxColumn.DataPropertyName = "id_mjesta";
            this.idmjestaDataGridViewTextBoxColumn.HeaderText = "ID mjesta";
            this.idmjestaDataGridViewTextBoxColumn.Name = "idmjestaDataGridViewTextBoxColumn";
            this.idmjestaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // policaDataGridViewTextBoxColumn
            // 
            this.policaDataGridViewTextBoxColumn.DataPropertyName = "polica";
            this.policaDataGridViewTextBoxColumn.HeaderText = "Polica";
            this.policaDataGridViewTextBoxColumn.Name = "policaDataGridViewTextBoxColumn";
            this.policaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sektorDataGridViewTextBoxColumn
            // 
            this.sektorDataGridViewTextBoxColumn.DataPropertyName = "sektor";
            this.sektorDataGridViewTextBoxColumn.HeaderText = "Sektor";
            this.sektorDataGridViewTextBoxColumn.Name = "sektorDataGridViewTextBoxColumn";
            this.sektorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artikliDataGridViewTextBoxColumn
            // 
            this.artikliDataGridViewTextBoxColumn.DataPropertyName = "artikli";
            this.artikliDataGridViewTextBoxColumn.HeaderText = "artikli";
            this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
            this.artikliDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikliDataGridViewTextBoxColumn.Visible = false;
            // 
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataSource = typeof(Skladiste_ETI.mjesto);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.mjestoidmjestaDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.stavkeDataGridViewTextBoxColumn});
            this.dgvArtikli.DataSource = this.artikliBindingSource;
            this.dgvArtikli.Location = new System.Drawing.Point(373, 150);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(560, 348);
            this.dgvArtikli.TabIndex = 5;
            // 
            // idartiklaDataGridViewTextBoxColumn
            // 
            this.idartiklaDataGridViewTextBoxColumn.DataPropertyName = "id_artikla";
            this.idartiklaDataGridViewTextBoxColumn.HeaderText = "ID artikla";
            this.idartiklaDataGridViewTextBoxColumn.Name = "idartiklaDataGridViewTextBoxColumn";
            this.idartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena/kn";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina/paleta";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa/kg";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoidmjestaDataGridViewTextBoxColumn
            // 
            this.mjestoidmjestaDataGridViewTextBoxColumn.DataPropertyName = "mjesto_id_mjesta";
            this.mjestoidmjestaDataGridViewTextBoxColumn.HeaderText = "mjesto_id_mjesta";
            this.mjestoidmjestaDataGridViewTextBoxColumn.Name = "mjestoidmjestaDataGridViewTextBoxColumn";
            this.mjestoidmjestaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mjestoidmjestaDataGridViewTextBoxColumn.Visible = false;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mjestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeDataGridViewTextBoxColumn
            // 
            this.stavkeDataGridViewTextBoxColumn.DataPropertyName = "stavke";
            this.stavkeDataGridViewTextBoxColumn.HeaderText = "stavke";
            this.stavkeDataGridViewTextBoxColumn.Name = "stavkeDataGridViewTextBoxColumn";
            this.stavkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(Skladiste_ETI.artikli);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletePosition);
            this.groupBox1.Controls.Add(this.btnAddPosition);
            this.groupBox1.Controls.Add(this.txtSektor);
            this.groupBox1.Controls.Add(this.txtPolica);
            this.groupBox1.Controls.Add(this.lblSektor);
            this.groupBox1.Controls.Add(this.lblPolica);
            this.groupBox1.Location = new System.Drawing.Point(739, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos pozicije na skladištu";
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Location = new System.Drawing.Point(110, 91);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(75, 35);
            this.btnDeletePosition.TabIndex = 5;
            this.btnDeletePosition.Text = "Brisanje pozicije";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(25, 91);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(75, 35);
            this.btnAddPosition.TabIndex = 4;
            this.btnAddPosition.Text = "Unos pozicije";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // txtSektor
            // 
            this.txtSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSektor.Location = new System.Drawing.Point(85, 54);
            this.txtSektor.Name = "txtSektor";
            this.txtSektor.Size = new System.Drawing.Size(100, 21);
            this.txtSektor.TabIndex = 3;
            this.txtSektor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPolica
            // 
            this.txtPolica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPolica.Location = new System.Drawing.Point(85, 28);
            this.txtPolica.Name = "txtPolica";
            this.txtPolica.Size = new System.Drawing.Size(100, 21);
            this.txtPolica.TabIndex = 2;
            this.txtPolica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSektor
            // 
            this.lblSektor.AutoSize = true;
            this.lblSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSektor.ForeColor = System.Drawing.Color.Red;
            this.lblSektor.Location = new System.Drawing.Point(22, 55);
            this.lblSektor.Name = "lblSektor";
            this.lblSektor.Size = new System.Drawing.Size(57, 16);
            this.lblSektor.TabIndex = 1;
            this.lblSektor.Text = "Sektor:";
            // 
            // lblPolica
            // 
            this.lblPolica.AutoSize = true;
            this.lblPolica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPolica.ForeColor = System.Drawing.Color.Red;
            this.lblPolica.Location = new System.Drawing.Point(22, 29);
            this.lblPolica.Name = "lblPolica";
            this.lblPolica.Size = new System.Drawing.Size(56, 16);
            this.lblPolica.TabIndex = 0;
            this.lblPolica.Text = "Polica:";
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGoods.Image")));
            this.btnAddGoods.Location = new System.Drawing.Point(134, 170);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(64, 53);
            this.btnAddGoods.TabIndex = 16;
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            this.btnAddGoods.MouseHover += new System.EventHandler(this.btnAddGoods_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naziv:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cijena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Količina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Masa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(79, 25);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(119, 21);
            this.txtNaziv.TabIndex = 12;
            this.txtNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCijena.Location = new System.Drawing.Point(79, 51);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(119, 21);
            this.txtCijena.TabIndex = 13;
            this.txtCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKolicina.Location = new System.Drawing.Point(79, 77);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(119, 21);
            this.txtKolicina.TabIndex = 14;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMasa
            // 
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMasa.Location = new System.Drawing.Point(79, 103);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(119, 21);
            this.txtMasa.TabIndex = 15;
            this.txtMasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbUnosArtikla
            // 
            this.grbUnosArtikla.Controls.Add(this.label1);
            this.grbUnosArtikla.Controls.Add(this.cmbMjesto);
            this.grbUnosArtikla.Controls.Add(this.label5);
            this.grbUnosArtikla.Controls.Add(this.label6);
            this.grbUnosArtikla.Controls.Add(this.btnAddGoods);
            this.grbUnosArtikla.Controls.Add(this.txtMasa);
            this.grbUnosArtikla.Controls.Add(this.label7);
            this.grbUnosArtikla.Controls.Add(this.label8);
            this.grbUnosArtikla.Controls.Add(this.txtKolicina);
            this.grbUnosArtikla.Controls.Add(this.txtNaziv);
            this.grbUnosArtikla.Controls.Add(this.txtCijena);
            this.grbUnosArtikla.Location = new System.Drawing.Point(153, 12);
            this.grbUnosArtikla.Name = "grbUnosArtikla";
            this.grbUnosArtikla.Size = new System.Drawing.Size(214, 236);
            this.grbUnosArtikla.TabIndex = 17;
            this.grbUnosArtikla.TabStop = false;
            this.grbUnosArtikla.Text = "Unos artikla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pozicija:";
            // 
            // cmbMjesto
            // 
            this.cmbMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMjesto.FormattingEnabled = true;
            this.cmbMjesto.Location = new System.Drawing.Point(77, 129);
            this.cmbMjesto.Name = "cmbMjesto";
            this.cmbMjesto.Size = new System.Drawing.Size(121, 23);
            this.cmbMjesto.TabIndex = 17;
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(945, 510);
            this.Controls.Add(this.grbUnosArtikla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.dgvMjesto);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje artiklima";
            this.Load += new System.EventHandler(this.frmArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbUnosArtikla.ResumeLayout(false);
            this.grbUnosArtikla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvMjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.TextBox txtSektor;
        private System.Windows.Forms.TextBox txtPolica;
        private System.Windows.Forms.Label lblSektor;
        private System.Windows.Forms.Label lblPolica;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.GroupBox grbUnosArtikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoidmjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDataGridViewTextBoxColumn;
    }
}