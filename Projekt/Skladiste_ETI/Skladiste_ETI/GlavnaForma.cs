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
    public partial class frmMain : Form
    {
        public frmMain(string username)
        {
            
            InitializeComponent();
            using (var db = new T02_DBEntities()) 
            
            {

                

        
            }
         
            this.lblUser.Text = UserInformation.CurrentLoggedInUser;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label8.Text = DateTime.Now.ToString("d/M/yyyy");
            label9.Text = DateTime.Now.DayOfWeek.ToString();
            

        }

        private void btnArtikl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnArtikli, "Upravljanje artiklima");
        }

        private void btnOtpremanje_MouseHover(object sender, EventArgs e)
        {

            btnOtpremanje.Visible = false;
            btnIzdatnica.Visible = true;
            btnOtpremnica.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label6.Visible = false;
        }

        private void btnZaprimanje_MouseHover(object sender, EventArgs e)
        {
            btnZaprimanje.Visible = false;
            btnPredatnica.Visible = true;
            btnPrimka.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label7.Visible = false;
        }

   

        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            new frmOtpremnice().Show();
            this.Close();
        }

        private void btnIzdatnica_Click(object sender, EventArgs e)
        {
            new frmIzdatnice().Show();
            this.Close();
        }

        private void btnPrimka_Click(object sender, EventArgs e)
        {
            new frmPrimke().Show();
            this.Close();
        }

        private void btnPredatnica_Click(object sender, EventArgs e)
        {
            new frmPredatnice().Show();
            this.Close();
        }

        private void btnOtpremnica_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnOtpremnica, "Izraditi otpremnice");
        }

        private void btnIzdatnice_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnIzdatnica, "Izraditi izdatnice");
        }

        private void btnPrimka_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPrimka, "Izraditi primke");
        }

        private void btnPredatnica_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPredatnica, "Izraditi predatnice");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin prijava = new frmLogin();
            prijava.Show();
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
