using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Inclusion de la biblio pour pouvoir utiliser les fichiers
using System.Windows.Forms; //Inclusion de la biblio pour pouvoir utiliser les mbox

namespace MGestion.Methods
{
    class Methods_File
    {
        public static void Connection_File_Presen() //Verifie la présence du fichier 
        {
            if (!(File.Exists("Connexion.conf"))) //Si le fichier de connexion n'est pas présent, alors il y une erreur
            {
                MessageBox.Show("Il vous manque le fichier Connexion.conf qui contient les informations de connexion, nous allons le re-crée", "Erreur 001"); //Affiche le message d'erreur 
                StreamWriter FichierACree = File.CreateText("Connexion.conf");
                FichierACree.Write("Database=CHOISIRVOTREBDD;" + Environment.NewLine + "server=ADRESSEIPDUSERVEUR;" + Environment.NewLine + "User Id=UTILISATEURAUTILISER;" + Environment.NewLine + "Pwd=PASSDELUTILISATEUR", true); //Ecrit la ligne
                FichierACree.Close(); //Ferme le flux en écriture
                MessageBox.Show("Fin de la re-création du fichier, merci de bien vouloir modifier les informations de connexion pour saisir les votre", "Re-création du fichier avec succès"); //Affiche le message que l'éxécution a reussis
            }
        }

        public static List<String> Load_File() //Charge le fichier dans une liste et la retourne
        {
            StreamReader LigneLue = new StreamReader("Connexion.conf"); //Crée un flux de lecture
            String Ligne = ""; //Ligne qui contiendra le retour de la lecture
            List<String> LigneRetourner = new List<String>(); //Liste qui sera retourné
            do //faire
            {
                Ligne = LigneLue.ReadLine(); //Stoque le retour de la lecture dans Ligne
                if (Ligne != "" && Ligne != null) //On ne stoque la chaine que si elle contient quelque chose
                {
                    LigneRetourner.Add(Ligne); //Ajoute la ligne a la liste qui contient le fichier chargé
                }
            } while (Ligne != "" && Ligne != null); //Tant qu'on est pas à la fin du fichier
            LigneLue.Close(); //Ferme le flux en lecture
            return LigneRetourner; //Retourne la liste 
        }

        public static String Change_List_ToString(List<String> ToChange)
        {
            Int16 cpteur = 0; //Variable compteur
            String ToReturn = ""; //Chaine a retourner
            do
            {
                ToReturn = ToReturn + ToChange.ElementAt(cpteur).ToString().TrimEnd('\n'); //Chaine recupéré
                cpteur++; //Incremente 1 au cpteur
            } while (cpteur < ToChange.Count()); //Tant qu'on a pas parcoue
            return ToReturn; //Renvois la chaine reconcatené
        } //Renvois la chaine de connexion

        public static List<String> Parse_List_ForInformation(List<String> ToParse) //Renvois une liste de string pour l'affichage et la modification
        {
            Int16 cpteur = 0; //Variable compteur
            String Temp = "";
            do
            {
                Temp = ToParse.ElementAt(cpteur).Split('=').ElementAt(1).ToString().TrimEnd(';'); //Stock la chaine parser dans la chaine temps
                ToParse.RemoveAt(cpteur); //Supprime ce que contenait la liste à l'index I 
                ToParse.Insert(cpteur, Temp); //Insert la nouvelle chaine à l'index I
                cpteur++; //Incremente 1 à I 

            } while (cpteur < ToParse.Count()); //Tant qu'on a pas parcoue
            return ToParse; //Renvois la chaine reconcatené
        }

        public static void SaveInformation(List<String> ToSave) //Sauvegarde les informations dans le fichier connexion.conf
        {
            File.Delete("Connexion.conf"); //On commence par supprimer le fichier
            String StringWrite = "";
            Int16 i = 0;
            StreamWriter ToWrite = File.CreateText("Connexion.conf"); //On recrée le fichier
            StringWrite = Change_List_ToString(ToSave); //On Récupère la chaine de connexion complète

            do //Faire
            {
                if (StringWrite[i] == ';') //Si on tombe sur un ;
                {
                    ToWrite.Write(StringWrite[i] + Environment.NewLine); //On l'écrit et on fait un retour à la ligne pour respecter la synthaxe du fichier 
                }
                else //Sinon
                {
                    ToWrite.Write(StringWrite[i]); //On écrit normalement
                }
                i++; //Incrémente un a i
            } while (i < StringWrite.Length); //On le fait tant qu'on a pas parcourure toute les chaines
            ToWrite.Close(); //Une fois que c'est fait on ferme le flux en écriture
        }


    }
}
