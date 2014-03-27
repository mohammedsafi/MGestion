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
    }
}
