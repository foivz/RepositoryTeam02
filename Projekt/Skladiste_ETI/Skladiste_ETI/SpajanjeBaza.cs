using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Skladiste_ETI
{
    class SpajanjeBaza
    {


        private static SpajanjeBaza instance; //Singleton objekt private string connectionString;
        //Putanja i ostali podaci za spajanje na bazu 
        private SQLiteConnection connection;
        public static SpajanjeBaza Instance//Konekcija prema bazi public static DB Instance //Singleton instanca klase za rad za bazom.
        { get {
            if (instance == null) 
            { 
            instance = new SpajanjeBaza(); 
            }   return instance;
        }   
        } 
   
public SQLiteConnection Connection //Konekcija prema bazi
{ 
    get 
{ 
        return connection; 
    }
private set
{ 
    connection = value; 
} 
}
        private SpajanjeBaza() //Konstruktor klase
{

    Connection = new SQLiteConnection("Data Source=warehouse_eti.db;Version=3;"); 
            Connection.Open();
} ~SpajanjeBaza() //Destruktor klase 
    { 
    Connection.Close();
    Connection = null;
    }


        public SQLiteDataReader DohvatiDataReader(string sqlUpit)
        { 
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
 
        } /// <summary> /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita. ///
          /// </summary> /// <param name="sqlUpit">
          /// SQL upit.</param> ///
          /// <returns>Skalarna vrijednost kao rezultat upita.</returns> 
          
        public object DohvatiVrijednost(string sqlUpit)
          { 
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
              
            return command.ExecuteScalar(); 
          } 
        /// <summary> /// Izvršava INSERT, UPDATE, DELETE SQL izraz. /// </summary> /// <param name="sqlUpit">
            
        /// INSERT, UPDATE, DELETE SQL izraz.</param> /// <returns>Broj redaka u tablici koji su promijenjeni.</returns>
            
        public int IzvrsiUpit(string sqlUpit)
            
        { 
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
                
            return command.ExecuteNonQuery(); 
           
        }

        class student { }
    }
}

