using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tp_gesper
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;
            string host;
            string user;
            string bdd;
            string pwd;
            MySqlCommand Cmd;
            MySqlConnection Cnx;

            Requetes rq;

            /*paramètres de connexion
            Console.WriteLine("Donner le nom du serveur");
            host = Console.ReadLine();
            Console.WriteLine("Donner le nom de la base de données");
            bdd = Console.ReadLine();
            Console.WriteLine("Donner le nom de l'utilisateur");
            user= Console.ReadLine();
            Console.WriteLine("Donner le mot de passe");
            pwd = Console.ReadLine(); */

            host = "localhost";
            bdd = "gesper";
            user = "root";
            pwd = "siojjr";


            // connexion

            rq = new Requetes(host, user, bdd, pwd);

            do
            {
                do
                {
                    Console.WriteLine("1 - liste complète des employés (utiliser une requête)");
                    Console.WriteLine("2 - liste complète des services (utiliser la table, sans écrire de requête)");
                    Console.WriteLine("3 - mettre à jour le salaire d'un employé en passant en paramètre le nom de l'employé et le pourcentage d'augmentation (utiliser la procédure stockée)");
                    Console.WriteLine("4 - Donner la masse salariale mensuelle d'un service (procédure stockée paramétrée)");
                    Console.WriteLine("5 - liste des employés cadres qui gagnent plus que la moyenne des salaires des cadres(utiliser une requête)");
                    Console.WriteLine("6 - Création d'un nouvel employé (procédure stockée)");
                    Console.WriteLine("7 - Liste des employés qui possèdent à la fois le bas et une licence (procédure stockée)");
                    Console.WriteLine("8 - Les employes qui ont un salaire compris entre une borne inférieure et une borne supérieure (procédure stockée paramétrée)");
                    Console.WriteLine("9 - Mettre à jour le budget d'un service administratif (procédure stockée paramétrée");
                    Console.WriteLine("10 - Affiche les noms et prenoms des empolyés qui ont plus de diplomes que la moyenne des diplomes possédés par chaque employé(procédure stockée ");
                    Console.WriteLine("11 - fin du traitement");


                    choix = Int32.Parse(Console.ReadLine());

                } while (choix < 0 || choix > 11);

                switch (choix)
                {
                    #region 1 - liste complète des employés (utiliser une requête)")
                    case 1:
                        Console.WriteLine("\n1 - liste complète des employés (utiliser une requête)");

                        Console.WriteLine(rq.ListeEmployes());


                        break;
                    #endregion
                    #region 2 - liste complète des services (utiliser la table, sans écrire de requête)")
                    case 2:
                        Console.WriteLine("\n1 - liste complète des services (utiliser la table, sans écrire de requête)");


                        break;
                    #endregion
                    #region 3 - mettre à jour le salaire d'un employé en passant en paramètre le nom de l'employé et le pourcentage d'augmentation (utiliser la procédure stockée majSalaire)
                    case 3:
                        Console.WriteLine("\n3 - mettre à jour le salaire d'un employé en passant en paramètre le nom de l'employé et le pourcentage d'augmentation (utiliser la procédure stockée majSalaire)");

                        break;
                    #endregion


                    #region 4 - Donner la masse salariale mensuelle d'un service (procédure stockée paramétrée)
                    case 4:
                        Console.WriteLine("\n4 - Donner la masse salariale mensuelle d'un service (procédure stockée paramétrée)");
                        Console.WriteLine("nom du service ?");
                        string nomService = Console.ReadLine();




                        break;
                    #endregion
                    #region 5 - liste des employés cadres qui gagnent plus que la moyenne des salaires des cadres(utiliser une requête)
                    case 5:
                        Console.WriteLine("\n5 - liste des employés cadres qui gagnent plus que la moyenne des salaires des cadres(utiliser une requête)");

                        break;
                    #endregion
                    #region 6 - Nom,prenom des employés du service 'atelier A' qui possèdent plus de 2 diplomes
                    case 6:
                        Console.WriteLine("\n6 - Nom,prenom des employés du service 'atelier A' qui possèdent plus de 2 diplomes");

                        break;
                    #endregion
                    #region 7 - Procedure qui permet d'augmenter le salaire d'un employé
                    case 7:
                        Console.WriteLine("\n6 - Procedure qui permet d'augmenter le salaire d'un employé");

                        break;
                    #endregion
                    #region 8 - Procedure qui permet de donner la masse salariale mensuelle d'un service
                    case 8:
                        Console.WriteLine("\n6 - Procedure qui permet de donner la masse salariale mensuelle d'un service");

                        break;
                    #endregion
                    #region 9 - Vue qui comprend les employés cadre
                    case 9:
                        Console.WriteLine("\n6 - Vue qui comprend les employés cadre");

                        break;
                    #endregion
                    #region 10 - Requete qui permet d'afficher les cadres qui gagnent plus que la moyenne des salaires de tous les cadres
                    case 10:
                        Console.WriteLine("\n6 - Requete qui permet d'afficher les cadres qui gagnent plus que la moyenne des salaires de tous les cadres");





                        break;
                    #endregion
                    #region 11 - Fin
                    case 11:
                        Console.WriteLine("\nFin du traitement");
                        break;
                    #endregion
                }
            }
            while (choix != 11);

            Console.ReadLine();
        }
    }
}
