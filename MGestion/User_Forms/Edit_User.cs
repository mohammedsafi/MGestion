using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGestion
{
    public partial class Edit_User : Form
    {
        private List<String> Result = new List<String>(); //Crée la liste au cas ou on attend des params 

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
                TB_Birthdate.Text = Result[3];
                TB_Phone_Number.Text = Result[8];
                TB_Fax_Number.Text = Result[5];
                TB_Password.Text = Result[9];
                TB_Mail.Text = Result[4];
                TB_Address.Text = Result[6];
                TB_Job.Text = Result[7];
                TB_Website.Text = Result[10];
                IB_Mail_Tofind.ReadOnly = true; //On lock la recherche
                BT_Mail_Tofind.Enabled = false; //On vire le bouton pour eviter les bugs
            }
        }

        public Edit_User(List<String> Data)
        {
            InitializeComponent();
            Result = Data;
        }

    }
}
