using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace tp_gesper
{
    class Requetes
    {
        MySqlConnection cnx;
        public Requetes(string h, string u, string db, string p)
        {
            Connexion cn = new Connexion(h, u, db, p);
            cnx = cn.Cnx;
        }

        //Requete 1
        public string ListeEmployes()
        {
            string result = "";
            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "select * from employe";
            cmdSql.CommandType = CommandType.Text;

            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                result += String.Format("{0}, {1}, {2}, {3}, {4} {5} {6}\n",
                    reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }

            this.cnx.Close();
            return result;
        }
        //Requete 2
        public string ListeServices()
        {
            string result = "";
            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "service";
            cmdSql.CommandType = CommandType.TableDirect;

            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                result += String.Format("{0}, {1}, {2}, {3}, {4} {5} \n",
                    reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }

            this.cnx.Close();
            return result;

        }
        //Requete 3
        public string MajSalaire(string nom, double pourcent)
        {

        }
        //Requete 4
        public decimal MasseSalariale(string nomService)
        {

        }
        //Requete 5
        public string SuperCadre()
        {

        }
    }
}
