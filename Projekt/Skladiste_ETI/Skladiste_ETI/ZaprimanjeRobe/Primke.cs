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
    public partial class frmPrimke : Form
    {
        public frmPrimke()
        {
            List<korisnik> zaposlenici = new List<korisnik>();
            
            InitializeComponent();

            using(var db = new T02_DBEntities())
            {
                cmbPartner.DataSource = db.poslovni_partner.ToList();
                cmbPartner.DisplayMember = "naziv";
                cmbPartner.ValueMember = "id_partnera";

                zaposlenici = db.korisnik.Take(20).Select(z => new korisnik()//napravi novu listu sa imenom i prezimenom
                {
                    id_zaposlenika = z.id_korisnika,
                    zaposlenik = z.ime + " " + z.prezime//ubaci u listu ime i prezime
                   

                }).ToList();

                cmbKorisnik.DataSource = zaposlenici;//prikaži listu sa imenom i prezimenom zaposlenika
                cmbKorisnik.DisplayMember = "zaposlenik";
                cmbKorisnik.ValueMember = "id_zaposlenika";


                cmbNazivArtikla.DataSource = db.artikli.ToList();
                cmbNazivArtikla.DisplayMember = "naziv";
                cmbNazivArtikla.ValueMember = "id_artikla";
                
                
            }//using
        }//konstruktor

        public class korisnik 
        {
            public int id_zaposlenika { get; set; }
            public string zaposlenik { get; set; }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
