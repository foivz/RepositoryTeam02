﻿using System;
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
    public partial class frmIzdatnice : Form
    {

        public frmIzdatnice()
        {

            List<korisnik> zaposlenici = new List<korisnik>();
            List<artikli> roba = new List<artikli>();
            List<poslovni_partner> partner = new List<poslovni_partner>();
            InitializeComponent();


            using (var db = new T02_DBEntities())
            {

                partner = db.poslovni_partner.AsEnumerable().Select(p => new poslovni_partner()//napravi novu listu sa id i nazivom
                {
                    idPartnera = p.id_partnera,
                    pos_partner = p.id_partnera + " " + p.naziv

                }).ToList();

                cmbPartner.DataSource = partner;
                cmbPartner.DisplayMember = "pos_partner";
                cmbPartner.ValueMember = "idPartnera";

                zaposlenici = db.korisnik.AsEnumerable().Select(z => new korisnik()//napravi novu listu sa imenom i prezimenom
                {
                    id_zaposlenika = z.id_korisnika,
                    zaposlenik = z.id_korisnika + " " + z.ime + " " + z.prezime//ubaci u listu ime i prezime


                }).ToList();

                cmbKorisnik.DataSource = zaposlenici;//prikaži listu sa imenom i prezimenom zaposlenika
                cmbKorisnik.DisplayMember = "zaposlenik";
                cmbKorisnik.ValueMember = "id_zaposlenika";


                roba = db.artikli.AsEnumerable().Select(a => new artikli()//napravi novu listu sa id i nazivom artikla
                {
                    ida = a.id_artikla,
                    naziv_artikla = a.id_artikla + " | " + a.naziv + " | Na skladištu: " + a.kolicina//ubaci u listu id i naziv i količinu na skaldištu


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
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnExit, "Izlaz");
        }

        private void btnUnosStavki_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnUnosStavki, "Unos stavke");
        }

        private void btnUnosIzdatnice_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnUnosIzdatnice, "Potvrda unosa opisa izdatnice");
        }

        private void btnUnosIzdatnice_Click(object sender, EventArgs e)
        {
            if (txtNacinDopreme.Text == "")
            {
                MessageBox.Show("Niste unijeli način dopreme robe!");
            }
            else if (txtOsnova.Text == "")
            {
                MessageBox.Show("Niste unijeli popratni dokument!");
            }
            else
            {

                using (var db = new T02_DBEntities())
                {
                    DateTime datum1;
                    datum1 = dtpDatum.Value;
                    string idKorisnika = "";
                    string idPartnera1 = "";
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


                    dokument dokument = new dokument
                    {

                        korisnik_id_korisnika = int.Parse(idKorisnika),
                        tip_dokumenta_id_tipa = 3,
                        poslovni_partner_id_partnera = int.Parse(idPartnera1),
                        datum = datum1,
                        stanje = "Kreirana",
                        osnova = txtOsnova.Text,
                        način_trans = txtNacinDopreme.Text


                    };
                    db.dokument.Add(dokument);
                    db.SaveChanges();


                    txtNacinDopreme.Text = "";
                    txtOsnova.Text = "";



                }//using

                MessageBox.Show("Izdatnica je uspješno unesena!");

            }//else
        }

        private void btnUnosStavki_Click(object sender, EventArgs e)
        {

            

            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli dopremljenu količinu!");
            }
            else if (txtMasa.Text == "")
            {
                MessageBox.Show("Niste unijeli dopremljenu masu!");
            }
            else
            {

                using (var db = new T02_DBEntities())
                {

                    string upit = string.Format("SELECT MAX(id_dokumenta) FROM dokument");
                    int id_dokumenta = db.Database.SqlQuery<int>(upit).FirstOrDefault<int>();
                    string idArtikla1 = "";



                    foreach (char a in cmbNazivArtikla.Text)
                    {
                        if (a == ' ') break;
                        else
                        {
                            idArtikla1 += a;
                        }

                    }

                    string query = string.Format("SELECT kolicina FROM artikli WHERE id_artikla = '{0}'", idArtikla1);
                    int kolNaSkladistu = db.Database.SqlQuery<int>(query).FirstOrDefault<int>();

                    string query2 = string.Format("SELECT masa FROM artikli WHERE id_artikla = '{0}'", idArtikla1);
                    int masaa = db.Database.SqlQuery<int>(query2).FirstOrDefault<int>();

                    if(kolNaSkladistu < int.Parse(txtKolicina.Text) || masaa < int.Parse(txtMasa.Text))
                    {
                        MessageBox.Show("Nedovoljna količina/masa robe na skladištu!" + Environment.NewLine + "Provjerite unesenu vrijednost!");
                    }
                    else{
                  
                    stavke stavke = new stavke
                    {
                        dokument_id_dokumenta = id_dokumenta,
                        artikli_id_artikla = int.Parse(idArtikla1),
                        kolicina = int.Parse(txtKolicina.Text),
                        masa = int.Parse(txtMasa.Text)

                    };
                    db.stavke.Add(stavke);

                    db.SaveChanges();

                    txtKolicina.Text = "";
                    txtMasa.Text = "";

                    MessageBox.Show("Stavka je unesena!");

                }//else

                }//using

                
            }//else
        }

    }
}