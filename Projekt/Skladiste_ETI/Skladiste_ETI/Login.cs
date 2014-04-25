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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlUpit = ("SELECT prezime,sifra FROM Ime WHERE prezime='" + txtUser.Text + "' and sifra='" + txtPass.Text + "'");

            SQLiteDataReader re = SpajanjeBaza.Instance.DohvatiDataReader(sqlUpit);

            //ako je pronađen upit izvrsi if
            if (re.Read())
            {
                //spremanje imena u klasu userinformation koja je public da mogu druge forme citat
                UserInformation.CurrentLoggedInUser = (string)re["prezime"];
                new Main().Show();
                this.Hide();
                MessageBox.Show("Welcome " + UserInformation.CurrentLoggedInUser);
            }
            else
                MessageBox.Show("inavlid username and password");
            re.Close();
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