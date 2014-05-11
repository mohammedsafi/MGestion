using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods; //Using du namespace pour utiliser les methods
using MySql.Data.MySqlClient; //Using pour utiliser les DLL de mysql 

namespace MGestion
{
    public partial class Del_Soc : Form
    {
        public Del_Soc()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Ferme la fenêtre ou on se trouve
        }

        private void BT_Del_Soc_Click(object sender, EventArgs e)
        {
            //Si on veux supprimer l'entreprise
            String Request = "DELETE FROM societe WHERE Societe_Nom = '" + TB_Name_Todelete.Text.Trim() + "';"; //Requete SQL
            Boolean Error = true;
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Error = Methods_BDD.MakeABasicRequest(Connection, Request); //On test si l'on peut faire la requete
            if (!Error)
            {
                //Impossible de supprimer l'utilisateur
                MessageBox.Show("Impossible du supprimer la société", "Erreur 008");
            }
            else
            {
                //Supression OK 
                MessageBox.Show("La société a bien été supprimé", "Successfull");
            }
            Methods_BDD.CloseConnectionPossible(Connection); //Ferme la connexion si il n'y a pas d'erreur
        }
    }
}
