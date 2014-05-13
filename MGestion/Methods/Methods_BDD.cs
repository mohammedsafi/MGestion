using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Using pour utiliser Mysql connector
using MGestion.Methods;
using System.Windows.Forms; //Inclusion de la biblio pour pouvoir utiliser les mboxs

namespace MGestion.Methods
{
    class Methods_BDD
    {
        // Connexion
        public static MySqlConnection ConnectionPossible()
        {
            MySqlConnection ToOpen;
            String ConnectInfo = "";
            List<String> ConnectList = new List<String>();
            ConnectList = Methods_File.Load_File();
            ConnectInfo = Methods_File.Change_List_ToString(ConnectList);
            try
            {
                ToOpen = new MySqlConnection(ConnectInfo);
                ToOpen.Open();
                return ToOpen;
            }
            catch (MySqlException Error)
            {
                switch (Error.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur", "Erreur 003");
                        break;

                    case 1045:
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorect", "Erreur 004");
                        break;
                    default:
                        MessageBox.Show("Erreur inconnue lors de la connexion à la base de données", "Erreur 007");
                        break;
                }
                return null;
            }
        }

        //Fermeture
        public static MySqlConnection CloseConnectionPossible(MySqlConnection ToClose)
        {
            try
            {
                ToClose.Close();
                return ToClose;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de fermer la connexion à la base de données", "Erreur 005");
                return null;
            }
        }

        // Commande
        public static Boolean MakeABasicRequest(MySqlConnection Connection, String Request) //INSERT DELETE UPDATE QUI NE DEMANDE PAS DE RECUPERER LES DATA
        {

            if (Connection != null)
            {
                //Alors connexion OK
                MySqlCommand SQLRequest = new MySqlCommand(Request, Connection); //Envois de la commande
                SQLRequest.ExecuteNonQuery();
                CloseConnectionPossible(Connection);
                return true;
            }
            else
            {
                return false; //Insert non faisable
            }
        }

        //Count
        public static Int16 MakeACount(MySqlConnection Connection, String Request)
        {
            Int16 Count = 0;
            if (Connection != null)
            {
                //Alors connection OK 
                MySqlCommand SQLCount = new MySqlCommand(Request, Connection);
                Count = Convert.ToInt16(SQLCount.ExecuteScalar());
                return Count;
            }
            else
            {
                return -1;
            }
        }

        //Select selon la table
        public static List<String> MakeASelect(MySqlConnection Connection, String Request, Int16 OnTable) //Signature de la fonction
        {
            if (Connection != null)
            {
                //Alors connexion OK
                List<String> Data = new List<String>();
                MySqlCommand SQLRequest = new MySqlCommand(Request, Connection); //Prépa de la commande
                MySqlDataReader DataRead = SQLRequest.ExecuteReader();
                DataRead.Read();
                switch (OnTable)
                {
                    case 1: //Si on choisis la table personne
                        try
                        {
                            Data.Add(DataRead.GetInt32(0).ToString());
                            Data.Add(DataRead.GetString(1).ToString());
                            Data.Add(DataRead.GetString(2).ToString());
                            Data.Add(DataRead.GetMySqlDateTime(3).ToString());
                            Data.Add(DataRead.GetString(4).ToString());
                            Data.Add(DataRead.GetString(5).ToString());
                            Data.Add(DataRead.GetString(6).ToString());
                            Data.Add(DataRead.GetString(7).ToString());
                            Data.Add(DataRead.GetString(8).ToString());
                            Data.Add(DataRead.GetString(9).ToString());
                            Data.Add(DataRead.GetString(10).ToString());
                            DataRead.Close();
                        }
                        catch (Exception)
                        {
                            return Data;
                        }
                        return Data;
                    case 2: //Si on choisis la table société
                        try
                        {
                            Data.Add(DataRead.GetInt32(0).ToString());
                            Data.Add(DataRead.GetString(1).ToString());
                            Data.Add(DataRead.GetString(2).ToString());
                            Data.Add(DataRead.GetString(3).ToString());
                            Data.Add(DataRead.GetString(4).ToString());
                            Data.Add(DataRead.GetString(5).ToString());
                            Data.Add(DataRead.GetString(6).ToString());
                            Data.Add(DataRead.GetInt32(7).ToString());
                            Data.Add(DataRead.GetString(8).ToString());
                            DataRead.Close();
                        }
                        catch (Exception)
                        {
                            return Data;
                        }
                        return Data;
                    default:
                        return Data;
                }

            }
            else
            {
                return null; //Select non faisable
            }
        }

        // Commande
        // Paramètre
        // Execution
        // Fin de la connexion
    }
}
