﻿namespace Skladiste_ETI
{
    partial class frmSkladisnicaIzvjestaj
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T02_DBDataSet = new Skladiste_ETI.T02_DBDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new Skladiste_ETI.T02_DBDataSetTableAdapters.artikliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T02_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.artikliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skladiste_ETI.SkladisnicaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(871, 608);
            this.reportViewer1.TabIndex = 0;
            // 
            // T02_DBDataSet
            // 
            this.T02_DBDataSet.DataSetName = "T02_DBDataSet";
            this.T02_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "artikli";
            this.artikliBindingSource.DataSource = this.T02_DBDataSet;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // frmSkladisnicaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 608);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmSkladisnicaIzvjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladišnica";
            this.Load += new System.EventHandler(this.SkladisnicaIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T02_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T02_DBDataSet T02_DBDataSet;
        private T02_DBDataSetTableAdapters.artikliTableAdapter artikliTableAdapter;
    }
}