using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MGestion
{
    public partial class How_To_Use : Form
    {
        public How_To_Use()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            //Si on clique sur retour on ferme le formulaire actuel
            FindForm().Close();
        }

        private void BT_Open_Doc_Click(object sender, EventArgs e)
        {

            Process proc = new Process(); //Instancie un objet process
            String Path = Environment.CurrentDirectory + @"\\Documentation.txt";
            proc.StartInfo.FileName = Path;
            proc.Start(); //Lance le processus 
            proc.Close(); //On libère les ressources
        }
    }
}
