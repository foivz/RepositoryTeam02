using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_ETI.OtpremanjeRobe
{
    public partial class frmOtpremnica : Form
    {
        List<korisnik> zaposlenici = new List<korisnik>();
        List<artikli> roba = new List<artikli>();
        List<poslovni_partner> partner = new List<poslovni_partner>();
        List<dokument> dokumentPrikaz = new List<dokument>();


        public frmOtpremnica()
        {
            InitializeComponent();


            using (var db = new T02_DBEntities())
            {
                partner = db.poslovni_partner.AsEnumerable().Select(p => new poslovni_partner()   //napravljena nova lista sa id-om i nazivom
                {
                    idPartnera = p.id_partnera,
                    pos_partner = p.id_partnera + " " + p.naziv
                }).ToList();

                cmbPartner.DataSource = partner;
                cmbPartner.DisplayMember = "pos_partner";
                cmbPartner.ValueMember = "idPartnera";


                zaposlenici = db.korisnik.AsEnumerable().Select(z => new korisnik()   //napravljena nova lista sa imenom i prezimenom
                {
                    id_zaposlenika = z.id_korisnika,
                    zaposlenik = z.id_korisnika + " " + z.ime + " " + z.prezime   //ubaci u listu ime i prezime
                }).ToList();

                cmbKorisnik.DataSource = zaposlenici;   //prikaži listu sa imenom i prezimenom zaposlenika
                cmbKorisnik.DisplayMember = "zaposlenik";
                cmbKorisnik.ValueMember = "id_zaposlenika";


                roba = db.artikli.AsEnumerable().Select(a => new artikli()   //napravljena nova lista sa id-om i nazivom artikla
                {
                    ida = a.id_artikla,
                    naziv_artikla = a.id_artikla + " | " + a.naziv + " | Na skladištu: " + a.kolicina   //ubaci u listu id, naziv i količinu na skladištu
                }).ToList();

                cmbNazivArtikla.DataSource = roba;   //prikazi listu sa id-om i nazivom artikla
                cmbNazivArtikla.DisplayMember = "naziv_artikla";
                cmbNazivArtikla.ValueMember = "ida";


                dokumentPrikaz = db.dokument.AsEnumerable().Select(d => new dokument()
                {
                    idDok = d.id_dokumenta,
                    doc = d.id_dokumenta + " | Izdatnica br. " + d.id_dokumenta
                }).ToList();

                cmbOsnova.DataSource = dokumentPrikaz;
                cmbOsnova.DisplayMember = "doc";
                cmbOsnova.ValueMember = "idDok";


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

        public class poslovni_partner
        {
            public int idPartnera { get; set; }
            public string pos_partner { get; set; }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(this.btnExit, "Izlaz");
        }


        private void btnUnosOtpremnice_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip2 = new System.Windows.Forms.ToolTip();
            toolTip2.SetToolTip(this.btnUnosOtpremnice, "Unos podataka o otpremnici");
        }


        private void btnUnosStavki_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip3 = new System.Windows.Forms.ToolTip();
            toolTip3.SetToolTip(this.btnUnosStavki, "Unos stavki otpremnice");
        }


        private void btnUnosOtpremnice_Click(object sender, EventArgs e)
        {
            if (txtNacinDopreme.Text == "")
            {
                MessageBox.Show("Niste unijeli način transporta robe!");
            }
            else
            {
                using (var db = new T02_DBEntities())
                {
                    DateTime datum1;
                    datum1 = dtpDatum.Value;
                    string idKorisnika = "";
                    string idPartnera1 = "";
                    string idDokumenta = "";
                    
                    foreach (char a in cmbKorisnik.Text)
                    {
                        if (a == ' ') break;
                        else
                        {
                            idKorisnika += a;
                        }
                    }

                    foreach (char a in cmbPartner.Text)
                    {
                        if (a == ' ') break;
                        else
                        {
                            idPartnera1 += a;
                        }
                    }

                    foreach (char a in cmbOsnova.Text)
                    {
                        if (a == ' ') break;
                        else
                        {
                            idDokumenta += a;
                        }
                    }

                    string query = string.Format("SELECT stanje FROM dokument WHERE id_dokumenta = '{0}'", idDokumenta);
                    string stanje = db.Database.SqlQuery<string>(query).FirstOrDefault<string>();


                    if (stanje == "Odobrena")
                    {
                        dokument dokument = new dokument
                        {
                            korisnik_id_korisnika = int.Parse(idKorisnika),
                            tip_dokumenta_id_tipa = 4,
                            poslovni_partner_id_partnera = int.Parse(idPartnera1),
                            datum = datum1,
                            stanje = "Kreirana",
                            osnova = cmbOsnova.Text,
                            način_trans = txtNacinDopreme.Text
                        };
                        db.dokument.Add(dokument);
                        db.SaveChanges();

                        txtNacinDopreme.Text = "";
                        MessageBox.Show("Otpremnica je uspješno unesena!");
                    }//if
                   
                    else
                    {
                        MessageBox.Show("Ne možete napraviti otpremnicu na temelju izdatnice koja nije odobrena!");
                    }

                }//using

            }//else

        }
    }
}
