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
    public partial class frmOtpremnice : Form
    {
        public frmOtpremnice()
        {
            InitializeComponent();
        }

        private void Otpremnice_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            string sqlUpit = ("SELECT ime,prezime,password FROM Korisnici ");

            SQLiteDataReader re = SpajanjeBaza.Instance.DohvatiDataReader(sqlUpit);
            while (re.Read())
            {
                list.Add((string)re["ime"]);
                
            }
            dataGridView1.DataSource= list;
          
        
        }
    }
}
