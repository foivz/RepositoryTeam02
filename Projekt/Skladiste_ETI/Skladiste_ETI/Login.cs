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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sqlUpit = ("SELECT ime,prezime,password FROM Korisnici WHERE prezime='" + txtUser.Text + "' and password='" + txtPass.Text + "'");

            SQLiteDataReader re = SpajanjeBaza.Instance.DohvatiDataReader(sqlUpit);

            //ako je pronađen upit izvrsi if
            if (re.Read())
            {
                //spremanje imena u klasu userinformation koja je public da mogu druge forme citat
                UserInformation.CurrentLoggedInUser = (string)re["ime"] +" " + (string)re["prezime"];
                new GlavnaForma().Show();
                this.Hide();

            }
            else
                MessageBox.Show("Inavlid username or password");
            re.Close();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
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