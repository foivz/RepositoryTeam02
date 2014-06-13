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

     

        public frmPregledDokumenata()
        {
            InitializeComponent();

            label8.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label9.Text = DateTime.Now.DayOfWeek.ToString();
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
            public double kolicina { get; set; }
            public double kol_na_skladistu { get; set; }
            public double masa { get; set; }
            public double masa_na_skladistu { get; set; }
            public double cijena { get; set; }
            public double ukupno { get; set; }

        }


        private void frmPregledDokumenata_Load(object sender, EventArgs e)
        {

            var docs = from dok in context.dokument
                       join partner in context.poslovni_partner on dok.poslovni_partner_id_partnera equals partner.id_partnera
                       join skladistar in context.korisnik on dok.korisnik_id_korisnika equals skladistar.id_korisnika
                       join tip in context.tip_dokumenta on dok.tip_dokumenta_id_tipa equals tip.id_tipa
                       select new dokument
                       {
                           id_dokumenta = dok.id_dokumenta,
                           tip = tip.naziv,
                           naziv_partnera = partner.naziv,
                           adresa_partnera = partner.adresa,
                           ime_skladistara = skladistar.ime,
                           prez_skladistara =  skladistar.prezime,
                           datum = dok.datum.Value,
                           osnova = dok.osnova,
                           nacin_trans = dok.način_trans,
                           stanje = dok.stanje,
                           


                       };

            dgvDokumenti.DataSource = docs.ToList();
         
            
            dgvDokumenti.Columns[0].HeaderText = "ID Dokumenta";
            dgvDokumenti.Columns[1].HeaderText = "Tip";
            dgvDokumenti.Columns[2].HeaderText = "Naziv partnera";
            dgvDokumenti.Columns[3].HeaderText = "Adresa partnera";
            dgvDokumenti.Columns[3].Width = 150;
            dgvDokumenti.Columns[4].HeaderText = "Ime skladištara";
            dgvDokumenti.Columns[5].HeaderText = "Prezime skladištara";
            dgvDokumenti.Columns[6].HeaderText = "Datum";
            dgvDokumenti.Columns[7].HeaderText = "Osnova";
            dgvDokumenti.Columns[7].Width = 150;
            dgvDokumenti.Columns[8].HeaderText = "Način transporta";
            dgvDokumenti.Columns[9].HeaderText = "Stanje";

        }

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
           
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            int odabrani_redak = dgvStavke.CurrentCell.RowIndex;
            string nazivArtikla = dgvStavke.Rows[odabrani_redak].Cells[2].Value.ToString();
            string kolicinaStavke = dgvStavke.Rows[odabrani_redak].Cells[3].Value.ToString();
            string masaStavke = dgvStavke.Rows[odabrani_redak].Cells[5].Value.ToString();
            string idStavke = dgvStavke.Rows[odabrani_redak].Cells[0].Value.ToString();
            string kolNaSkladistu = dgvStavke.Rows[odabrani_redak].Cells[4].Value.ToString();
            string masaNaSkladistu = dgvStavke.Rows[odabrani_redak].Cells[6].Value.ToString();
            string idArtikla = dgvStavke.Rows[odabrani_redak].Cells[1].Value.ToString();

            Dokumenti.frmIzmjenaStavki frmIzmjena = new Dokumenti.frmIzmjenaStavki(nazivArtikla, kolicinaStavke, masaStavke, idStavke, kolNaSkladistu, masaNaSkladistu, idArtikla);
            frmIzmjena.Show();
        }


    }

}
