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
    public partial class Edit_Ann : Form
    {
        private List<String> Result = new List<String>(); //Crée la liste au cas ou on attend des params
        private String Tofind = "";

        public Edit_Ann()
        {
            InitializeComponent();
        }

        public Edit_Ann(List<String> Data)
        {
            InitializeComponent();
            Result = Data;
        }

        private void Edit_Ann_Load(object sender, EventArgs e)
        {
            if (Result.Count != 0 && Result != null)
            {
                LoadCbox(1);
                LoadCbox(2);
                LoadCbox(3);
                //Alors on affiche le truc
                IB_Title.Text = Result[1].ToString();
                IB_Time_Todiff.Text = Result[2].ToString();
                DTP_Start.Value = Convert.ToDateTime(Result[3]);
                IB_About_Post.Text = Result[4].ToString();
                IB_About_Profil.Text = Result[5].ToString();
                IB_Address.Text = Result[6].ToString();
                IB_City.Text = Result[7].ToString();
                IB_Code_Postal.Text = Result[8].ToString();
                IB_Mail.Text = Result[9].ToString();
                IB_Phone_Number.Text = Result[10].ToString();
                CB_Ctrat_Type.SelectedValue = Convert.ToInt16(Result[11]);
                CB_Job_Cible.SelectedValue = Convert.ToInt16(Result[12]);
                CB_Author.SelectedValue = Convert.ToInt16(Result[13]);
                IB_Ref.Text = Result[14].ToString();

                TB_Ref_Tofind.Enabled = false;
                BT_Ref_Tofind.Enabled = false;
            }
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Ferme le formulaire actuel
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
                DTP_Start.Value = Convert.ToDateTime(Result[3]);
                IB_About_Post.Text = Result[4].ToString();
                IB_About_Profil.Text = Result[5].ToString();
                IB_Address.Text = Result[6].ToString();
                IB_City.Text = Result[7].ToString();
                IB_Code_Postal.Text = Result[8].ToString();
                IB_Mail.Text = Result[9].ToString();
                IB_Phone_Number.Text = Result[10].ToString();
                CB_Ctrat_Type.SelectedValue = Convert.ToInt16(Result[11]);
                CB_Job_Cible.SelectedValue = Convert.ToInt16(Result[12]);
                CB_Author.SelectedValue = Convert.ToInt16(Result[13]);
                IB_Ref.Text = Result[14].ToString();

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

        private void BT_Edit_Ann_Click(object sender, EventArgs e)
        {
            String Request = ""; //String contenant la request
            Boolean Error = true; //Il y a une erreur ? 
            MySqlConnection Connection; //On déclare une nouvelle connexion vide
            Connection = Methods_BDD.ConnectionPossible(); //La connexion est possible ?
            Request = "UPDATE annonce SET Annonce_Titre='" + IB_Title.Text.Trim() + "', Annonce_Duree_Diffusion=" + Convert.ToInt32(IB_Time_Todiff.Text) + ", Annonce_Debut_Ctrat='" + DTP_Start.Value.Date.ToString("yyyy-MM-dd").Trim() + "', Annonce_Detail_Poste='" + IB_About_Post.Text.Trim() + "', Annonce_Detail_Profil='" + IB_About_Profil.Text.Trim() + "', Annonce_Adresse='" + IB_Address.Text.Trim() + "', Annonce_Ville='" + IB_City.Text.Trim() + "', Annonce_CP='" + IB_Code_Postal.Text.Trim() + "',Annonce_Mail='" + IB_Mail.Text.Trim() + "', Annonce_Telephone='" + IB_Phone_Number.Text.Trim() + "', Annonce_Type_Contrat=" + CB_Ctrat_Type.SelectedValue + ", Annonce_Metier_Cible=" + CB_Job_Cible.SelectedValue + ", Annonce_Societe=" + CB_Author.SelectedValue + ", Annonce_Ref='" + IB_Ref.Text.Trim() +"' WHERE Annonce_Ref='"+ Tofind.Trim()+"';";
            Error = Methods_BDD.MakeABasicRequest(Connection, Request); //On effectue la request et on return un erreur
            if (!Error) //Si il y a  d'erreur 
            {
                MessageBox.Show("L'edition n'a pas été effectué", "Erreur 006"); //Alors on affiche le message d'erreur 0006
            }
            else
            {
                MessageBox.Show("L'edition a été effectué", "Successfull"); //Sinon on indique que l'ajout a été effectué
            }
            Methods_BDD.CloseConnectionPossible(Connection); //On ferme la connexion
            Tofind = IB_Ref.Text.Trim();
            LoadInfo();
        }

    }
}
