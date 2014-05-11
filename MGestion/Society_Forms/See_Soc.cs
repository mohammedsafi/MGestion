using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods; //Namespace des methods
using MySql.Data.MySqlClient; //Namespace des DLL mysql 

namespace MGestion
{
    public partial class See_Soc : Form
    {

        private List<String> Result = new List<String>(); //Crée la liste au cas ou on attend des params
        private String Tofind = "";

        public See_Soc()
        {
            InitializeComponent();
        }

        private void See_Soc_Load(object sender, EventArgs e)
        {

        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le nom du formulaire ou l'on se trouve et le ferme
        }

        private void BT_Name_Enterprise_Tofind_Click(object sender, EventArgs e)
        {
            Tofind = TB_Name_Enterprise_Tofind.Text.Trim();
            TB_Name_Enterprise_Tofind.Text = "";
            LoadInfo();
        }

        private void LoadInfo()
        {
            //On charge l'utilisateur séléctionné
            String Request = ""; //Requete SQL
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM societe WHERE Societe_Nom = '" + Tofind.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 2);
            if (Result.Count != 0)
            {
                //Alors on affiche le truc
                TB_Name.Text = Result[1].ToString();
                TB_Social_Reason.Text = Result[2].ToString();
                TB_Address.Text = Result[3].ToString();
                TB_City.Text = Result[4].ToString();
                TB_Mail.Text = Result[5].ToString();
                TB_Phone_Number.Text = Result[6].ToString();
                TB_Code_Postal.Text = Result[7].ToString();
                TB_Type.Text = Result[8].ToString();

            }
        }

        private void BT_Del_Soc_Click(object sender, EventArgs e)
        {
            if (Result.Count != 0)
            {
                //Si on veux supprimer l'entreprise
                String Request = "DELETE FROM societe WHERE Societe_Nom = '" + Tofind.Trim() + "';"; //Requete SQL
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
                TB_Name.Text = "";
                TB_Social_Reason.Text = "";
                TB_Address.Text = "";
                TB_City.Text = "";
                TB_Mail.Text = "";
                TB_Phone_Number.Text = "";
                TB_Code_Postal.Text = "";
                TB_Type.Text = "";
            }
            else
            {
                MessageBox.Show("Vous n'avez rechercher aucune société, vous ne pourrez donc pas en supprimer une, refléchissez !", "Erreur 011");
            }
            
        }
    }
}
