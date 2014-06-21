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
    public partial class frmSkladisnicaIzvjestaj : Form
    {
        public frmSkladisnicaIzvjestaj()
        {
            InitializeComponent();
        }

        private void SkladisnicaIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'T02_DBDataSet.artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.T02_DBDataSet.artikli);

            this.reportViewer1.RefreshReport();
        }
    }
}
