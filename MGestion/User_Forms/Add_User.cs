using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Inclusion du namespace pour le MySql
using MGestion.Methods; //Inclusion du namespace pour les méthodes

namespace MGestion
{
    public partial class BT_Add_User : Form
    {
        public BT_Add_User()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le formulaire sur lequel est l'utilisateur et le ferme
        }

        private void BT_Add_User_Click(object sender, EventArgs e)
        {
            //Si on clique sur ajouter l'utilisateur
            String Request = "";
            Boolean Error = true;
            MySqlConnection Connection;
            Connection = Methods_BDD.ConnectionPossible();
            Request = "INSERT INTO `personne` VALUES ('', '" + IB_Fam_Name.Text + "', '" + IB_Name.Text + "', '" + DTP_Naissance.Value.Date.ToString("yyyy-MM-dd").Trim() + "', '" + IB_Mail.Text + "', '" + IB_Fax_Number.Text + "', '" + IB_Address.Text + "', '" + IB_Job.Text + "', '" + IB_Phone_Number.Text + "', '" + IB_Password.Text + "', '" + IB_Website.Text + "');";
            Error = Methods_BDD.MakeABasicRequest(Connection, Request);
            if (!Error)
            {
                MessageBox.Show("L'ajout n'a pas été effectué","Erreur 006");
            }
            else
            {
                MessageBox.Show("L'ajout a été effectué", "Successfull");
            }
            Methods_BDD.CloseConnectionPossible(Connection);
        }
    }
}
