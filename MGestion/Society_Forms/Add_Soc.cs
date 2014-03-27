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
    }
}
