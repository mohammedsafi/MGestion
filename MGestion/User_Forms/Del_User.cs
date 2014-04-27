using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Inclusion du namespace pour le MySql
using MGestion.Methods; //Inclusion du namespace pour les méthodes

namespace MGestion
{
    public partial class Del_User : Form
    {
        public Del_User()
        {
            InitializeComponent();
        }


        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le formulaire sur lequel est l'utilisateur et le ferme
        }

        private void BT_Del_User_Click(object sender, EventArgs e)
        {
            //Si on veux supprimer l'utilisateur
            String Request = "DELETE FROM personne WHERE Personne_Mail = '" + IB_Mail_Tofind.Text +"';"; //Requete SQL
            Boolean Error = true;
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Error = Methods_BDD.MakeABasicRequest(Connection, Request); //On test si l'on peut faire la requete
            if (!Error)
            {
                //Impossible de supprimer l'utilisateur
                MessageBox.Show("Impossible du supprimer l'utilisateur","Erreur 008");
            }
            else
            {
                //Supression OK 
                MessageBox.Show("L'utilisateur a bien été supprimé", "Successfull");
            }
            Methods_BDD.CloseConnectionPossible(Connection); //Ferme la connexion si il n'y a pas d'erreur
        }
    }
}
