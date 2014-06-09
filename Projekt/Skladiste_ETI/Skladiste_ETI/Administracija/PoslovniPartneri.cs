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
    public partial class frmPartneri : Form
    {
        public frmPartneri()
        {
            InitializeComponent();
            
        }

     

        private void btnDeletePartner_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnDeletePartner, "Brisanje partnera");
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

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            grbDodajPartnera.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PrikaziPartnere()
        {

            BindingList<poslovni_partner> listaPartnera = null;
            using (var db = new T02_DBEntities())
            {

                listaPartnera = new BindingList<poslovni_partner>(db.poslovni_partner.ToList());

            }

            poslovnipartnerBindingSource.DataSource = listaPartnera;

        }

        private void frmPartneri_Load(object sender, EventArgs e)
        {
            PrikaziPartnere();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Niste unijeli naziz poslovnog partnera!");
            }
            else if (txtAdresa.Text == "")
            {
                MessageBox.Show("Niste unijeli adresu partnera!");
            }
            else if (txtBrTelefona.Text == "")
            {
                MessageBox.Show("Niste unijeli broj telefona!");
            }
            else
            {
                using (var db = new T02_DBEntities())
                {

                    poslovni_partner partner = new poslovni_partner
                    {

                        naziv = txtNaziv.Text,
                        adresa = txtAdresa.Text,
                        br_telefona = txtBrTelefona.Text

                    };

                    db.poslovni_partner.Add(partner);
                    db.SaveChanges();

                }//using

                txtNaziv.Text = "";
                txtAdresa.Text = "";
                txtBrTelefona.Text = "";

                PrikaziPartnere();//prikazi partnere nakon unosa
                MessageBox.Show("Partner uspješno dodan!");
            }//else
        }//click

        private void btnDeletePartner_Click(object sender, EventArgs e)
        {
            poslovni_partner odabraniPartner = poslovnipartnerBindingSource.Current as poslovni_partner;

            if (odabraniPartner != null)
            {

                if (MessageBox.Show("Da li ste sigurni da želite obrisati partnera?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new T02_DBEntities())
                    {
                        db.poslovni_partner.Attach(odabraniPartner);
                        db.poslovni_partner.Remove(odabraniPartner);
                        db.SaveChanges();
                        PrikaziPartnere();//prikazi partnere nakon brisanja
                        MessageBox.Show("Partner uspješno obrisan!");

                    }

                }

            }
            
        }//click


    }
}
