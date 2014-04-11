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
    public partial class Quit_Programs : Form
    {
        public Quit_Programs()
        {
            InitializeComponent();
        }

        private void LBL_Return_Click(object sender, EventArgs e)
        {
            //Si on change d'avis
            FindForm().Close();
        }

        private void BT_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
