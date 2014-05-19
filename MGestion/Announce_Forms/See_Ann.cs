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
    public partial class See_Ann : Form
    {
        private List<String> Result = new List<String>(); //Crée la liste au cas ou on attend des params
        private String Tofind = "";
        private Int16 OriginalJob = -1;
        private Int16 OriginalType = -1;
        private Int16 OriginalAuthor = -1;

        public See_Ann()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); // Ferme le formulaire actuel
        }

        private void See_Ann_Load(object sender, EventArgs e)
        {

        }

        private void BT_Ref_Tofind_Click(object sender, EventArgs e)
        {
            Tofind = TB_Ref_Tofind.Text.Trim();
            LoadInfo();
        }

        private void LoadInfo()
        {
            //On charge l'utilisateur séléctionné
            String Request = ""; //Requete SQL
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM annonce WHERE Annonce_Ref = '" + Tofind.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 3);
            if (Result.Count != 0)
            {
                LoadCbox(1);
                LoadCbox(2);
                LoadCbox(3);
                //Alors on affiche le truc
                IB_Title.Text = Result[1].ToString();
                IB_Time_Todiff.Text = Result[2].ToString();
                IB_Date_Topost.Text = Result[3].ToString();
                IB_About_Post.Text = Result[4].ToString();
                IB_About_Profil.Text = Result[5].ToString();
                IB_Address.Text = Result[6].ToString();
                IB_City.Text = Result[7].ToString();
                IB_Code_Postal.Text = Result[8].ToString();
                IB_Mail.Text = Result[9].ToString();
                IB_Phone_Number.Text = Result[10].ToString();
                OriginalType = Convert.ToInt16(Result[11]);
                CB_Ctrat_Type.SelectedValue = Convert.ToInt16(Result[11]);
                OriginalJob = Convert.ToInt16(Result[12]);
                CB_Job_Cible.SelectedValue = Convert.ToInt16(Result[12]);
                OriginalAuthor = Convert.ToInt16(Result[13]);
                CB_Author.SelectedValue = Convert.ToInt16(Result[13]);
                LBL_Ref_Ann.Text = LBL_Ref_Ann.Text + " " + Result[14].ToString();
                
                //On vide l'inputbox
                TB_Ref_Tofind.Text = "";
                //Tofind = Result[4].ToString();
            }
        }

        private void LoadCbox(Int16 CboxToLoad)
        {
            //On load les cbox 
            MySqlConnection Connection; //On déclare une nouvelle connexion vide
            String Request = "";  //String contenant la request
            Connection = Methods_BDD.ConnectionPossible();
            DataTable Table = new DataTable();
            switch (CboxToLoad)
            {
                case 1:
                    //Load de la table Metier
                    Request = "SELECT * FROM metier;";
                    Table = Methods_BDD.GetTable(Connection, Request, "Metier_id", "Metier_Libelle");
                    CB_Job_Cible.DataSource = Table.DefaultView;
                    CB_Job_Cible.ValueMember = "Metier_id";
                    CB_Job_Cible.DisplayMember = "Metier_Libelle";
                    break;
                case 2:
                    //Load de la table Contrat
                    Request = "SELECT * FROM contrat;";
                    Table = Methods_BDD.GetTable(Connection, Request, "Contrat_id", "Contrat_Libelle");
                    CB_Ctrat_Type.DataSource = Table.DefaultView;
                    CB_Ctrat_Type.ValueMember = "Contrat_id";
                    CB_Ctrat_Type.DisplayMember = "Contrat_Libelle";
                    break;
                case 3:
                    //Load de la table société 
                    Request = "SELECT * FROM societe;";
                    Table = Methods_BDD.GetTable(Connection, Request, "Societe_id", "Societe_Nom");
                    CB_Author.DataSource = Table.DefaultView;
                    CB_Author.ValueMember = "Societe_id";
                    CB_Author.DisplayMember = "Societe_Nom";
                    break;
                default:
                    break;
            }
        }

        private void CB_Ctrat_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OriginalType != -1)
            {
                CB_Ctrat_Type.SelectedValue = OriginalType; 
            }
            
        }

        private void CB_Job_Cible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OriginalJob != -1)
            {
                CB_Job_Cible.SelectedValue = OriginalJob;
            }
            
        }

        private void CB_Author_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OriginalAuthor != -1)
            {
                CB_Author.SelectedValue = OriginalAuthor;
            }
           
        }

        private void BT_Del_Ann_Click(object sender, EventArgs e)
        {
            if (Result.Count != 0 && Result != null)
            {
                //Si on veux supprimer l'annonce
                String Request = "DELETE FROM annonce WHERE Annonce_Id = " + Result[0] + ";"; //Requete SQL
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
            else
            {
                MessageBox.Show("Impossible de supprimer l'annonce car vous n'avez rien rechercher l'ami..","Erreur 014");
            }
            
        }

        private void BT_Edit_Ann_Click(object sender, EventArgs e)
        {
            if (Result.Count != 0 && Result != null)
            {
                Edit_Ann EditAnn = new Edit_Ann(Result);
                EditAnn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Impossible de modifier l'annonce car vous n'avez rien rechercher l'ami..", "Erreur 015");
            }
            
        }
    }
}
