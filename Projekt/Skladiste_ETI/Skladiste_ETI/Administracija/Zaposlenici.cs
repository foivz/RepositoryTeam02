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
            
            }
        }


    }
}
