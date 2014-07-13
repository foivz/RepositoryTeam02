using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_ETI.Dokumenti
{
    public partial class frmPredatniceIzDokumenata : Form
    {
        private int id_artiklaParametar = 0;
        private int dopremljenaKolicinaParametar = 0;
        private int dopremljenaMasaParametar = 0;
        int brojacGumba = 0;
        string id_skladistar;
        string id_partner;
        string naziv;
        int id_d = 0;
        T02_DBEntities context = new T02_DBEntities();
        List<korisnik> zaposlenici = new List<korisnik>();
        List<poslovni_partner> partner = new List<poslovni_partner>();
        List<artikli> roba = new List<artikli>();
        public frmPredatniceIzDokumenata(string transport,string osnova,string skladistar,string partneri,string id_skladistara,string id_partnera,string id_dok)
        {
            InitializeComponent();

            txtNacinDopreme.Text = transport;
            cmbOsnova.Text = osnova;
            btnUnosOtpremnice.Hide();
            textBox1.Text = skladistar ;
            textBox2.Text = partneri;
            id_skladistar = id_skladistara;
            id_partner = id_partnera;
            id_d = int.Parse(id_dok);
      
            using (var db = new T02_DBEntities())
            {
              
               string upit = string.Format("SELECT artikli_id_artikla FROM stavke WHERE dokument_id_dokumenta ='{0}'", id_dok);
               int count = (db.Database.SqlQuery<int>(upit).Count());
              
               string upit2= string.Format("select naziv from  artikli join stavke ON artikli.id_artikla=stavke.artikli_id_artikla AND dokument_id_dokumenta = '{0}'", id_dok);
                 for (int i = 0; i < count; i++)
                 {

                     cmbNazivArtikla.Items.Add(db.Database.SqlQuery<string>(upit2).ElementAtOrDefault(i));


                }
            
       
            }//using
       
        }//tu
        public class artikli
        {
            public int ida { get; set; }
            public string naziv_artikla { get; set; }
        }

        public class korisnik
        {
            public int id_zaposlenika { get; set; }
            public string zaposlenik { get; set; }
        }

        public class poslovni_partner
        {
            public int idPartnera { get; set; }
            public string pos_partner { get; set; }
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnosOtpremnice_Click_1(object sender, EventArgs e)
        {
            if (txtNacinDopreme.Text == "")
            {
                MessageBox.Show("Niste unijeli način dopreme robe!");
            }
            else
            {

                using (var db = new T02_DBEntities())
                {
                    DateTime datum1;
                    datum1 = dtpDatum.Value;

                    dokument dokument = new dokument

                    {

                        korisnik_id_korisnika = int.Parse(id_skladistar),
                        tip_dokumenta_id_tipa = 2,
                        poslovni_partner_id_partnera = int.Parse(id_partner),
                        datum = datum1,
                        stanje = "Kreirana",
                        osnova = cmbOsnova.Text,
                        način_trans = txtNacinDopreme.Text


                    };
                    db.dokument.Add(dokument);
                    db.SaveChanges();


                    


                }//using

            }//else
        }


        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Nemožete dva puta dodati istu stavku");
            }

            else
            {

                using (var db = new T02_DBEntities())
                {

                    brojacGumba++;
                    if (brojacGumba < 2)
                    {
                        btnUnosOtpremnice_Click_1(sender, e);
                    }
                    naziv = cmbNazivArtikla.SelectedItem.ToString();
                    string query3 = string.Format("select artikli.kolicina from artikli where naziv = '{0}'", naziv);
                    int kolicina = (db.Database.SqlQuery<int>(query3).FirstOrDefault<int>());



                    string query4 = string.Format("select artikli.masa from artikli where naziv = '{0}'", naziv);
                    int masaa = db.Database.SqlQuery<int>(query4).FirstOrDefault<int>();

                    string query5 = string.Format("select id_artikla from artikli where naziv = '{0}'", naziv);
                    int idArtikla = db.Database.SqlQuery<int>(query5).FirstOrDefault<int>();

                    string query6 = string.Format("select id_dokumenta from dokument ");
                    int id_doc = db.Database.SqlQuery<int>(query6).LastOrDefault<int>();



                   //dodavanje na skladiste
                        stavke stavke = new stavke
                        {
                            dokument_id_dokumenta = id_doc,
                            artikli_id_artikla = idArtikla,
                            kolicina = int.Parse(txtKolicina.Text),
                            masa = int.Parse(txtMasa.Text)

                        };
                        db.stavke.Add(stavke);

                        //spremi parametre za pohranjenu proceduru
                        id_artiklaParametar = idArtikla;
                        dopremljenaKolicinaParametar = int.Parse(txtKolicina.Text);
                        dopremljenaMasaParametar = int.Parse(txtMasa.Text);

                        //izvrši pohranjenu proceduru nakon zaprimanja robe na skladište
                        db.UpdateArtikliDoprema(id_artiklaParametar, dopremljenaKolicinaParametar, dopremljenaMasaParametar);

                        db.SaveChanges();

                        txtKolicina.Text = "";
                        txtMasa.Text = "";

                        MessageBox.Show("Predatnica je unesena!");


                   

                }//using

            }//else

        }

        //prosljedivanje kolicine i mase

        private void cmbNazivArtikla_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (var db = new T02_DBEntities())
            {
                naziv = cmbNazivArtikla.SelectedItem.ToString();
                string query5 = string.Format("select id_artikla from artikli where naziv = '{0}'", naziv);
                int idArtikla = db.Database.SqlQuery<int>(query5).FirstOrDefault<int>();

                string query7 = string.Format("select kolicina from stavke where dokument_id_dokumenta = '{0}' and artikli_id_artikla = '{1}' ", id_d, idArtikla);
                int idStavkaKolicina = db.Database.SqlQuery<int>(query7).FirstOrDefault<int>();

                string query8 = string.Format("select masa from stavke where dokument_id_dokumenta = '{0}'and artikli_id_artikla = '{1}' ", id_d, idArtikla);
                int idStavkaMasa = db.Database.SqlQuery<int>(query8).FirstOrDefault<int>();


                txtKolicina.Text = idStavkaKolicina.ToString();
                txtMasa.Text = idStavkaMasa.ToString();
            }
        }

      

       

       

      

      

      

       

     

    }
}
