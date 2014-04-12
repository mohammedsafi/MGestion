using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGestion.Methods;
using System.Net;
using System.Net.NetworkInformation;

namespace MGestion
{
    public partial class Info_Connection : Form
    {
        public Info_Connection()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            //Si on clique sur retour on ferme le formulaire actuel
            FindForm().Close();
        }

        private void Info_Connection_Load(object sender, EventArgs e)
        {
            //Lors du lancement de ce formulaire
            List<String> Information = new List<String>();
            Information = Methods_File.Load_File(); //On charge le fichier dans la liste
            Information = Methods_File.Parse_List_ForInformation(Information); //Parse les informations pour récupérer la chaine 
            LBL_BDD.Text = LBL_BDD.Text + " " + Information.ElementAt(0).ToString(); //Affiche la BDD Actuellement utilisé
            LBL_IP_Server.Text = LBL_IP_Server.Text + " " + Information.ElementAt(1).ToString(); //Affiche l'IP actuel du serveur
            LBL_BDD_User.Text = LBL_BDD_User.Text + " " + Information.ElementAt(2).ToString(); //Affiche l'user actuel utilisé
            LBL_BDD_Pass.Text = LBL_BDD_Pass.Text + " " + Information.ElementAt(3).ToString(); //Afficher le pass actuel utilisé
            Ping AccessServeur = new Ping(); //Déclare un news objet ping

            try //Essaye
            {
                PingReply Response = AccessServeur.Send(Information.ElementAt(1).ToString()); //Ping l'ip ou le Name de la machine
                if (Response.Status == IPStatus.Success) //Si le truc est OK
                {
                    LBL_BDD_Check.Text = LBL_BDD_Check.Text + " ONLINE"; //Online si ça marche
                    LBL_Reply_Time_Ping.Text = LBL_Reply_Time_Ping.Text + " environs " + Response.RoundtripTime + "s"; //Temps de réponse
                }
            }
            catch (Exception)
            {
                LBL_BDD_Check.Text = LBL_BDD_Check.Text + " OFFLINE"; //Offline si ça marche pas
                LBL_Reply_Time_Ping.Text = LBL_Reply_Time_Ping.Text + " INJOIGNABLE"; //Injoignable si ça marche pas
            }

        }
    }
}
