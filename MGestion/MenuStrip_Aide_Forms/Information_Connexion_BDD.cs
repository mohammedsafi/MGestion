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
    public partial class Information_Connexion_BDD : Form
    {
        public Information_Connexion_BDD()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            //Si on clique sur retour on ferme le formulaire actuel
            FindForm().Close();
        }
    }
}
