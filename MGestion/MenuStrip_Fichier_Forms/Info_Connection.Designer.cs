namespace MGestion
{
    partial class Info_Connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Connection));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_IP_Server = new System.Windows.Forms.Label();
            this.LBL_BDD_User = new System.Windows.Forms.Label();
            this.LBL_BDD_Pass = new System.Windows.Forms.Label();
            this.LBL_BDD_Check = new System.Windows.Forms.Label();
            this.LBL_Reply_Time_Ping = new System.Windows.Forms.Label();
            this.BT_Return = new System.Windows.Forms.Button();
            this.LBL_BDD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(56, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(293, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Informations sur la connexion";
            // 
            // LBL_IP_Server
            // 
            this.LBL_IP_Server.AutoSize = true;
            this.LBL_IP_Server.Location = new System.Drawing.Point(13, 113);
            this.LBL_IP_Server.Name = "LBL_IP_Server";
            this.LBL_IP_Server.Size = new System.Drawing.Size(120, 13);
            this.LBL_IP_Server.TabIndex = 1;
            this.LBL_IP_Server.Text = "Adresse IP du serveur : ";
            // 
            // LBL_BDD_User
            // 
            this.LBL_BDD_User.AutoSize = true;
            this.LBL_BDD_User.Location = new System.Drawing.Point(13, 147);
            this.LBL_BDD_User.Name = "LBL_BDD_User";
            this.LBL_BDD_User.Size = new System.Drawing.Size(244, 13);
            this.LBL_BDD_User.TabIndex = 2;
            this.LBL_BDD_User.Text = "Utilisateurs utilisé lors de la connexions  à la BDD :";
            // 
            // LBL_BDD_Pass
            // 
            this.LBL_BDD_Pass.AutoSize = true;
            this.LBL_BDD_Pass.Location = new System.Drawing.Point(13, 182);
            this.LBL_BDD_Pass.Name = "LBL_BDD_Pass";
            this.LBL_BDD_Pass.Size = new System.Drawing.Size(217, 13);
            this.LBL_BDD_Pass.TabIndex = 3;
            this.LBL_BDD_Pass.Text = "MDP utilisé lors de la connexions  à la BDD :";
            // 
            // LBL_BDD_Check
            // 
            this.LBL_BDD_Check.AutoSize = true;
            this.LBL_BDD_Check.Location = new System.Drawing.Point(13, 221);
            this.LBL_BDD_Check.Name = "LBL_BDD_Check";
            this.LBL_BDD_Check.Size = new System.Drawing.Size(103, 13);
            this.LBL_BDD_Check.TabIndex = 4;
            this.LBL_BDD_Check.Text = "Serveur accessible :";
            // 
            // LBL_Reply_Time_Ping
            // 
            this.LBL_Reply_Time_Ping.AutoSize = true;
            this.LBL_Reply_Time_Ping.Location = new System.Drawing.Point(13, 264);
            this.LBL_Reply_Time_Ping.Name = "LBL_Reply_Time_Ping";
            this.LBL_Reply_Time_Ping.Size = new System.Drawing.Size(154, 13);
            this.LBL_Reply_Time_Ping.TabIndex = 5;
            this.LBL_Reply_Time_Ping.Text = "Temps de réponse du serveur :";
            // 
            // BT_Return
            // 
            this.BT_Return.Location = new System.Drawing.Point(173, 324);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(75, 23);
            this.BT_Return.TabIndex = 6;
            this.BT_Return.Text = "Retour";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // LBL_BDD
            // 
            this.LBL_BDD.AutoSize = true;
            this.LBL_BDD.Location = new System.Drawing.Point(13, 77);
            this.LBL_BDD.Name = "LBL_BDD";
            this.LBL_BDD.Size = new System.Drawing.Size(68, 13);
            this.LBL_BDD.TabIndex = 7;
            this.LBL_BDD.Text = "BDD utilisé : ";
            // 
            // Info_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 359);
            this.Controls.Add(this.LBL_BDD);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.LBL_Reply_Time_Ping);
            this.Controls.Add(this.LBL_BDD_Check);
            this.Controls.Add(this.LBL_BDD_Pass);
            this.Controls.Add(this.LBL_BDD_User);
            this.Controls.Add(this.LBL_IP_Server);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info_Connection";
            this.Text = "Information sur la connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_IP_Server;
        private System.Windows.Forms.Label LBL_BDD_User;
        private System.Windows.Forms.Label LBL_BDD_Pass;
        private System.Windows.Forms.Label LBL_BDD_Check;
        private System.Windows.Forms.Label LBL_Reply_Time_Ping;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.Label LBL_BDD;
    }
}