using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_ETI.Administracija
{
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
            grbDodajZaposlenika.Visible = false;
        }

        
        /// <summary>
        /// prikazuje zaposlenike u datagridview kojemu je datasource lista zaposlenika iz db konteksta
        /// </summary>
        private void PrikaziZaposlenike() {

            BindingList<korisnik> listaZaposlenika = null;
            using (var db = new T02_DBEntities()){

                listaZaposlenika = new BindingList<korisnik>(db.korisnik.ToList());
            
            }
            
            korisnikBindingSource.DataSource = listaZaposlenika;

        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grbDodajZaposlenika.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using(var db = new T02_DBEntities()){

                korisnik zaposlenik = new korisnik 
                {
                    
                    ime = txtIme.Text,
                    prezime = txtPrezime.Text,
                    br_telefona = txtBrTelefona.Text,
                    kor_ime = txtKorIme.Text,
                    lozinka = txtLozinka.Text,
                    status = txtStatus.Text
                
                };

                db.korisnik.Add(zaposlenik);
                db.SaveChanges();

                if (chkBoxAdmin.Checked == true)
                {
                    string upit = string.Format("UPDATE korisnik SET tip_korisnika_id_tipa = 2 WHERE kor_ime = '{0}'", txtKorIme.Text);
                    db.Database.ExecuteSqlCommand(upit);
                    db.SaveChanges();
                }
                else
                {
                    string upit2 = string.Format("UPDATE korisnik SET tip_korisnika_id_tipa = 2 WHERE kor_ime = '{0}'", txtKorIme.Text);
                    db.Database.ExecuteSqlCommand(upit2);
                    db.SaveChanges();
                }
            
            }//using

            PrikaziZaposlenike();//osvježi listu nakon dodavanja
        
        }//click

        private void btnDelete_Click(object sender, EventArgs e)
        {

            korisnik odabraniZaposlenik = korisnikBindingSource.Current as korisnik;

            if (odabraniZaposlenik != null) {

                if (MessageBox.Show("Da li ste sigurni da želite obrisati zaposlenika?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new T02_DBEntities()) 
                    {
                        db.korisnik.Attach(odabraniZaposlenik);
                        db.korisnik.Remove(odabraniZaposlenik);
                        db.SaveChanges();
                    
                    }
                
                }
            
            }
            PrikaziZaposlenike();//prikazi zaposlenike nakon brisanja

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAdd, "Unos zaposlenika");

        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnDelete, "Brisanje zaposlenika");

        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnExit, "Izlaz");

        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnOK, "Potvrda unosa");
        }








    }
}
