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
        public static String GetErrorString(Int16 ErrorNumber)
        {
            String ErrorString = "";
            switch (ErrorNumber)
            {
                case 1:
                    ErrorString = "L'email que vous venez de saisir est déjà utilisé en base de donnée";
                    break;
                case 2:
                    ErrorString = "Le nom de société que vous venez de saisir est déjà utilisé en base de donnée";
                    break;
                case 3:
                    ErrorString = "La référence d'annonce que vous venez de saisir est déjà utilisé en base de donnée";
                    break;
                case 4:
                    ErrorString = "Ce champ ne peux contenir que des chiffres..";
                    break;
                case 5:
                    ErrorString = "Le mot de passe doit faire 6 caractère ou plus pour être valide";
                    break;
                case 6:
                    ErrorString = "Certain caractère ne sont pas autorisé, exemple : caractère spéciaux, chiffre, etc.. ";
                    break;
                case 7:
                    ErrorString = "L'url n'est pas correcte, elle doit commencer par http://www.";
                    break;
                case 8:
                    ErrorString = "le format de l'adresse mail n'est pas valide.. ";
                    break;
                default:
                    break;
            }
            return ErrorString;
        }

        public static Int16 AvailableUserMail(String ToSearch)
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
                    return 1;
                }
            }
            catch (Exception)
            {

            }
            return 0;
        } //Erreur 1

        public static Int16 AvailableSocietyName(String ToSearch)
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
                    return 2;
                }
            }
            catch (Exception)
            {

            }
            return 0;
        } //Erreur 2

        public static Int16 AvailableAnnounceRef(String ToSearch)
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
                    return 3;
                }
            }
            catch (Exception)
            {

            }
            return 0;
        }//Erreur 3

        public static Int16 IsInteger(String value)
        {
            Int32 number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                return 0;
            }
            else
            {
                return 4;
            }
        }//Erreur 4

        public static Int16 PasswordUserSecurityCheck(String Password)
        {
            if (Password.Length >= 6)
            {
                return 0;
            }
            else
            {
                return 5;
            }
        }//Erreur 5

        public static Int16 StringSecurityCheck(String StringToCheck)
        {
            foreach ( Char C in StringToCheck)
            {
                if (C <= 64 && C >= 90 || C <= 96 && C >= 122 )
                {
                    return 6;
                }
            }
            return 0;
        }//Erreur 6

        public static Int16 URLSecurityCheck(String URL)
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
                                return 7;
                            }
                            break;
                        case 2:
                            if (C != 't')
                            {
                                return 7;
                            }
                            break;
                        case 3:
                            if (C != 't')
                            {
                                return 7;
                            }
                            break;
                        case 4:
                            if (C != 'p')
                            {
                                return 7;
                            }
                            break;
                        case 5:
                            if (C != ':')
                            {
                                return 7;
                            }
                            break;
                        case 6:
                            if (C != '/')
                            {
                                return 7;
                            }
                            break;
                        case 7:
                            if (C != '/')
                            {
                                return 7;
                            }
                            break;
                        case 8:
                            if (C != 'w')
                            {
                                return 7;
                            }
                            break;
                        case 9:
                            if (C != 'w')
                            {
                                return 7;
                            }
                            break;
                        case 10:
                            if (C != 'w')
                            {
                                return 7;
                            }
                            break;
                        case 11:
                            if (C != '.')
                            {
                                return 7;
                            }
                            break;
                        default:
                            break;
                    }
                    i++;
                }
            }
            return 0;
        }//Erreur 7

        public static Int16 MailSecurityCheck(String Mail)
        {
            Boolean MailBool = false;
            if ( Mail.Contains('@').Equals(false) || Mail.Contains('.').Equals(false))
            {
                return 8;
            }
            return 0;
        }//Erreur 8

    }
}
