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
        private int novaKolicina;
        private int novaMasa;
        private int kolicinaNaSk;
        private int masaNaSk;
        private int idArt;
        private string tip_dok;
        

        public frmIzmjenaStavki(string naziv, string kolicina, string masa, string id_stav, string kolNaSk, string masNaSk, string idArtikla, string tip_dokumenta)
        {
            //inicijalizacija liste
            
            InitializeComponent();

            //proslijeđeni podaci kroz kontruktor
            txtTrenutniArtikl.Text = naziv;
            label4.Text = kolicina;
            label5.Text = masa;
            id_stav1 = int.Parse(id_stav);

            kolicinaNaSk = int.Parse(kolNaSk);
            masaNaSk = int.Parse(masNaSk);
            idArt = int.Parse(idArtikla);
            tip_dok = tip_dokumenta;
            

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
            novaKolicina = int.Parse(txtNovaKolicina.Text);
            novaMasa = int.Parse(txtNovaMasa.Text);

            int razlikaKolicina = (novaKolicina - int.Parse(label4.Text))*(-1);
            int razlikaMasa = (novaMasa - int.Parse(label5.Text))*(-1);

            using (var db = new T02_DBEntities()) 
            
            {
                if(tip_dok == "Izdatnica"){

                        if(novaKolicina < kolicinaNaSk && novaMasa < masaNaSk){
                
                        string upit = string.Format("UPDATE stavke SET artikli_id_artikla = '{0}', kolicina = '{1}', masa = '{2}' WHERE id_stavke = '{3}'",idArt, novaKolicina, novaMasa, id_stav1);
                        db.Database.ExecuteSqlCommand(upit);

                        //izvrši proceduru nad količinom u skladištu
                        
                        db.UpdateArtikliStavkePlus(idArt, razlikaKolicina, razlikaMasa);
                        db.SaveChanges();
                        MessageBox.Show("Stavka izdatnice uspješno izmijenjena!");
                        this.Close();
                    }
                
                else{
                    
                    MessageBox.Show("Ne možete unijeti masu ili količinu koja prelazi zalihe na skladištu!");
                
                }//else
                
                }//if

                else if(tip_dok == "Otpremnica")
                {
                    string upit2 = string.Format("UPDATE stavke SET artikli_id_artikla = '{0}', kolicina = '{1}', masa = '{2}' WHERE id_stavke = '{3}'", idArt, novaKolicina, novaMasa, id_stav1);
                    db.Database.ExecuteSqlCommand(upit2);

                    db.SaveChanges();
                    MessageBox.Show("Stavka otpremnice uspješno izmijenjena");
                }
                
                else if(tip_dok == "Primka" || tip_dok == "Predatnica")
                {
                    string upit2 = string.Format("UPDATE stavke SET artikli_id_artikla = '{0}', kolicina = '{1}', masa = '{2}' WHERE id_stavke = '{3}'", idArt, novaKolicina, novaMasa, id_stav1);
                    db.Database.ExecuteSqlCommand(upit2);

                    //izvrši proceduru
                    db.UpdateArtikliStavkeMinus(idArt, razlikaKolicina, razlikaMasa);
                    
                    db.SaveChanges();
                    MessageBox.Show("Stavka primke/predatnice uspješno izmijenjena!");
                    this.Close();
                }//if
            
            }//using

           
        }//click

    }
}
