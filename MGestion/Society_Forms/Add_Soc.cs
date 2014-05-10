using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods; //Utilisation du namespace des methods 
using MySql.Data.MySqlClient; //Utilisation de la DLL de mysql 

namespace MGestion
{
    public partial class Add_Soc : Form
    {
        public Add_Soc()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le nom du formulaire ou l'on se trouve et le ferme
        }

        private void BT_Add_Soc_Click(object sender, EventArgs e)
        {
            //Si on ajoute une société 
            String Request = "";
            Boolean Error = true;
            MySqlConnection Connection;
            Connection = Methods_BDD.ConnectionPossible();
            Request = "INSERT INTO `societe` VALUES ('','" + TB_Name.Text.Trim() + "','" + TB_Social_Reason.Text.Trim() + "','" + TB_Address.Text.Trim() +"','"+ TB_City.Text.Trim() +"','"+ TB_Mail.Text.Trim() +"','"+ TB_Phone_Number.Text.Trim() +"','"+ TB_Code_Postal.Text.Trim() +"','"+ TB_Type.Text.Trim() +"');";
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
