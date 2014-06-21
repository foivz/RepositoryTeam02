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

            foreach (DataGridViewColumn c in dgvZaposlenici.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16, GraphicsUnit.Pixel);
            }

        }

        
        /// <summary>
        /// prikazuje zaposlenike u datagridview kojemu je datasource lista zaposlenika iz db konteksta
        /// </summary>
        private void PrikaziZaposlenike(tip_korisnika uloga) {

            BindingList<korisnik> korisnici = null;
            using (var db = new T02_DBEntities())
            {
                db.tip_korisnika.Attach(uloga);
                korisnici = new BindingList<korisnik>(uloga.korisnik.ToList<korisnik>());
                
            }
            korisnikBindingSource.DataSource = korisnici;
            
        }

        /// <summary>
        /// prikazuje moguće tipove korisnika u sustavu
        /// </summary>
        private void PrikaziTipKorisnika()
        {

            BindingList<tip_korisnika> uloga = null;
            using (var db = new T02_DBEntities())
            {
                uloga = new BindingList<tip_korisnika>(db.tip_korisnika.ToList<tip_korisnika>());

            }
            tipkorisnikaBindingSource.DataSource = uloga;

        }

        private void dgvUloga_SelectionChanged(object sender, EventArgs e)
        {
            tip_korisnika selektiraniTip = tipkorisnikaBindingSource.Current as tip_korisnika;
            if (selektiraniTip != null)
            {
                PrikaziZaposlenike(selektiraniTip);
            }
        }


        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            PrikaziTipKorisnika();
            PrikaziZaposlenike(tipkorisnikaBindingSource.Current as tip_korisnika);
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "") 
            {
                MessageBox.Show("Niste unijeli ime zaposlenika!");
            }
            else if (txtPrezime.Text == "") 
            {
                MessageBox.Show("Niste unijeli prezime zaposlenika!");
            }
            else if (txtBrTelefona.Text == "")
            {
                MessageBox.Show("Niste unijeli broj telefona!");
            }
            else if (txtKorIme.Text == "")
            {
                MessageBox.Show("Niste unijeli korisničko ime zapsolenika!");
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!");
            }
            else if (txtStatus.Text == "")
            {
                MessageBox.Show("Niste unijeli status!");
            }

            else
            {

                using (var db = new T02_DBEntities())
                {

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
                        string upit2 = string.Format("UPDATE korisnik SET tip_korisnika_id_tipa = 1 WHERE kor_ime = '{0}'", txtKorIme.Text);
                        db.Database.ExecuteSqlCommand(upit2);
                        db.SaveChanges();
                    }

                    PrikaziTipKorisnika();
                    PrikaziZaposlenike(tipkorisnikaBindingSource.Current as tip_korisnika);
                    MessageBox.Show("Zaposlenik uspješno dodan!");

                }//using



                txtIme.Text = "";
                txtPrezime.Text = "";
                txtBrTelefona.Text = "";
                txtKorIme.Text = "";
                txtLozinka.Text = "";
                txtStatus.Text = "";
                chkBoxAdmin.Checked = false;

            }//else
        }//click

        
        private void btnDelete_Click(object sender, EventArgs e)
        {

            korisnik odabraniZaposlenik = korisnikBindingSource.Current as korisnik;

            if (odabraniZaposlenik != null) {

                if (MessageBox.Show("Da li ste sigurni da želite obrisati zaposlenika?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new T02_DBEntities())
                        {
                            db.korisnik.Attach(odabraniZaposlenik);//registracija odabranog zaposlenika iz datagridviewa
                            db.korisnik.Remove(odabraniZaposlenik);
                            db.SaveChanges();
                            PrikaziTipKorisnika();
                            PrikaziZaposlenike(tipkorisnikaBindingSource.Current as tip_korisnika);
                            MessageBox.Show("Zaposlenik uspješno obrisan!");

                        }

                    }
                    catch 
                    {
                        MessageBox.Show("Ne možete obrisati korisnika koji je kreirao dokumente!");
                    }
                
                }
            
            }
            

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



        public string vbCrLf { get; set; }
    }
}
