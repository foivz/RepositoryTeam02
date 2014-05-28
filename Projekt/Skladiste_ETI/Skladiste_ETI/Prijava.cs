using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;


namespace Skladiste_ETI
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = txtUser.Text;
            string passWord = txtPass.Text;

            using (T02_DBEntities db = new T02_DBEntities()) {

                korisnik user = db.korisnik.FirstOrDefault(u => u.kor_ime.Equals(userName) && u.lozinka.Equals(passWord));

                if (user != null)
                {

                    frmMain glavnaForma = new frmMain();
                    glavnaForma.Show();
                    this.Hide();
                }
                else {

                    MessageBox.Show("Netočno korisničko ime ili lozinka!");
                
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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