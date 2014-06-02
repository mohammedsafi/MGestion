using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MGestion.Methods;

namespace MGestion.Methods
{
    class Methods_Check
    {

        public static Boolean AvailableUserMail(String ToSearch)
        {
            String Request = ""; //Requete SQL
            List<String> Result = new List<String>();
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM personne WHERE Personne_Mail = '" + ToSearch.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 1);
            try
            {
                if (ToSearch.Trim() == Result[4].ToString().Trim())
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }
            return true;
        }

        public static Boolean AvailableSocietyName(String ToSearch)
        {
            String Request = ""; //Requete SQL
            List<String> Result = new List<String>();
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM societe WHERE Societe_Nom = '" + ToSearch.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 2);
            try
            {
                if (ToSearch.Trim() == Result[1].ToString().Trim())
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }
            return true;
        }

        public static Boolean AvailableAnnounceRef(String ToSearch)
        {
            String Request = ""; //Requete SQL
            List<String> Result = new List<String>();
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM annonce WHERE Annonce_Ref = '" + ToSearch.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 3);
            try
            {
                if (ToSearch.Trim() == Result[14].ToString().Trim())
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }
            return true;
        }

        public static Boolean IsInteger(String value)
        {
            Int32 number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean PasswordUserSecurityCheck(String Password)
        {
            if (Password.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean StringSecurityCheck(String StringToCheck)
        {
            foreach ( Char C in StringToCheck)
            {
                if (C <= 64 && C >= 90 || C <= 96 && C >= 122 )
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean URLSecurityCheck(String URL)
        {
            Int16 i = 0;
            foreach (Char C in URL.Trim().ToLower())
            {
                if ( i <= 11)
                {
                    switch (i)
                    {
                        case 1:
                            if (C != 'h')
                            {
                                return false;
                            }
                            break;
                        case 2:
                            if (C != 't')
                            {
                                return false;
                            }
                            break;
                        case 3:
                            if (C != 't')
                            {
                                return false;
                            }
                            break;
                        case 4:
                            if (C != 'p')
                            {
                                return false;
                            }
                            break;
                        case 5:
                            if (C != ':')
                            {
                                return false;
                            }
                            break;
                        case 6:
                            if (C != '/')
                            {
                                return false;
                            }
                            break;
                        case 7:
                            if (C != '/')
                            {
                                return false;
                            }
                            break;
                        case 8:
                            if (C != 'w')
                            {
                                return false;
                            }
                            break;
                        case 9:
                            if (C != 'w')
                            {
                                return false;
                            }
                            break;
                        case 10:
                            if (C != 'w')
                            {
                                return false;
                            }
                            break;
                        case 11:
                            if (C != '.')
                            {
                                return false;
                            }
                            break;
                        default:
                            break;
                    }
                    i++;
                }
            }
            return true;
        }

        public static Boolean MailSecurityCheck(String Mail)
        {
            Boolean MailBool = false;
            if ( Mail.Contains('@').Equals(false) || Mail.Contains('.').Equals(false))
            {
                return false;
            }
            return MailBool;
        }
    }
}
