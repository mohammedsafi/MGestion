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
    public partial class Edit_Ann : Form
    {
        public Edit_Ann()
        {
            InitializeComponent();
        }

        private void Edit_Ann_Load(object sender, EventArgs e)
        {

        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            FindForm().Close(); //Ferme le formulaire actuel
        }
    }
}
