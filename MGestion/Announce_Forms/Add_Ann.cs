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
    public partial class Add_Ann : Form
    {
        public Add_Ann()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Ferme le formulaire actuel
        }

        private void Add_Ann_Load(object sender, EventArgs e)
        {


            //On load les cbox 
            MySqlConnection Connection; //On déclare une nouvelle connexion vide
            String Request = "";  //String contenant la request
            Connection = Methods_BDD.ConnectionPossible();
            DataTable Table = new DataTable();

            //Load de la table Metier
            Request = "SELECT * FROM metier;";
            Table = Methods_BDD.GetTable(Connection, Request, "Metier_id", "Metier_Libelle");
            CB_Job_Cible.DataSource = Table.DefaultView;
            CB_Job_Cible.ValueMember = "Metier_id";
            CB_Job_Cible.DisplayMember = "Metier_Libelle";

            //Load de la table Contrat
            Request = "SELECT * FROM contrat;";
            Table = Methods_BDD.GetTable(Connection, Request, "Contrat_id", "Contrat_Libelle");
            CB_Ctrat_Type.DataSource = Table.DefaultView;
            CB_Ctrat_Type.ValueMember = "Contrat_id";
            CB_Ctrat_Type.DisplayMember = "Contrat_Libelle";
            
            //Load de la table société 
            Request = "SELECT * FROM societe;";
            Table = Methods_BDD.GetTable(Connection, Request, "Societe_id", "Societe_Nom");
            CB_Society_Author.DataSource = Table.DefaultView;
            CB_Society_Author.ValueMember = "Societe_id";
            CB_Society_Author.DisplayMember = "Societe_Nom";

            CB_Job_Cible.SelectedIndex = 0;
            CB_Society_Author.SelectedIndex = 0;
            CB_Ctrat_Type.SelectedIndex = 0;
        }

        private void BT_Add_Ann_Click(object sender, EventArgs e)
        {
            //Si on clique sur ajouter 
            String Request = "";
            Boolean Error = true;
            MySqlConnection Connection;
            Connection = Methods_BDD.ConnectionPossible();
            Request = "INSERT INTO annonce VALUES ('','" + IB_Title.Text.Trim() + "'," + IB_Time_Todiff.Text.Trim() + ",'" + DTP_Sart.Value.Date.ToString("yyyy-MM-dd").Trim() + "','" + IB_About_Post.Text.Trim() + "','" + IB_About_Profil.Text.Trim() + "','" + IB_Address.Text.Trim() + "','" + IB_City.Text.Trim() + "','" + IB_Code_Postal.Text.Trim() + "','" + IB_Mail.Text.Trim() + "','" + IB_Phone_Number.Text.Trim() + "'," + CB_Ctrat_Type.SelectedValue + "," + CB_Job_Cible.SelectedValue + "," + CB_Society_Author.SelectedValue + ",'" + IB_Ref.Text.Trim() +"');";
            Error = Methods_BDD.MakeABasicRequest(Connection, Request);
            if (!Error)
            {
                MessageBox.Show("L'ajout n'a pas été effectué", "Erreur 006");
            }
            else
            {
                MessageBox.Show("L'ajout a été effectué", "Successfull");
            }
            Methods_BDD.CloseConnectionPossible(Connection);
        }
    }
}
