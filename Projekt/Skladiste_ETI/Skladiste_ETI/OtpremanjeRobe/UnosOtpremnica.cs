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
    public partial class frmUnosOtpremnica : Form
    {
        public frmUnosOtpremnica()
        {
            InitializeComponent();
        }

        private void txtJedinicnaCijena_KeyUp(object sender, KeyEventArgs e)
        {
            izracunUkupneCijene();
        }


        private void txtKolicina_KeyUp(object sender, KeyEventArgs e)
        {
            izracunUkupneCijene();
        }

        private void izracunUkupneCijene() 
        {            
            if (txtKolicina.Text != "" && txtJedinicnaCijena.Text != "")
            {               
                txtUkupnaCijena.Text = (float.Parse(txtJedinicnaCijena.Text) * float.Parse(txtKolicina.Text)).ToString();
            }
        }

        private void frmUnosOtpremnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.dataSet1.artikli);

        }



    }
}
