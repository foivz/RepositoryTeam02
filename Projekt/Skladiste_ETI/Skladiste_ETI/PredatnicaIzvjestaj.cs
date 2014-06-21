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
    public partial class frmPredatnicaIzvjestaj : Form
    {
        int id_dok;
        public frmPredatnicaIzvjestaj(string id_dok1)
        {
            InitializeComponent();
            id_dok = int.Parse(id_dok1);
        }

        private void frmPredatnicaIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DokumentDataset.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.FillDokumentByID(this.DokumentDataset.DataTable1, id_dok);
            // TODO: This line of code loads data into the 'DokumentDataset.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.FillStavkeByID(this.dokumentDataset1.DataTable2, id_dok);

            this.reportViewer1.RefreshReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
