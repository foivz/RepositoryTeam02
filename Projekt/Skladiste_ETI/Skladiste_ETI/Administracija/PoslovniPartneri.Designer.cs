﻿namespace Skladiste_ETI.Administracija
{
    partial class frmPartneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartneri));
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeletePartner = new System.Windows.Forms.Button();
            this.grbDodajPartnera = new System.Windows.Forms.GroupBox();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poslovnipartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idpartneraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDodajPartnera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddPartner.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPartner.Image")));
            this.btnAddPartner.Location = new System.Drawing.Point(42, 37);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(116, 102);
            this.btnAddPartner.TabIndex = 2;
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            this.btnAddPartner.MouseHover += new System.EventHandler(this.btnAddParner_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(42, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 101);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnDeletePartner
            // 
            this.btnDeletePartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePartner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeletePartner.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePartner.Image")));
            this.btnDeletePartner.Location = new System.Drawing.Point(42, 155);
            this.btnDeletePartner.Name = "btnDeletePartner";
            this.btnDeletePartner.Size = new System.Drawing.Size(116, 101);
            this.btnDeletePartner.TabIndex = 4;
            this.btnDeletePartner.UseVisualStyleBackColor = true;
            this.btnDeletePartner.Click += new System.EventHandler(this.btnDeletePartner_Click);
            this.btnDeletePartner.MouseHover += new System.EventHandler(this.btnDeletePartner_MouseHover);
            // 
            // grbDodajPartnera
            // 
            this.grbDodajPartnera.Controls.Add(this.txtBrTelefona);
            this.grbDodajPartnera.Controls.Add(this.txtAdresa);
            this.grbDodajPartnera.Controls.Add(this.txtNaziv);
            this.grbDodajPartnera.Controls.Add(this.label3);
            this.grbDodajPartnera.Controls.Add(this.label2);
            this.grbDodajPartnera.Controls.Add(this.label1);
            this.grbDodajPartnera.Controls.Add(this.btnOK);
            this.grbDodajPartnera.Location = new System.Drawing.Point(198, 12);
            this.grbDodajPartnera.Name = "grbDodajPartnera";
            this.grbDodajPartnera.Size = new System.Drawing.Size(393, 133);
            this.grbDodajPartnera.TabIndex = 6;
            this.grbDodajPartnera.TabStop = false;
            this.grbDodajPartnera.Text = "Unos poslovnog partnera";
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Location = new System.Drawing.Point(117, 76);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(129, 20);
            this.txtBrTelefona.TabIndex = 9;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(117, 50);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(129, 20);
            this.txtAdresa.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(117, 24);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(129, 20);
            this.txtNaziv.TabIndex = 7;
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
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(280, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 89);
            this.btnOK.TabIndex = 0;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseHover += new System.EventHandler(this.btnOK_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpartneraDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brtelefonaDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poslovnipartnerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(228, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(346, 237);
            this.dataGridView1.TabIndex = 7;
            // 
            // poslovnipartnerBindingSource
            // 
            this.poslovnipartnerBindingSource.DataSource = typeof(Skladiste_ETI.poslovni_partner);
            // 
            // idpartneraDataGridViewTextBoxColumn
            // 
            this.idpartneraDataGridViewTextBoxColumn.DataPropertyName = "id_partnera";
            this.idpartneraDataGridViewTextBoxColumn.HeaderText = "id_partnera";
            this.idpartneraDataGridViewTextBoxColumn.Name = "idpartneraDataGridViewTextBoxColumn";
            this.idpartneraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpartneraDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brtelefonaDataGridViewTextBoxColumn
            // 
            this.brtelefonaDataGridViewTextBoxColumn.DataPropertyName = "br_telefona";
            this.brtelefonaDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.brtelefonaDataGridViewTextBoxColumn.Name = "brtelefonaDataGridViewTextBoxColumn";
            this.brtelefonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmPartneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(605, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbDodajPartnera);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeletePartner);
            this.Controls.Add(this.btnAddPartner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPartneri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poslovni partneri";
            this.Load += new System.EventHandler(this.frmPartneri_Load);
            this.grbDodajPartnera.ResumeLayout(false);
            this.grbDodajPartnera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeletePartner;
        private System.Windows.Forms.GroupBox grbDodajPartnera;
        private System.Windows.Forms.TextBox txtBrTelefona;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartneraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poslovnipartnerBindingSource;
    }
}