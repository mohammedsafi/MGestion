using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods; //Using du namespace des methods
using MySql.Data.MySqlClient; //DLL mysql

namespace MGestion
{
    public partial class Edit_User : Form
    {
        private List<String> Result = new List<String>(); //Crée la liste au cas ou on attend des params
        private String Tofind = "";

        public Edit_User()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le formulaire sur lequel est l'utilisateur et le ferme
        }

        private void Edit_User_Load(object sender, EventArgs e)
        {
            if (Result.Count != 0)
            {
                TB_Fam_Name.Text = Result[1]; //On affiche les data 
                TB_Name.Text = Result[2];
                DTP_Naissance.Value = Convert.ToDateTime(Result[3]);
                TB_Phone_Number.Text = Result[8];
                TB_Fax_Number.Text = Result[5];
                TB_Password.Text = Result[9];
                TB_Mail.Text = Result[4];
                TB_Address.Text = Result[6];
                TB_Job.Text = Result[7];
                TB_Website.Text = Result[10];
                IB_Mail_Tofind.ReadOnly = true; //On lock la recherche
                BT_Mail_Tofind.Enabled = false; //On vire le bouton pour eviter les bugs
                Tofind = Result[4].ToString();
            }
        }

        public Edit_User(List<String> Data)
        {
            InitializeComponent();
            Result = Data;
        }

        private void BT_Mail_Tofind_Click(object sender, EventArgs e)
        {
            Tofind = IB_Mail_Tofind.Text.Trim();
            LoadInfo();
        }

        private void BT_Edit_User_Click(object sender, EventArgs e)
        {
            String Request = ""; //String contenant la request
            Boolean Error = true; //Il y a une erreur ? 
            MySqlConnection Connection; //On déclare une nouvelle connexion vide
            Connection = Methods_BDD.ConnectionPossible(); //La connexion est possible ?
            Request = "UPDATE personne SET Personne_Nom='" + TB_Fam_Name.Text.Trim() + "',Personne_Prenom='" + TB_Name.Text.Trim() + "',Personne_DateNaiss='" + DTP_Naissance.Value.Date.ToString("yyyy-MM-dd").Trim() + "',Personne_Mail='" + TB_Mail.Text.Trim() + "', Personne_Fax='" + TB_Fax_Number.Text.Trim() + "',Personne_Adresse='" + TB_Address.Text.Trim() + "',Personne_Metier='" + TB_Job.Text.Trim() + "',Personne_Telephone='" + TB_Phone_Number.Text.Trim() + "',Personne_Password='" + TB_Password.Text.Trim() + "',Personne_SiteWeb='" + TB_Website.Text.Trim() + "' WHERE Personne_Mail='" + Tofind.Trim() + "';";
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
            Tofind = TB_Mail.Text.Trim();
            LoadInfo();
        }

        private void LoadInfo()
        {
            //On charge l'utilisateur séléctionné
            String Request = ""; //Requete SQL
            MySqlConnection Connection; //Déclare un nouvel objet de connexion
            Request = "SELECT * FROM personne WHERE Personne_Mail = '" + Tofind.Trim() + "';";
            Connection = Methods_BDD.ConnectionPossible(); //Ouvre la connexion si il n'y a pas d'erreur
            Result = Methods_BDD.MakeASelect(Connection, Request, 1);
            if (Result.Count != 0)
            {
                //Alors on affiche le truc
                TB_Fam_Name.Text = Result[1];
                TB_Name.Text = Result[2];
                DTP_Naissance.Value = Convert.ToDateTime(Result[3]);
                TB_Phone_Number.Text = Result[8];
                TB_Fax_Number.Text = Result[5];
                TB_Password.Text = Result[9];
                TB_Mail.Text = Result[4];
                TB_Address.Text = Result[6];
                TB_Job.Text = Result[7];
                TB_Website.Text = Result[10];
                //On vide l'inputbox
                IB_Mail_Tofind.Text = "";
                Tofind = Result[4].ToString();
            }
        }

    }
}
