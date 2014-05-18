using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MGestion.Methods;

namespace MGestion
{
    public partial class Del_Ann : Form
    {
        public Del_Ann()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Ferme le formulaire actuel
        }

        private void BT_Ref_Todelete_Click(object sender, EventArgs e)
        {
            //Si on veux supprimer l'annonce
            String Request = "DELETE FROM annonce WHERE Annonce_Ref = '" + TB_Ref_Todelete.Text.Trim() + "';"; //Requete SQL
            Boolean Error = true;
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Error = Methods_BDD.MakeABasicRequest(Connection, Request); //On test si l'on peut faire la requete
            if (!Error)
            {
                //Impossible de supprimer l'annonce
                MessageBox.Show("Impossible du supprimer l'annonce", "Erreur 008");
            }
            else
            {
                //Supression OK 
                MessageBox.Show("L'annonce a bien été supprimé", "Successfull");
            }
            Methods_BDD.CloseConnectionPossible(Connection); //Ferme la connexion si il n'y a pas d'erreur
        }
    }
}
