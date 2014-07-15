namespace Skladiste_ETI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnArtikli = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUlogiran = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeArtiklimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovniPartneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledDokumenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnPartneri = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPregledDokumenata = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArtikli
            // 
            this.btnArtikli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnArtikli.FlatAppearance.BorderSize = 0;
            this.btnArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikli.Image = ((System.Drawing.Image)(resources.GetObject("btnArtikli.Image")));
            this.btnArtikli.Location = new System.Drawing.Point(97, 240);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(141, 139);
            this.btnArtikli.TabIndex = 1;
            this.btnArtikli.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnArtikli.UseVisualStyleBackColor = false;
            this.btnArtikli.Click += new System.EventHandler(this.btnArtikli_Click);
            this.btnArtikli.MouseHover += new System.EventHandler(this.btnArtikl_MouseHover);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(334, 70);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(129, 32);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "UserName";
            // 
            // lblUlogiran
            // 
            this.lblUlogiran.AutoSize = true;
            this.lblUlogiran.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlogiran.ForeColor = System.Drawing.Color.Red;
            this.lblUlogiran.Location = new System.Drawing.Point(113, 70);
            this.lblUlogiran.Name = "lblUlogiran";
            this.lblUlogiran.Size = new System.Drawing.Size(215, 32);
            this.lblUlogiran.TabIndex = 10;
            this.lblUlogiran.Text = "Prijavljeni ste kao:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 201);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.Red;
            this.lblZaposlenik.Location = new System.Drawing.Point(113, 102);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(85, 32);
            this.lblZaposlenik.TabIndex = 12;
            this.lblZaposlenik.Text = "Uloga:";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUloga.ForeColor = System.Drawing.Color.Red;
            this.lblUloga.Location = new System.Drawing.Point(334, 102);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(79, 32);
            this.lblUloga.TabIndex = 13;
            this.lblUloga.Text = "Uloga";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacijaToolStripMenuItem,
            this.upravljanjeArtiklimaToolStripMenuItem,
            this.administracijaToolStripMenuItem,
            this.pregledDokumenataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click_1);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // upravljanjeArtiklimaToolStripMenuItem
            // 
            this.upravljanjeArtiklimaToolStripMenuItem.Name = "upravljanjeArtiklimaToolStripMenuItem";
            this.upravljanjeArtiklimaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.upravljanjeArtiklimaToolStripMenuItem.Text = "Upravljanje artiklima";
            this.upravljanjeArtiklimaToolStripMenuItem.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.poslovniPartneriToolStripMenuItem});
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // poslovniPartneriToolStripMenuItem
            // 
            this.poslovniPartneriToolStripMenuItem.Name = "poslovniPartneriToolStripMenuItem";
            this.poslovniPartneriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.poslovniPartneriToolStripMenuItem.Text = "Poslovni partneri";
            this.poslovniPartneriToolStripMenuItem.Click += new System.EventHandler(this.btnPartneri_Click);
            // 
            // pregledDokumenataToolStripMenuItem
            // 
            this.pregledDokumenataToolStripMenuItem.Name = "pregledDokumenataToolStripMenuItem";
            this.pregledDokumenataToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.pregledDokumenataToolStripMenuItem.Text = "Pregled dokumenata";
            this.pregledDokumenataToolStripMenuItem.Click += new System.EventHandler(this.btnPregledDokumenata_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Upravljanje artiklima";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(974, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "datum";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1081, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "dan";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(889, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Today:";
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOff.Image")));
            this.btnLogOff.Location = new System.Drawing.Point(506, 70);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(96, 85);
            this.btnLogOff.TabIndex = 24;
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            this.btnLogOff.MouseHover += new System.EventHandler(this.btnLogOff_MouseHover);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZaposlenici.Image = ((System.Drawing.Image)(resources.GetObject("btnZaposlenici.Image")));
            this.btnZaposlenici.Location = new System.Drawing.Point(310, 537);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(165, 144);
            this.btnZaposlenici.TabIndex = 25;
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            this.btnZaposlenici.MouseHover += new System.EventHandler(this.btnZaposlenici_MouseHover);
            // 
            // btnPartneri
            // 
            this.btnPartneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartneri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPartneri.Image = ((System.Drawing.Image)(resources.GetObject("btnPartneri.Image")));
            this.btnPartneri.Location = new System.Drawing.Point(506, 540);
            this.btnPartneri.Name = "btnPartneri";
            this.btnPartneri.Size = new System.Drawing.Size(149, 141);
            this.btnPartneri.TabIndex = 26;
            this.btnPartneri.UseVisualStyleBackColor = true;
            this.btnPartneri.Click += new System.EventHandler(this.btnPartneri_Click);
            this.btnPartneri.MouseHover += new System.EventHandler(this.btnPartneri_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(363, 695);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Zaposlenici";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(531, 695);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Poslovni partneri";
            // 
            // btnPregledDokumenata
            // 
            this.btnPregledDokumenata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledDokumenata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPregledDokumenata.Image = ((System.Drawing.Image)(resources.GetObject("btnPregledDokumenata.Image")));
            this.btnPregledDokumenata.Location = new System.Drawing.Point(310, 264);
            this.btnPregledDokumenata.Name = "btnPregledDokumenata";
            this.btnPregledDokumenata.Size = new System.Drawing.Size(153, 115);
            this.btnPregledDokumenata.TabIndex = 29;
            this.btnPregledDokumenata.UseVisualStyleBackColor = true;
            this.btnPregledDokumenata.Click += new System.EventHandler(this.btnPregledDokumenata_Click);
            this.btnPregledDokumenata.MouseHover += new System.EventHandler(this.btnPregledDokumenata_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Pregled dokumenata";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1220, 741);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPregledDokumenata);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPartneri);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUlogiran);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnArtikli);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Digital - Standard Edition";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUlogiran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeArtiklimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslovniPartneriToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnPartneri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPregledDokumenata;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem pregledDokumenataToolStripMenuItem;
    }
}