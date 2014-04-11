using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods;

namespace MGestion
{
    public partial class Edit_Connection : Form
    {
        public Edit_Connection()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            //Si on clique sur retour on ferme le formulaire actuel
            FindForm().Close();
        }

        private void Edit_Connection_Load(object sender, EventArgs e)
        {
            //Lors du lancement de ce formulaire
            List<String> Information = new List<String>();
            Information = Methods_File.Load_File(); //On charge le fichier dans la liste
            Information = Methods_File.Parse_List_ForInformation(Information); //Parse les informations pour récupérer la chaine 
            IB_Edit_BDD_Used.Text = Information.ElementAt(0).ToString(); //Affiche la BDD Actuellement utilisé
            IB_Edit_Ip_Server.Text = Information.ElementAt(1).ToString(); //Affiche l'IP actuel du serveur
            IB_Edit_BDD_User.Text = Information.ElementAt(2).ToString(); //Affiche l'user actuel utilisé
            IB_Edit_BDD_Pass.Text = Information.ElementAt(3).ToString(); //Afficher le pass actuel utilisé 
        }

        private void BT_Valid_Edit_Click(object sender, EventArgs e)
        {
            //Si on ajoute les informations
            List<String> ToSave = new List<String>(); //Crée la liste contenant les info
            ToSave.Add("Database=" + IB_Edit_BDD_Used.Text.Trim() + ";"); // ---- DEBUT RECUP DES INFOS ---- //
            ToSave.Add("server=" + IB_Edit_Ip_Server.Text.Trim() + ";");
            ToSave.Add("User Id=" + IB_Edit_BDD_User.Text.Trim() + ";");
            ToSave.Add("Pwd=" + IB_Edit_BDD_Pass.Text.Trim());// ---- FIN RECUP DES INFOS ---- //
            if (IB_Edit_BDD_Used.Text != "" && IB_Edit_Ip_Server.Text != "" && IB_Edit_BDD_User.Text!= "" && IB_Edit_BDD_Pass.Text != "") //Verifie quand même au cas ou
            {
                Methods_File.SaveInformation(ToSave); //Sauvegarde les informations
                MessageBox.Show("Modifications apportées à la connexion avec succès","Modification effectué");
                FindForm().Close(); //Ferme le formulaire
            }
            else //Sinon message d'erreur 
            {
                MessageBox.Show("L'un des champs remplis est vide","Erreur 002"); //Erreur
            }
            
            
        }
    }
}
