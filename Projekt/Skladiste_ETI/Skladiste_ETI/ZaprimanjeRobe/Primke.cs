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
            List<artikli> roba = new List<artikli>();
            InitializeComponent();

            using(var db = new T02_DBEntities())
            {
                cmbPartner.DataSource = db.poslovni_partner.ToList();
                cmbPartner.DisplayMember = "naziv";
                cmbPartner.ValueMember = "id_partnera";

                zaposlenici = db.korisnik.Select(z => new korisnik()//napravi novu listu sa imenom i prezimenom
                {
                    id_zaposlenika = z.id_korisnika,
                    zaposlenik = z.ime + " " + z.prezime//ubaci u listu ime i prezime
                   

                }).ToList();

                cmbKorisnik.DataSource = zaposlenici;//prikaži listu sa imenom i prezimenom zaposlenika
                cmbKorisnik.DisplayMember = "zaposlenik";
                cmbKorisnik.ValueMember = "id_zaposlenika";


                roba = db.artikli.AsEnumerable().Select(a => new artikli()//napravi novu listu sa id i nazivom artikla
                {
                    ida = a.id_artikla,
                    naziv_artikla= a.id_artikla + " | " + a.naziv//ubaci u listu id i naziv


                }).ToList();

                cmbNazivArtikla.DataSource = roba;//prikazi listu sa id i nazivom artikla
                cmbNazivArtikla.DisplayMember = "naziv_artikla";
                cmbNazivArtikla.ValueMember = "ida";
                
            }//using
        }//konstruktor

        public class korisnik 
        {
            public int id_zaposlenika { get; set; }
            public string zaposlenik { get; set; }
        }

        public class artikli
        {
            public int ida { get; set; }
            public string naziv_artikla { get; set; }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnOK, "Potvrda unosa primke");
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnExit, "Izlaz");
        }




    }
}
