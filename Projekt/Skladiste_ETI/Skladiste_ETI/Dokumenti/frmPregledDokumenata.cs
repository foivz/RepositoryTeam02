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
        }

        public class dokument 
        {
            public int id_dokumenta { get; set; }
            public string naziv_partnera { get; set; }
            public string adresa_partnera { get; set; }
            public string ime_skladistara { get; set; }
            public string prez_skladistara { get; set; }
            public DateTime datum { get; set; }
            public string osnova { get; set; }
            public string nacin_trans { get; set; }
            public string stanje { get; set; }
            public string tip { get; set; }

        }

        public class stavke 
        {
            public int id_stavke { get; set; }
            public string naziv_artikla { get; set; }
            public float kolicina { get; set; }
            public float masa { get; set; }
            public float cijena { get; set; }
        }

        private void frmPregledDokumenata_Load(object sender, EventArgs e)
        {

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }

}
