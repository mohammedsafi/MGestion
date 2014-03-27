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
    public partial class Del_User : Form
    {
        public Del_User()
        {
            InitializeComponent();
        }

        private void Del_User_Load(object sender, EventArgs e)
        {

        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Récupère le formulaire sur lequel est l'utilisateur et le ferme
        }
    }
}
