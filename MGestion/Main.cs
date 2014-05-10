using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Inclusion du namespace pour utiliser les méthodes sur les fichiers
using MGestion.Methods;
//Namespace pour le test execute reader
using MySql.Data.MySqlClient;

namespace MGestion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BT_Add_User_Click(object sender, EventArgs e)
        {
            //Clique sur le bouton pour ajouter un utilisateur
            Add_User AddUser = new Add_User();
            AddUser.ShowDialog();
        }

        private void BT_See_User_Click(object sender, EventArgs e)
        {
            See_User SeeUser = new See_User();
            SeeUser.ShowDialog();
        }

        private void BT_Del_User_Click(object sender, EventArgs e)
        {
            Del_User DelUser = new Del_User();
            DelUser.ShowDialog();
        }

        private void BT_Edit_User_Click(object sender, EventArgs e)
        {
            Edit_User EditUser = new Edit_User();
            EditUser.ShowDialog();
        }

        private void BT_Add_Soc_Click(object sender, EventArgs e)
        {
            Add_Soc AddSoc = new Add_Soc();
            AddSoc.ShowDialog();
        }

        private void BT_See_Soc_Click(object sender, EventArgs e)
        {
            See_Soc SeeSoc = new See_Soc();
            SeeSoc.ShowDialog();
        }

        private void BT_Del_Soc_Click(object sender, EventArgs e)
        {
            Del_Soc DelSoc = new Del_Soc();
            DelSoc.ShowDialog();
        }

        private void BT_Edit_Soc_Click(object sender, EventArgs e)
        {
            Edit_Soc EditSoc = new Edit_Soc();
            EditSoc.ShowDialog();
        }

        private void BT_Add_Annon_Click(object sender, EventArgs e)
        {
            Add_Ann AddAnn = new Add_Ann();
            AddAnn.ShowDialog();
        }

        private void BT_See_Annon_Click(object sender, EventArgs e)
        {
            See_Ann SeeAnn = new See_Ann();
            SeeAnn.ShowDialog();
        }

        private void BT_Del_Annon_Click(object sender, EventArgs e)
        {
            Del_Ann DelAnn = new Del_Ann();
            DelAnn.ShowDialog();
        }

        private void BT_Edit_Annon_Click(object sender, EventArgs e)
        {
            Edit_Ann EditAnn = new Edit_Ann();
            EditAnn.ShowDialog();
        }

        private void informationDeConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si on clique sur les informations de connexion
            Info_Connection InfoConnection = new Info_Connection();
            InfoConnection.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Si on quitte le programme 
            Quit_Programs QuitPrograms = new Quit_Programs();
            QuitPrograms.ShowDialog();
        }

        private void modificationDeLaConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si on veux modifier les informations de connexion
            Edit_Connection EditConnection = new Edit_Connection();
            EditConnection.ShowDialog();
        }

        private void commentUtiliserCetteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si on veux ouvrir la documentation de l'application
            How_To_Use HowToUse = new How_To_Use();
            HowToUse.ShowDialog();
        }

        private void informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information_Connexion_BDD InformationConnexionBDD = new Information_Connexion_BDD();
            InformationConnexionBDD.ShowDialog();
        }

        private void commentConfigurerSaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            How_To_Configure HowToConfigure = new How_To_Configure();
            HowToConfigure.ShowDialog();
        }

        private void informationLégaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Legal_Information LegalInformation = new Legal_Information();
            LegalInformation.ShowDialog();
        }

        private void nousContacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_Us ContactUs = new Contact_Us();
            ContactUs.ShowDialog();
        }

        private void remerciementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thanks_To ThanksTo = new Thanks_To();
            ThanksTo.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //ANCIEN TEST KK QUE JE VEUX PAS DELETE 

            //String Request = "SELECT * FROM personne WHERE Personne_Id = 5;";
            //List<String> Data = new List<String>();
            //MySqlConnection Connection;
            //Connection = Methods_BDD.ConnectionPossible();
            //Data = Methods_BDD.MakeASelect(Connection, Request, 1);
            //Int16 I = 0;
            //Int16 Countest = 0;
            //while (I < Data.Count)
            //{
            //    String MSG = "VALUE : " + Data.ElementAt(I).ToString();
            //    String TITLE = "ELEMENT : " + I.ToString();
            //    MessageBox.ShowDialog(MSG, TITLE);
            //    I++;
            //}
            //Countest = Methods_BDD.MakeACount(Connection, "SELECT COUNT(*) FROM personne;");
            //string test = Countest.ToString();
            //MessageBox.ShowDialog(test, "COUNT");
            //Methods_BDD.CloseConnectionPossible(Connection);
            

        }
    }
}
