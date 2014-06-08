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
    public partial class frmArtikli : Form
    {
        public frmArtikli()
        {
            InitializeComponent();
            grbUnosArtikla.Visible = false;

            List<mjesto> pozicija = new List<mjesto>();

            using (var db = new T02_DBEntities())
            {
                pozicija = db.mjesto.AsEnumerable().Select(m => new mjesto()//napravi novu listu sa id i nazivom
                {
                    idMjesta = m.id_mjesta,
                    lista_mjesta = m.id_mjesta + " " + m.polica + " " +m.sektor
                
                }).ToList();

                cmbMjesto.DataSource = pozicija;
                cmbMjesto.DisplayMember = "lista_mjesta";
                cmbMjesto.ValueMember = "idMjesta";
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PrikaziMjesto()
        {
            BindingList<mjesto> mjesto = null;
            using(var db = new T02_DBEntities())
            {
                mjesto = new BindingList<mjesto>(db.mjesto.ToList<mjesto>());
            }
            mjestoBindingSource.DataSource = mjesto;
    
        }

        public void PrikaziArtikle(mjesto mj) 
        {
            BindingList<artikli> artikli = null;
            using(var db = new T02_DBEntities())
            {
                db.mjesto.Attach(mj);
                artikli = new BindingList<artikli>(mj.artikli.ToList<artikli>());
            }        
            artikliBindingSource.DataSource = artikli;
        }

        private void frmArtikli_Load(object sender, EventArgs e)
        {
            PrikaziMjesto();
            PrikaziArtikle(mjestoBindingSource.Current as mjesto);
        }

        private void dgvMjesto_SelectionChanged(object sender, EventArgs e)
        {
            mjesto selektiranoMjesto = mjestoBindingSource.Current as mjesto;
            if (selektiranoMjesto != null) 
            {
                PrikaziArtikle(selektiranoMjesto);
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            if(txtPolica.Text == "")
            {
                MessageBox.Show("Niste unijeli broj police!");
            }
            else if (txtSektor.Text == "")
            {
                MessageBox.Show("Niste unijeli sektor!");
            }
            else
            {
                using (var db = new T02_DBEntities())
                {
                    mjesto pozicija = new mjesto
                    {
                        polica = int.Parse(txtPolica.Text),
                        sektor = txtSektor.Text

                    };
                    db.mjesto.Add(pozicija);
                    db.SaveChanges();

                    txtPolica.Text = "";
                    txtSektor.Text = "";

                    MessageBox.Show("Uspješno dodana pozicija!");
                    PrikaziMjesto();
                    
                }//using
            }//else
        }//click

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            mjesto odabranoMjesto = mjestoBindingSource.Current as mjesto;
            if (odabranoMjesto != null)
            {

                if (MessageBox.Show("Da li ste sigurni da želite obrisati poziciju u skladištu?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new T02_DBEntities())
                    {
                        db.mjesto.Attach(odabranoMjesto);
                        db.mjesto.Remove(odabranoMjesto);
                        db.SaveChanges();

                    }//using

                }

            }
            MessageBox.Show("Uspješno obrisana pozicija!");
            PrikaziMjesto();
            
        }//click

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text == "")
            {
                MessageBox.Show("Niste unijeli naziv robe!");
            }
            else if(txtCijena.Text == "")
            {
                MessageBox.Show("Niste unijeli cijenu robe!");
            }
            else if(txtKolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli količinu robe!");
            }
            else if (txtMasa.Text == "")
            {
                MessageBox.Show("Niste unijeli masu robe!");
            }
            else
            {

                using (var db = new T02_DBEntities())
                {

                    string id_pozicije = "";

                    foreach(char a in cmbMjesto.Text)
                    {
                        if (a == ' ') break;
                        else 
                        {
                            id_pozicije += a;
                        }
                    }

                    artikli roba = new artikli
                    {
                        naziv = txtNaziv.Text,
                        cijena = int.Parse(txtCijena.Text),
                        kolicina = int.Parse(txtKolicina.Text),
                        masa = int.Parse(txtMasa.Text),
                        mjesto_id_mjesta = int.Parse(id_pozicije)
                    };

                    db.artikli.Add(roba);
                    db.SaveChanges();


                }//using

                txtNaziv.Text = "";
                txtCijena.Text = "";
                txtKolicina.Text = "";
                txtMasa.Text = "";

                MessageBox.Show("Artikl je uspješno dodan!");
                PrikaziMjesto();
                PrikaziArtikle(mjestoBindingSource.Current as mjesto);
                
            }//else
        }//click


        private void btnAdd_Click(object sender, EventArgs e)
        {
            grbUnosArtikla.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            artikli odabraniArtikl = artikliBindingSource.Current as artikli;

            if (odabraniArtikl != null)
            {

                if (MessageBox.Show("Da li ste sigurni da želite obrisati artikl?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new T02_DBEntities())
                    {
                        db.artikli.Attach(odabraniArtikl);
                        db.artikli.Remove(odabraniArtikl);
                        db.SaveChanges();

                    }//using

                }

            }
            MessageBox.Show("Artikl je uspješno obrisan!");
            PrikaziMjesto();
            PrikaziArtikle(mjestoBindingSource.Current as mjesto);
            ;
        }//click

    }
}
