namespace Skladiste_ETI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnArtikl = new System.Windows.Forms.Button();
            this.btnOtpremanje = new System.Windows.Forms.Button();
            this.btnZaprimanje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unesiArtiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremanjeRobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izraditiOtpremniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izraditiIzdatniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaprimanjeRobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izrdaPrimkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izradaPredatniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnIzdatnice = new System.Windows.Forms.Button();
            this.btnOtpremnica = new System.Windows.Forms.Button();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.btnPredatnica = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArtikl
            // 
            this.btnArtikl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArtikl.FlatAppearance.BorderSize = 0;
            this.btnArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikl.Image = ((System.Drawing.Image)(resources.GetObject("btnArtikl.Image")));
            this.btnArtikl.Location = new System.Drawing.Point(23, 126);
            this.btnArtikl.Name = "btnArtikl";
            this.btnArtikl.Size = new System.Drawing.Size(180, 156);
            this.btnArtikl.TabIndex = 1;
            this.btnArtikl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnArtikl.UseVisualStyleBackColor = false;
            this.btnArtikl.Click += new System.EventHandler(this.btnArtikl_Click);
            this.btnArtikl.MouseHover += new System.EventHandler(this.btnArtikl_MouseHover);
            // 
            // btnOtpremanje
            // 
            this.btnOtpremanje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtpremanje.FlatAppearance.BorderSize = 0;
            this.btnOtpremanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtpremanje.Image = ((System.Drawing.Image)(resources.GetObject("btnOtpremanje.Image")));
            this.btnOtpremanje.Location = new System.Drawing.Point(210, 126);
            this.btnOtpremanje.Name = "btnOtpremanje";
            this.btnOtpremanje.Size = new System.Drawing.Size(180, 156);
            this.btnOtpremanje.TabIndex = 2;
            this.btnOtpremanje.UseVisualStyleBackColor = false;
            this.btnOtpremanje.Click += new System.EventHandler(this.btnOtpremanje_Click);
            this.btnOtpremanje.MouseHover += new System.EventHandler(this.btnOtpremanje_MouseHover);
            // 
            // btnZaprimanje
            // 
            this.btnZaprimanje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZaprimanje.FlatAppearance.BorderSize = 0;
            this.btnZaprimanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaprimanje.Image = ((System.Drawing.Image)(resources.GetObject("btnZaprimanje.Image")));
            this.btnZaprimanje.Location = new System.Drawing.Point(396, 126);
            this.btnZaprimanje.Name = "btnZaprimanje";
            this.btnZaprimanje.Size = new System.Drawing.Size(180, 156);
            this.btnZaprimanje.TabIndex = 3;
            this.btnZaprimanje.UseVisualStyleBackColor = false;
            this.btnZaprimanje.Click += new System.EventHandler(this.btnZaprimanje_Click);
            this.btnZaprimanje.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiArtiklToolStripMenuItem,
            this.otpremanjeRobeToolStripMenuItem,
            this.zaprimanjeRobeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unesiArtiklToolStripMenuItem
            // 
            this.unesiArtiklToolStripMenuItem.Name = "unesiArtiklToolStripMenuItem";
            this.unesiArtiklToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.unesiArtiklToolStripMenuItem.Text = "Upravljanje artiklima";
            this.unesiArtiklToolStripMenuItem.Click += new System.EventHandler(this.unesiArtiklToolStripMenuItem_Click);
            // 
            // otpremanjeRobeToolStripMenuItem
            // 
            this.otpremanjeRobeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izraditiOtpremniceToolStripMenuItem,
            this.izraditiIzdatniceToolStripMenuItem});
            this.otpremanjeRobeToolStripMenuItem.Name = "otpremanjeRobeToolStripMenuItem";
            this.otpremanjeRobeToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.otpremanjeRobeToolStripMenuItem.Text = "Otpremanje robe";
            // 
            // izraditiOtpremniceToolStripMenuItem
            // 
            this.izraditiOtpremniceToolStripMenuItem.Name = "izraditiOtpremniceToolStripMenuItem";
            this.izraditiOtpremniceToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.izraditiOtpremniceToolStripMenuItem.Text = "Izraditi otpremnice";
            this.izraditiOtpremniceToolStripMenuItem.Click += new System.EventHandler(this.izraditiOtpremniceToolStripMenuItem_Click);
            // 
            // izraditiIzdatniceToolStripMenuItem
            // 
            this.izraditiIzdatniceToolStripMenuItem.Name = "izraditiIzdatniceToolStripMenuItem";
            this.izraditiIzdatniceToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.izraditiIzdatniceToolStripMenuItem.Text = "Izraditi izdatnice";
            this.izraditiIzdatniceToolStripMenuItem.Click += new System.EventHandler(this.izraditiIzdatniceToolStripMenuItem_Click);
            // 
            // zaprimanjeRobeToolStripMenuItem
            // 
            this.zaprimanjeRobeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izrdaPrimkeToolStripMenuItem,
            this.izradaPredatniceToolStripMenuItem});
            this.zaprimanjeRobeToolStripMenuItem.Name = "zaprimanjeRobeToolStripMenuItem";
            this.zaprimanjeRobeToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.zaprimanjeRobeToolStripMenuItem.Text = "Zaprimanje robe";
            // 
            // izrdaPrimkeToolStripMenuItem
            // 
            this.izrdaPrimkeToolStripMenuItem.Name = "izrdaPrimkeToolStripMenuItem";
            this.izrdaPrimkeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.izrdaPrimkeToolStripMenuItem.Text = "Izrada primke";
            this.izrdaPrimkeToolStripMenuItem.Click += new System.EventHandler(this.izrdaPrimkeToolStripMenuItem_Click);
            // 
            // izradaPredatniceToolStripMenuItem
            // 
            this.izradaPredatniceToolStripMenuItem.Name = "izradaPredatniceToolStripMenuItem";
            this.izradaPredatniceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.izradaPredatniceToolStripMenuItem.Text = "Izrada predatnice";
            this.izradaPredatniceToolStripMenuItem.Click += new System.EventHandler(this.izradaPredatniceToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ovdje ide ime prijavljenog";
            // 
            // btnIzdatnice
            // 
            this.btnIzdatnice.FlatAppearance.BorderSize = 0;
            this.btnIzdatnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdatnice.Image = ((System.Drawing.Image)(resources.GetObject("btnIzdatnice.Image")));
            this.btnIzdatnice.Location = new System.Drawing.Point(232, 208);
            this.btnIzdatnice.Name = "btnIzdatnice";
            this.btnIzdatnice.Size = new System.Drawing.Size(127, 124);
            this.btnIzdatnice.TabIndex = 6;
            this.btnIzdatnice.UseVisualStyleBackColor = true;
            this.btnIzdatnice.Visible = false;
            // 
            // btnOtpremnica
            // 
            this.btnOtpremnica.FlatAppearance.BorderSize = 0;
            this.btnOtpremnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtpremnica.Image = ((System.Drawing.Image)(resources.GetObject("btnOtpremnica.Image")));
            this.btnOtpremnica.Location = new System.Drawing.Point(232, 73);
            this.btnOtpremnica.Name = "btnOtpremnica";
            this.btnOtpremnica.Size = new System.Drawing.Size(127, 129);
            this.btnOtpremnica.TabIndex = 7;
            this.btnOtpremnica.UseVisualStyleBackColor = true;
            this.btnOtpremnica.Visible = false;
            // 
            // btnPrimka
            // 
            this.btnPrimka.FlatAppearance.BorderSize = 0;
            this.btnPrimka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimka.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimka.Image")));
            this.btnPrimka.Location = new System.Drawing.Point(422, 73);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(127, 129);
            this.btnPrimka.TabIndex = 8;
            this.btnPrimka.UseVisualStyleBackColor = true;
            this.btnPrimka.Visible = false;
            // 
            // btnPredatnica
            // 
            this.btnPredatnica.FlatAppearance.BorderSize = 0;
            this.btnPredatnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredatnica.Image = ((System.Drawing.Image)(resources.GetObject("btnPredatnica.Image")));
            this.btnPredatnica.Location = new System.Drawing.Point(422, 208);
            this.btnPredatnica.Name = "btnPredatnica";
            this.btnPredatnica.Size = new System.Drawing.Size(127, 124);
            this.btnPredatnica.TabIndex = 9;
            this.btnPredatnica.UseVisualStyleBackColor = true;
            this.btnPredatnica.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(638, 369);
            this.Controls.Add(this.btnPredatnica);
            this.Controls.Add(this.btnPrimka);
            this.Controls.Add(this.btnOtpremnica);
            this.Controls.Add(this.btnIzdatnice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZaprimanje);
            this.Controls.Add(this.btnOtpremanje);
            this.Controls.Add(this.btnArtikl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArtikl;
        private System.Windows.Forms.Button btnOtpremanje;
        private System.Windows.Forms.Button btnZaprimanje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unesiArtiklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otpremanjeRobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izraditiOtpremniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izraditiIzdatniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaprimanjeRobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izrdaPrimkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izradaPredatniceToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnIzdatnice;
        private System.Windows.Forms.Button btnOtpremnica;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.Button btnPredatnica;
    }
}