using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods; //Namespace des methodes
using MySql.Data.MySqlClient; //DLL mysql

namespace MGestion
{
    public partial class See_User : Form
    {
        private List<String> Result = new List<String>(); //Crée la liste 

        public See_User()
        {
            InitializeComponent();
        }

        private void See_User_Load(object sender, EventArgs e)
        {
            
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le formulaire sur lequel est l'utilisateur et le ferme
        }

        private void BT_MailToFind_Click(object sender, EventArgs e)
        {
            //On charge l'utilisateur séléctionné
            String Request = ""; //Requete SQL
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM personne WHERE Personne_Mail = '" + IB_Mail_Tofind.Text.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 1);
            if (Result != null)
            {
                //Alors on affiche le truc
                TB_Fam_Name.Text = Result[1];
                TB_Name.Text = Result[2];
                TB_Birthdate.Text = Result[3];
                TB_Phone_Number.Text = Result[8];
                TB_Fax_Number.Text = Result[5];
                TB_Password.Text = Result[9];
                TB_Mail.Text = Result[4];
                TB_Address.Text = Result[6];
                TB_Job.Text = Result[7];
                TB_Website.Text = Result[10];
                //On vide l'inputbox
                IB_Mail_Tofind.Text = "";
            }
            else
            {
                MessageBox.Show("Impossible de trouver ou d'effectuer cette requête", "Erreur");
            }
            Methods_BDD.CloseConnectionPossible(Connection); //Ferme la connexion si il n'y a pas d'erreur
        }

        private void BT_Del_User_Click(object sender, EventArgs e)
        {
            if ( Result.Count != 0)
            {
                //Si on veux supprimer cet utilisateur
                String Request = "DELETE FROM personne WHERE Personne_Id = '" + Result[0] + "';"; //Requete SQL
                Boolean Error = true;
                MySqlConnection Connection; //Déclare un nouvel objet de connexion
                Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
                Error = Methods_BDD.MakeABasicRequest(Connection, Request); //On test si l'on peut faire la requete
                if (!Error)
                {
                    //Impossible de supprimer l'utilisateur
                    MessageBox.Show("Impossible du supprimer l'utilisateur", "Erreur 008");
                }
                else
                {
                    //Supression OK 
                    MessageBox.Show("L'utilisateur a bien été supprimé", "Successfull");
                }
                Methods_BDD.CloseConnectionPossible(Connection); //Ferme la connexion si il n'y a pas d'erreur
                //Alors on affiche le truc
                TB_Fam_Name.Text = "";
                TB_Name.Text = "";
                TB_Birthdate.Text = "";
                TB_Phone_Number.Text = "";
                TB_Fax_Number.Text = "";
                TB_Password.Text = "";
                TB_Mail.Text = "";
                TB_Address.Text = "";
                TB_Job.Text = "";
                TB_Website.Text = "";
            }
            else
            {
                MessageBox.Show("Vous n'avez rechercher aucun utilisateur, vous ne pourrez donc pas en supprimer un, refléchissez !","Erreur 009");
            }
        
        }

        private void BT_Edit_User_Click(object sender, EventArgs e)
        {
            if (Result.Count != 0)
            {
                Edit_User EditBySee = new Edit_User(this.Result);
                EditBySee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n'avez rechercher aucun utilisateur, vous ne pourrez donc pas en modifier un, refléchissez !", "Erreur 010");
            }
            
        }


    }
}
