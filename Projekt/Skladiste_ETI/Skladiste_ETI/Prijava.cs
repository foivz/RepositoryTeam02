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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            txtUser.Select();
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;

            using (T02_DBEntities db = new T02_DBEntities())
            {

                //sprema u varijablu user korisnika sa unešenim imenom i lozinkom
                //FirstOrdDefault traži u sekvenci prvu vrijednost sa zadanim parametrima ili vraća default(null)
                korisnik user = db.korisnik.FirstOrDefault(u => u.kor_ime.Equals(userName) && u.lozinka.Equals(passWord));

                if (user != null)
                {

                    UserInformation.CurrentLoggedInUser = userName;
                    frmMain glavnaForma = new frmMain();
                    glavnaForma.Show();
                    this.Hide();
                }
                else
                {
                    MsgBox poruka = new MsgBox();
                    poruka.ShowDialog();

                }//else
            }//using
            
        }

  
    }
}
        internal class UserInformation
        {
            public static string CurrentLoggedInUser
            {
                get;
                set;
            }
        }