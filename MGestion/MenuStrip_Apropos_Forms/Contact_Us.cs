using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MGestion
{
    public partial class Contact_Us : Form
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            //Si on clique sur retour on ferme le formulaire actuel
            FindForm().Close();
        }

        private void BT_Send_Click(object sender, EventArgs e)
        {
            if (CB_FAI.SelectedItem != null && CB_FAI.SelectedItem != "")
            {
                try
                {
                    MailMessage Mail = new MailMessage(IB_SendFrom.Text.Trim(), "peter_53150@hotmail.fr"); //Oui j'ai mis une vieille adresse pourrie et alors
                    SmtpClient Customer = new SmtpClient(); //Déclare le nouvel objet smtp
                    Customer.Port = 25; //Déclare le port ( 25 par défaut ) 
                    Customer.DeliveryMethod = SmtpDeliveryMethod.Network; //On l'envois via le réseau ( internet , logique ) 
                    Customer.UseDefaultCredentials = false;
                    Customer.Host = "smtp." + CB_FAI.SelectedItem + ".fr"; //On utilise le smtp de chez gmail pourquoi se faire chier
                    Mail.Subject = IB_Object.Text.Trim();
                    Mail.Body = IB_Contains.Text.Trim();
                    Customer.Send(Mail);
                    MessageBox.Show("Le message a été transmis, merci de votre courtoisie.", "Successfull");
                    IB_Contains.Text = "";
                    IB_Object.Text = "";
                    IB_SendFrom.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Vérifier si les champs sont bien remplis avec des informations valide", "Erreur 013");
                }
            }
            
            
        }

        private void Contact_Us_Load(object sender, EventArgs e)
        {
            CB_FAI.SelectedIndex = 0;
        }


    }
}
