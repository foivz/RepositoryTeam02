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
    public partial class frmPregledDokumenata : Form
    {
        T02_DBEntities context = new T02_DBEntities();
        int uloga2 = 0;

        List<tip_dokumenta> tip = new List<tip_dokumenta>();

        public frmPregledDokumenata(int uloga)
        {
            InitializeComponent();

            label8.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label9.Text = DateTime.Now.DayOfWeek.ToString();
            btnOdobri.Visible = false;

            uloga2 = uloga;

            if (uloga2 == 2)
            {
                btnChange.Visible = true;
                btnIzradaOtpremnice.Visible = false;
            }
            else 
            {
                btnChange.Visible = false;
                btnIzradaOtpremnice.Visible = true;
            }

            using (var db = new T02_DBEntities())
            {
                tip = db.tip_dokumenta.AsEnumerable().Select(t => new tip_dokumenta()//napravi novu listu sa id i nazivom
                {
                    idTipa = t.id_tipa,
                    listaTipova = t.naziv

                }).ToList();

                cmbTip.DataSource = tip;
                cmbTip.DisplayMember = "listaTipova";
                cmbTip.ValueMember = "idTipa";
            }
        
        }//konstruktor

        public class tip_dokumenta
        {
            public int idTipa { get; set; }
            public string listaTipova{ get; set; }
        }

        public class dokument 
        {
            
            public int id_dokumenta { get; set; }
            public string tip { get; set; }
            public string naziv_partnera { get; set; }
            public string adresa_partnera { get; set; }
            public string ime_skladistara { get; set; }
            public string prez_skladistara { get; set; }
            public DateTime datum { get; set; }
            public string osnova { get; set; }
            public string nacin_trans {get; set; }
            public string stanje { get; set; }
            

            
            
        }

        public class stavke 
        {
            
            public int id_stavke { get; set; }
            public int id_artikla { get; set; }
            public string naziv_artikla { get; set; }
            public int kolicina { get; set; }
            public int kol_na_skladistu { get; set; }
            public int masa { get; set; }
            public int masa_na_skladistu { get; set; }
            public double cijena { get; set; }
            public double ukupno { get; set; }

        }


        private void cmbTip_SelectedValueChanged(object sender, EventArgs e)
        {


            var docs = from dok in context.dokument
                       join partner in context.poslovni_partner on dok.poslovni_partner_id_partnera equals partner.id_partnera
                       join skladistar in context.korisnik on dok.korisnik_id_korisnika equals skladistar.id_korisnika
                       join tip in context.tip_dokumenta on dok.tip_dokumenta_id_tipa equals tip.id_tipa
                       where tip.naziv == cmbTip.Text
                       select new dokument
                       {
                           id_dokumenta = dok.id_dokumenta,
                           tip = tip.naziv,
                           naziv_partnera = partner.naziv,
                           adresa_partnera = partner.adresa,
                           ime_skladistara = skladistar.ime,
                           prez_skladistara = skladistar.prezime,
                           datum = dok.datum.Value,
                           osnova = dok.osnova,
                           nacin_trans = dok.način_trans,
                           stanje = dok.stanje,



                       };

            dgvDokumenti.DataSource = docs.ToList();

            dgvDokumenti.Columns[0].HeaderText = "ID Dokumenta";
            dgvDokumenti.Columns[1].HeaderText = "Tip";

            dgvDokumenti.Columns[4].HeaderText = "Ime skladištara";
            dgvDokumenti.Columns[5].HeaderText = "Prezime skladištara";
            dgvDokumenti.Columns[6].HeaderText = "Datum";

            dgvDokumenti.Columns[8].HeaderText = "Način transporta";
            dgvDokumenti.Columns[9].HeaderText = "Stanje";


            dgvDokumenti.Columns[2].HeaderText = "Naziv partnera";
            dgvDokumenti.Columns[2].Width = 160;
            dgvDokumenti.Columns[3].HeaderText = "Adresa partnera";
            dgvDokumenti.Columns[3].Width = 220;

            dgvDokumenti.Columns[7].HeaderText = "Osnova";
            dgvDokumenti.Columns[7].Width = 160;

            foreach (DataGridViewRow r in dgvDokumenti.Rows)
            {
                r.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16, GraphicsUnit.Pixel);

                string tip = r.Cells[1].Value.ToString();
                string stanje = r.Cells[9].Value.ToString();

                if (tip == "Izdatnica" && stanje == "Kreirana")
                {
                    r.DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (tip == "Izdatnica" && stanje == "Odobrena")
                {
                    r.DefaultCellStyle.ForeColor = Color.Green;
                }

            }


        }//selectionChanged

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPrint, "Ispis dokumenta");
        }

        private void btnChange_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnChange, "Izmjena stavki");
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnExit, "Izlaz");
        }

        private void btnOdobri_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnOdobri, "Odobri izdatnicu");
        }


        private void btnIzradaOtpremnice_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnIzradaOtpremnice, "Izrada otpremnice");
        }

        private string DohvatiIDDokumenta() 
        {
            int odabrani_redak = dgvDokumenti.CurrentCell.RowIndex;
            string id_dok = dgvDokumenti.Rows[odabrani_redak].Cells[0].Value.ToString();

            return id_dok;
        }

     

        private void dgvDokumenti_SelectionChanged(object sender, EventArgs e)
        {

            int IDDok = int.Parse(DohvatiIDDokumenta());
            

            var stavke = (from stav in context.stavke
                         join artikl in context.artikli on stav.artikli_id_artikla equals artikl.id_artikla
                         where stav.dokument_id_dokumenta == IDDok
                         select new stavke
                         {
                             id_stavke = stav.id_stavke,
                             id_artikla = artikl.id_artikla,
                             naziv_artikla = artikl.naziv,
                             kolicina = stav.kolicina,
                             kol_na_skladistu = artikl.kolicina,
                             masa = stav.masa,
                             masa_na_skladistu = artikl.masa,
                             cijena = artikl.cijena,
                             ukupno = stav.masa * artikl.cijena


                         }).ToList();

            dgvStavke.DataSource = stavke;

            dgvStavke.Columns[0].HeaderText = "ID Stavke";
            dgvStavke.Columns[1].HeaderText = "ID Artikla";
            dgvStavke.Columns[2].HeaderText = "Naziv artikla";
            dgvStavke.Columns[2].Width = 150;
            dgvStavke.Columns[3].HeaderText = "Količina/paleta";
            dgvStavke.Columns[4].HeaderText = "Količina na skladištu";
            dgvStavke.Columns[5].HeaderText = "Masa/kg";
            dgvStavke.Columns[6].HeaderText = "Masa na skladištu";
            dgvStavke.Columns[7].HeaderText = "Cijena";
            dgvStavke.Columns[8].HeaderText = "Ukupno/kn";

            foreach (DataGridViewColumn c in dgvStavke.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16, GraphicsUnit.Pixel);

            }


            int selectedRow2 = dgvDokumenti.CurrentCell.RowIndex;
            string tip_dok2 = dgvDokumenti.Rows[selectedRow2].Cells[1].Value.ToString();
            string stanje2 = dgvDokumenti.Rows[selectedRow2].Cells[9].Value.ToString();

            if (tip_dok2 == "Izdatnica" && stanje2 == "Kreirana" && uloga2 == 2)
            {
                btnOdobri.Visible = true;

            }//if
            else 
            {
                btnOdobri.Visible = false;
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            int odabrani_redak = dgvStavke.CurrentCell.RowIndex;
            int odabrani_redak2 = dgvDokumenti.CurrentCell.RowIndex;
            string nazivArtikla = dgvStavke.Rows[odabrani_redak].Cells[2].Value.ToString();
            string kolicinaStavke = dgvStavke.Rows[odabrani_redak].Cells[3].Value.ToString();
            string masaStavke = dgvStavke.Rows[odabrani_redak].Cells[5].Value.ToString();
            string idStavke = dgvStavke.Rows[odabrani_redak].Cells[0].Value.ToString();
            string kolNaSkladistu = dgvStavke.Rows[odabrani_redak].Cells[4].Value.ToString();
            string masaNaSkladistu = dgvStavke.Rows[odabrani_redak].Cells[6].Value.ToString();
            string idArtikla = dgvStavke.Rows[odabrani_redak].Cells[1].Value.ToString();
            string tip_dokumenta = dgvDokumenti.Rows[odabrani_redak2].Cells[1].Value.ToString();
 

            Dokumenti.frmIzmjenaStavki frmIzmjena = new Dokumenti.frmIzmjenaStavki(nazivArtikla, kolicinaStavke, masaStavke, idStavke, kolNaSkladistu, masaNaSkladistu, idArtikla, tip_dokumenta);
            frmIzmjena.Show();
    
            
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDokumenti.CurrentCell.RowIndex;
            string id_dokumenta = dgvDokumenti.Rows[selectedRow].Cells[0].Value.ToString();

            using (var db = new T02_DBEntities())
            {

            //parametar za proceduru
            int idDokumentaParametar = int.Parse(id_dokumenta);

            //izvrši proceduru za promjenu stanja dokumenta
            db.UpdateDokumentStanje(idDokumentaParametar);

            foreach (DataGridViewRow r in dgvStavke.Rows)
            {


                string idArtikla = r.Cells[1].Value.ToString();
                string kolicinaZaOtpremu = r.Cells[3].Value.ToString();
                string masaZaOtpremu = r.Cells[5].Value.ToString();
            
                //parametri za proceduru
                int idArtiklaParam = int.Parse(idArtikla);
                int kolicinaZaOtpremuParam = int.Parse(kolicinaZaOtpremu);
                int masaZaOtpremuParam = int.Parse(masaZaOtpremu);

                //izvrši proceduru smanjenja robe na skladištu
                db.UpdateArtikliOtprema(idArtiklaParam, kolicinaZaOtpremuParam, masaZaOtpremuParam);

                }//foreach

            }//using

            dgvDokumenti.Rows[selectedRow].DefaultCellStyle.ForeColor = Color.Green;
            dgvDokumenti.Rows[selectedRow].Cells[9].Value = "Odobrena";
            
            dgvDokumenti.Update();
            dgvDokumenti.Refresh();
            MessageBox.Show("Izdatnica uspješno odobrena!");
        }

        private void btnIzradaOtpremnice_Click(object sender, EventArgs e)
        {
            int selectedRow3 = dgvDokumenti.CurrentCell.RowIndex;
            
            string trans = dgvDokumenti.Rows[selectedRow3].Cells[8].Value.ToString();
            string osnova = dgvDokumenti.Rows[selectedRow3].Cells[0].Value.ToString() + " | " + " Izdatnica br. " + dgvDokumenti.Rows[selectedRow3].Cells[0].Value.ToString();
            string stanje = dgvDokumenti.Rows[selectedRow3].Cells[9].Value.ToString();
            string tip_dok = dgvDokumenti.Rows[selectedRow3].Cells[1].Value.ToString();

            if (tip_dok == "Izdatnica")
            {

                frmOtpremniceIzDokumenta forma = new frmOtpremniceIzDokumenta(trans, osnova, stanje);
                forma.Show();
            }
            else 
            {
                MessageBox.Show("Otpremnicu možete kreirati samo na temelju izdatnice!" + Environment.NewLine + "Provjerite tip odabranog dokumenta!");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int selectedRow4 = dgvDokumenti.CurrentCell.RowIndex;

            string id_dok3 = dgvDokumenti.Rows[selectedRow4].Cells[0].Value.ToString();
            string tip_dok3 = dgvDokumenti.Rows[selectedRow4].Cells[1].Value.ToString();

            if(tip_dok3 == "Primka")
            {
                frmPrimkaIzvjestaj primka = new frmPrimkaIzvjestaj(id_dok3);
                primka.Show();
            }

            if(tip_dok3 == "Predatnica")
            {
                frmPredatnicaIzvjestaj predatnica = new frmPredatnicaIzvjestaj(id_dok3);
                predatnica.Show();
            }

            if(tip_dok3 == "Izdatnica")
            {
                frmIzdatnicaIzvjestaj izdatnica = new frmIzdatnicaIzvjestaj(id_dok3);
                izdatnica.Show();
            }

            if(tip_dok3 == "Otpremnica")
            {
                frmOtpremnicaIzvjestaj otpremnica = new frmOtpremnicaIzvjestaj(id_dok3);
                otpremnica.Show();
            }
       
        }//click

        private void frmPregledDokumenata_Load(object sender, EventArgs e)
        {
            var docs = from dok in context.dokument
                       join partner in context.poslovni_partner on dok.poslovni_partner_id_partnera equals partner.id_partnera
                       join skladistar in context.korisnik on dok.korisnik_id_korisnika equals skladistar.id_korisnika
                       join tip in context.tip_dokumenta on dok.tip_dokumenta_id_tipa equals tip.id_tipa
                       where tip.naziv == cmbTip.Text
                       select new dokument
                       {
                           id_dokumenta = dok.id_dokumenta,
                           tip = tip.naziv,
                           naziv_partnera = partner.naziv,
                           adresa_partnera = partner.adresa,
                           ime_skladistara = skladistar.ime,
                           prez_skladistara = skladistar.prezime,
                           datum = dok.datum.Value,
                           osnova = dok.osnova,
                           nacin_trans = dok.način_trans,
                           stanje = dok.stanje,



                       };

            dgvDokumenti.DataSource = docs.ToList();

            dgvDokumenti.Columns[0].HeaderText = "ID Dokumenta";
            dgvDokumenti.Columns[1].HeaderText = "Tip";

            dgvDokumenti.Columns[4].HeaderText = "Ime skladištara";
            dgvDokumenti.Columns[5].HeaderText = "Prezime skladištara";
            dgvDokumenti.Columns[6].HeaderText = "Datum";

            dgvDokumenti.Columns[8].HeaderText = "Način transporta";
            dgvDokumenti.Columns[9].HeaderText = "Stanje";


            dgvDokumenti.Columns[2].HeaderText = "Naziv partnera";
            dgvDokumenti.Columns[2].Width = 160;
            dgvDokumenti.Columns[3].HeaderText = "Adresa partnera";
            dgvDokumenti.Columns[3].Width = 220;

            dgvDokumenti.Columns[7].HeaderText = "Osnova";
            dgvDokumenti.Columns[7].Width = 160;

            foreach (DataGridViewRow r in dgvDokumenti.Rows)
            {
                r.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16, GraphicsUnit.Pixel);

                string tip = r.Cells[1].Value.ToString();
                string stanje = r.Cells[9].Value.ToString();

                if (tip == "Izdatnica" && stanje == "Kreirana")
                {
                    r.DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (tip == "Izdatnica" && stanje == "Odobrena")
                {
                    r.DefaultCellStyle.ForeColor = Color.Green;
                }

            }


        }//click

     
    }

}
