using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_ETI
{
    public partial class frmMain : Form
    {

        int ulogaParametar = 0;
        public frmMain(string username)
        {
            
            InitializeComponent();
            
            
            using (var db = new T02_DBEntities()) 
            
            {
                //formatira string upita sa parametrom username kojeg mu proslijeđuje konstruktor
                string upit = string.Format("SELECT tip_korisnika_id_tipa FROM korisnik WHERE kor_ime = '{0}'", username);
                
                
                int uloga = db.Database.SqlQuery<int>(upit).FirstOrDefault<int>();//dohvaća id_tipa iz konteksta T02_DBEntities
                ulogaParametar = uloga;
                if (uloga == 1)
                {

                    lblUloga.Text = "Skladištar";
                    btnZaposlenici.Visible = false;
                    btnPartneri.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    administracijaToolStripMenuItem.Visible = false;
                    
                }
                else if (uloga == 2) {

                    lblUloga.Text = "Administrator";
                    btnZaposlenici.Visible = true;
                    btnPartneri.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    btnArtikli.Visible = false;
                    btnOtpremanje.Visible = false;
                    btnZaprimanje.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    administracijaToolStripMenuItem.Visible = true;
                    upravljanjeArtiklimaToolStripMenuItem.Visible = false;
                    otpremanjeRobeToolStripMenuItem.Visible = false;
                    zaprimanjeRobeToolStripMenuItem.Visible = false;
                    btnZaposlenici.Location = new System.Drawing.Point(86, 232);
                    btnPartneri.Location = new System.Drawing.Point(296, 232);
                    btnPregledDokumenata.Location = new System.Drawing.Point(482, 232);
                    label11.Location = new System.Drawing.Point(115, 391);
                    label12.Location = new System.Drawing.Point(327, 391);
                    label13.Location = new System.Drawing.Point(505, 391);
                
                }
                
            }
         
            this.lblUser.Text = UserInformation.CurrentLoggedInUser;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label8.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label9.Text = DateTime.Now.DayOfWeek.ToString();
            

        }//konstruktor

        private void btnArtikl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnArtikli, "Upravljanje artiklima");
        }

        private void btnOtpremanje_MouseHover(object sender, EventArgs e)
        {

            btnOtpremanje.Visible = false;
            btnIzdatnica.Visible = true;
            btnOtpremnica.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label6.Visible = false;
        }

        private void btnZaprimanje_MouseHover(object sender, EventArgs e)
        {
            btnZaprimanje.Visible = false;
            btnPredatnica.Visible = true;
            btnPrimka.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label7.Visible = false;
        }

   

        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
           // new frmOtpremnice().Show();
           
        }

        private void btnIzdatnica_Click(object sender, EventArgs e)
        {
            //new frmIzdatnice().Show();
            
        }

        private void btnPrimka_Click(object sender, EventArgs e)
        {
            new frmPrimke().Show();
            
        }

        private void btnPredatnica_Click(object sender, EventArgs e)
        {
            new frmPredatnice().Show();
            
        }

        private void btnOtpremnica_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnOtpremnica, "Izraditi otpremnice");
        }

        private void btnIzdatnice_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnIzdatnica, "Izraditi izdatnice");
        }

        private void btnPrimka_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPrimka, "Izraditi primke");
        }

        private void btnPredatnica_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPredatnica, "Izraditi predatnice");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin prijava = new frmLogin();
            prijava.Show();
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOff_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnLogOff, "Odjava");
        }

        private void btnZaposlenici_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnZaposlenici, "Administracija zaposlenika");
        }

        private void btnPartneri_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPartneri, "Poslovni partneri");
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            Administracija.frmZaposlenici zaposlenici = new Administracija.frmZaposlenici();
            zaposlenici.Show();
        }

        private void btnPartneri_Click(object sender, EventArgs e)
        {
            Administracija.frmPartneri partneri = new Administracija.frmPartneri();
            partneri.Show();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            new frmArtikli().Show();
        }

        private void btnPregledDokumenata_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPregledDokumenata, "Pregled dokumenata skladišta");

        }

        private void btnPregledDokumenata_Click(object sender, EventArgs e)
        {
            new Dokumenti.frmPregledDokumenata(ulogaParametar).Show();
        }

 
    }
}
