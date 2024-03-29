﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_ETI.UpravljanjeArtiklima
{
    public partial class frmIzmjenaArtikla : Form
    {
        private artikli artiklZaIzmjenu;
        private string trenutna_poz;
        private string idArtikla;
        public frmIzmjenaArtikla(artikli artikl, string trenutna_pozicija, string id_artikla)
        {
            InitializeComponent();
            artiklZaIzmjenu = artikl;
            trenutna_poz = trenutna_pozicija;
            idArtikla = id_artikla;

            List<mjesto> pozicija = new List<mjesto>();

            using (var db = new T02_DBEntities())
            {
                pozicija = db.mjesto.AsEnumerable().Select(m => new mjesto()//napravi novu listu sa id i nazivom
                {
                    idMjesta = m.id_mjesta,
                    lista_mjesta = m.id_mjesta + " | " + m.polica + " | " + m.sektor

                }).ToList();

                cmbNovaPozicija.DataSource = pozicija;
                cmbNovaPozicija.DisplayMember = "lista_mjesta";
                cmbNovaPozicija.ValueMember = "idMjesta";
            }
        }

        private void frmIzmjenaArtikla_Load(object sender, EventArgs e)
        {
            if (artiklZaIzmjenu != null) 
            {

                txtNazivZaIzmjenu.Text = artiklZaIzmjenu.naziv;
                txtCijenaZaIzmjenu.Text = artiklZaIzmjenu.cijena.ToString();
                txtKolicinaZaIzmjenu.Text = artiklZaIzmjenu.kolicina.ToString();
                txtMasaZaIzmjenu.Text = artiklZaIzmjenu.masa.ToString();
                txtTrenutnaPozicija.Text = trenutna_poz.ToString();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using(var db = new T02_DBEntities())
            {
                string idNovePozicije = "";

                foreach (char a in cmbNovaPozicija.Text)
                {
                    if (a == ' ') break;
                    else 
                    {
                        idNovePozicije += a;
                    }
                }

                db.artikli.Attach(artiklZaIzmjenu);

                artiklZaIzmjenu.naziv = txtNazivZaIzmjenu.Text;
                artiklZaIzmjenu.cijena = float.Parse(txtCijenaZaIzmjenu.Text);
                artiklZaIzmjenu.kolicina = int.Parse(txtKolicinaZaIzmjenu.Text);
                artiklZaIzmjenu.masa = int.Parse(txtMasaZaIzmjenu.Text);

                if(txtTrenutnaPozicija.Text != cmbNovaPozicija.Text && chkChangePosition.Checked == true){
                string upit = string.Format("UPDATE artikli SET mjesto_id_mjesta = '{0}' WHERE id_artikla = '{1}'", idNovePozicije, idArtikla);
                db.Database.ExecuteSqlCommand(upit);
                }
                db.SaveChanges();
                MessageBox.Show("Podaci o artiklu su uspješno izmijenjeni!");
                this.Close();
            }//using
        }//click
 
    }

}
