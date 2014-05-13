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
using MySql.Data.MySqlClient; //DLL mysql 

namespace MGestion
{
    public partial class Edit_Soc : Form
    {
        private List<String> Result = new List<String>(); //Crée la liste au cas ou on attend des params
        private String Tofind = "";

        public Edit_Soc()
        {
            InitializeComponent();
        }

        public Edit_Soc(List<String> Data)
        {
            InitializeComponent();
            Result = Data;
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Ferme le formulaire actuel
        }

        private void Edit_Soc_Load(object sender, EventArgs e)
        {
            //Au chargement
            if (Result.Count != 0)
            {
                BT_Name_Enterprise_Tofind.Enabled = false; //On vire le boutton
                TB_Name_Enterprise_Tofind.Enabled = false; //On vire la textbox
                Tofind = Result[1].ToString();
                LoadInfo();
            }
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

        private void BT_Name_Enterprise_Tofind_Click(object sender, EventArgs e)
        {
            Tofind = TB_Name_Enterprise_Tofind.Text.Trim();
            LoadInfo();
        }

        private void BT_Edit_Soc_Click(object sender, EventArgs e)
        {
            String Request = ""; //String contenant la request
            Boolean Error = true; //Il y a une erreur ? 
            MySqlConnection Connection; //On déclare une nouvelle connexion vide
            Connection = Methods_BDD.ConnectionPossible(); //La connexion est possible ?
            Request = "UPDATE societe SET Societe_Nom='"+ TB_Name.Text.Trim() +"', Societe_RaisonSocial='"+ TB_Social_Reason.Text.Trim() +"', Societe_Adresse='"+ TB_Address.Text.Trim() +"', Societe_Ville='"+ TB_City.Text.Trim()+"', Societe_Email='"+ TB_Mail.Text.Trim() +"', Societe_Telephone='"+ TB_Phone_Number.Text.Trim() +"', Societe_CodePostal='"+ Convert.ToInt32(TB_Code_Postal.Text.Trim())+"', Societe_Type='"+ TB_Type.Text.Trim() +"' WHERE Societe_Nom='"+ Tofind.Trim() +"'"; //Requete SQL
            Error = Methods_BDD.MakeABasicRequest(Connection, Request); //On effectue la request et on return un erreur
            if (!Error) //Si il y a  d'erreur 
            {
                MessageBox.Show("L'edition n'a pas été effectué", "Erreur 006"); //Alors on affiche le message d'erreur 006
                Tofind = TB_Name.Text.Trim();
            }
            else
            {
                MessageBox.Show("L'edition a été effectué", "Successfull"); //Sinon on indique que l'ajout a été effectué
            }
            Methods_BDD.CloseConnectionPossible(Connection); //On ferme la connexion
            LoadInfo();
        }

    }
}
