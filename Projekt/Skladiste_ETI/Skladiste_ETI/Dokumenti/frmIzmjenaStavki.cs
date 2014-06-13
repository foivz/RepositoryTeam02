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
    public partial class frmIzmjenaStavki : Form
    {
        private int id_stav1;
        private float novaKolicina;
        private float novaMasa;
        private float kolicinaNaSk;
        private float masaNaSk;
        private int idArt;
        
        public frmIzmjenaStavki(string naziv, string kolicina, string masa, string id_stav, string kolNaSk, string masNaSk, string idArtikla)
        {
            //inicijalizacija liste
            
            InitializeComponent();

            //proslijeđeni podaci kroz kontruktor
            txtTrenutniArtikl.Text = naziv;
            txtTrenutnaKolicina.Text = kolicina;
            txtTrenutnaMasa.Text = masa;
            id_stav1 = int.Parse(id_stav);

            kolicinaNaSk = float.Parse(kolNaSk);
            masaNaSk = float.Parse(masNaSk);
            idArt = int.Parse(idArtikla);

        }//konstruktor

        public class artikli 
        {
            public int ida { get; set; }
            public string naziv_artikla { get; set; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            novaKolicina = float.Parse(txtTrenutnaKolicina.Text);
            novaMasa = float.Parse(txtTrenutnaMasa.Text);
            


            using (var db = new T02_DBEntities()) 
            
            {
                if(novaKolicina < kolicinaNaSk && novaMasa < masaNaSk){
                
                string upit = string.Format("UPDATE stavke SET artikli_id_artikla = '{0}', kolicina = '{1}', masa = '{2}' WHERE id_stavke = '{3}'",idArt, novaKolicina, novaMasa, id_stav1);
                db.Database.ExecuteSqlCommand(upit);
                db.SaveChanges();
                MessageBox.Show("Podaci o stavki izmijenjeni!");
                
                }
                
                else{
                    
                    MessageBox.Show("Ne možete unijeti masu ili količinu koja prelazi zalihe na skladištu!");
                
                }//else
            
            }//using

           
        }//click

    }
}
