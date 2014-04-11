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
            AddUser.Show();
        }

        private void BT_See_User_Click(object sender, EventArgs e)
        {
            See_User SeeUser = new See_User();
            SeeUser.Show();
        }

        private void BT_Del_User_Click(object sender, EventArgs e)
        {
            Del_User DelUser = new Del_User();
            DelUser.Show();
        }

        private void BT_Edit_User_Click(object sender, EventArgs e)
        {
            Edit_User EditUser = new Edit_User();
            EditUser.Show();
        }

        private void BT_Add_Soc_Click(object sender, EventArgs e)
        {
            Add_Soc AddSoc = new Add_Soc();
            AddSoc.Show();
        }

        private void BT_See_Soc_Click(object sender, EventArgs e)
        {
            See_Soc SeeSoc = new See_Soc();
            SeeSoc.Show();
        }

        private void BT_Del_Soc_Click(object sender, EventArgs e)
        {
            Del_Soc DelSoc = new Del_Soc();
            DelSoc.Show();
        }

        private void BT_Edit_Soc_Click(object sender, EventArgs e)
        {
            Edit_Soc EditSoc = new Edit_Soc();
            EditSoc.Show();
        }

        private void BT_Add_Annon_Click(object sender, EventArgs e)
        {
            Add_Ann AddAnn = new Add_Ann();
            AddAnn.Show();
        }

        private void BT_See_Annon_Click(object sender, EventArgs e)
        {
            See_Ann SeeAnn = new See_Ann();
            SeeAnn.Show();
        }

        private void BT_Del_Annon_Click(object sender, EventArgs e)
        {
            Del_Ann DelAnn = new Del_Ann();
            DelAnn.Show();
        }

        private void BT_Edit_Annon_Click(object sender, EventArgs e)
        {
            Edit_Ann EditAnn = new Edit_Ann();
            EditAnn.Show();
        }

        private void informationDeConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si on clique sur les informations de connexion
            Info_Connection InfoConnection = new Info_Connection();
            InfoConnection.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Si on quitte le programme 
            Quit_Programs QuitPrograms = new Quit_Programs();
            QuitPrograms.Show();
        }

        private void modificationDeLaConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si on veux modifier les informations de connexion
            Edit_Connection EditConnection = new Edit_Connection();
            EditConnection.Show();
        }

        private void commentUtiliserCetteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si on veux ouvrir la documentation de l'application
            How_To_Use HowToUse = new How_To_Use();
            HowToUse.Show();
        }

        private void informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information_Connexion_BDD InformationConnexionBDD = new Information_Connexion_BDD();
            InformationConnexionBDD.Show();
        }

        private void commentConfigurerSaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            How_To_Configure HowToConfigure = new How_To_Configure();
            HowToConfigure.Show();
        }

        private void informationLégaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Legal_Information LegalInformation = new Legal_Information();
            LegalInformation.Show();
        }

        private void nousContacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_Us ContactUs = new Contact_Us();
            ContactUs.Show();
        }

        private void remerciementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thanks_To ThanksTo = new Thanks_To();
            ThanksTo.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<String> name = new List<String>();
            List<String> teste = new List<String>();
            String test = "";
            int i = 0;
            //Lorsqu'on lance l'application on vérifie la présence des fichiers requis
            //Verification du fichier connexion.conf
            Methods_File.Connection_File_Presen();
            name = Methods_File.Load_File();
            teste = Methods.Methods_File.Load_File();
            test = Methods_File.Change_List_ToString(name);
            teste = Methods_File.Parse_List_ForInformation(teste);
            do
            {
                MessageBox.Show("Case : " + i + " Contient : " + (teste.ElementAt(i).ToString()) , "VALUE");
                i++;
            } while (i < teste.Count);
            
        }
    }
}
