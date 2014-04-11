namespace MGestion
{
    partial class Edit_Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Connection));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Edit_Ip_Server = new System.Windows.Forms.Label();
            this.LBL_Edit_BDD_User = new System.Windows.Forms.Label();
            this.LBL_Edit_BDD_Pass = new System.Windows.Forms.Label();
            this.BT_Valid_Edit = new System.Windows.Forms.Button();
            this.BT_Return = new System.Windows.Forms.Button();
            this.IB_Edit_Ip_Server = new System.Windows.Forms.TextBox();
            this.IB_Edit_BDD_User = new System.Windows.Forms.TextBox();
            this.IB_Edit_BDD_Pass = new System.Windows.Forms.TextBox();
            this.LBL_Edit_BDD_Used = new System.Windows.Forms.Label();
            this.IB_Edit_BDD_Used = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(57, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(336, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Modifications liées à la connexion";
            // 
            // LBL_Edit_Ip_Server
            // 
            this.LBL_Edit_Ip_Server.AutoSize = true;
            this.LBL_Edit_Ip_Server.Location = new System.Drawing.Point(14, 117);
            this.LBL_Edit_Ip_Server.Name = "LBL_Edit_Ip_Server";
            this.LBL_Edit_Ip_Server.Size = new System.Drawing.Size(117, 13);
            this.LBL_Edit_Ip_Server.TabIndex = 1;
            this.LBL_Edit_Ip_Server.Text = "Adresse IP du serveur :";
            // 
            // LBL_Edit_BDD_User
            // 
            this.LBL_Edit_BDD_User.AutoSize = true;
            this.LBL_Edit_BDD_User.Location = new System.Drawing.Point(14, 162);
            this.LBL_Edit_BDD_User.Name = "LBL_Edit_BDD_User";
            this.LBL_Edit_BDD_User.Size = new System.Drawing.Size(244, 13);
            this.LBL_Edit_BDD_User.TabIndex = 2;
            this.LBL_Edit_BDD_User.Text = "Utilisateurs utilisé lors de la connexions  à la BDD :";
            // 
            // LBL_Edit_BDD_Pass
            // 
            this.LBL_Edit_BDD_Pass.AutoSize = true;
            this.LBL_Edit_BDD_Pass.Location = new System.Drawing.Point(14, 205);
            this.LBL_Edit_BDD_Pass.Name = "LBL_Edit_BDD_Pass";
            this.LBL_Edit_BDD_Pass.Size = new System.Drawing.Size(217, 13);
            this.LBL_Edit_BDD_Pass.TabIndex = 3;
            this.LBL_Edit_BDD_Pass.Text = "MDP utilisé lors de la connexions  à la BDD :";
            // 
            // BT_Valid_Edit
            // 
            this.BT_Valid_Edit.Location = new System.Drawing.Point(123, 278);
            this.BT_Valid_Edit.Name = "BT_Valid_Edit";
            this.BT_Valid_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Valid_Edit.TabIndex = 4;
            this.BT_Valid_Edit.Text = "Je valide";
            this.BT_Valid_Edit.UseVisualStyleBackColor = true;
            this.BT_Valid_Edit.Click += new System.EventHandler(this.BT_Valid_Edit_Click);
            // 
            // BT_Return
            // 
            this.BT_Return.Location = new System.Drawing.Point(309, 278);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(75, 23);
            this.BT_Return.TabIndex = 5;
            this.BT_Return.Text = "Retour";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // IB_Edit_Ip_Server
            // 
            this.IB_Edit_Ip_Server.Location = new System.Drawing.Point(167, 114);
            this.IB_Edit_Ip_Server.Name = "IB_Edit_Ip_Server";
            this.IB_Edit_Ip_Server.Size = new System.Drawing.Size(227, 20);
            this.IB_Edit_Ip_Server.TabIndex = 6;
            // 
            // IB_Edit_BDD_User
            // 
            this.IB_Edit_BDD_User.Location = new System.Drawing.Point(264, 159);
            this.IB_Edit_BDD_User.Name = "IB_Edit_BDD_User";
            this.IB_Edit_BDD_User.Size = new System.Drawing.Size(227, 20);
            this.IB_Edit_BDD_User.TabIndex = 7;
            // 
            // IB_Edit_BDD_Pass
            // 
            this.IB_Edit_BDD_Pass.Location = new System.Drawing.Point(246, 202);
            this.IB_Edit_BDD_Pass.Name = "IB_Edit_BDD_Pass";
            this.IB_Edit_BDD_Pass.Size = new System.Drawing.Size(227, 20);
            this.IB_Edit_BDD_Pass.TabIndex = 8;
            // 
            // LBL_Edit_BDD_Used
            // 
            this.LBL_Edit_BDD_Used.AutoSize = true;
            this.LBL_Edit_BDD_Used.Location = new System.Drawing.Point(14, 77);
            this.LBL_Edit_BDD_Used.Name = "LBL_Edit_BDD_Used";
            this.LBL_Edit_BDD_Used.Size = new System.Drawing.Size(173, 13);
            this.LBL_Edit_BDD_Used.TabIndex = 9;
            this.LBL_Edit_BDD_Used.Text = "Nom de la base de donnée utilisé : ";
            // 
            // IB_Edit_BDD_Used
            // 
            this.IB_Edit_BDD_Used.Location = new System.Drawing.Point(214, 74);
            this.IB_Edit_BDD_Used.Name = "IB_Edit_BDD_Used";
            this.IB_Edit_BDD_Used.Size = new System.Drawing.Size(227, 20);
            this.IB_Edit_BDD_Used.TabIndex = 10;
            // 
            // Edit_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 351);
            this.Controls.Add(this.IB_Edit_BDD_Used);
            this.Controls.Add(this.LBL_Edit_BDD_Used);
            this.Controls.Add(this.IB_Edit_BDD_Pass);
            this.Controls.Add(this.IB_Edit_BDD_User);
            this.Controls.Add(this.IB_Edit_Ip_Server);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.BT_Valid_Edit);
            this.Controls.Add(this.LBL_Edit_BDD_Pass);
            this.Controls.Add(this.LBL_Edit_BDD_User);
            this.Controls.Add(this.LBL_Edit_Ip_Server);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Connection";
            this.Text = "Modifications liées à la connexion";
            this.Load += new System.EventHandler(this.Edit_Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Edit_Ip_Server;
        private System.Windows.Forms.Label LBL_Edit_BDD_User;
        private System.Windows.Forms.Label LBL_Edit_BDD_Pass;
        private System.Windows.Forms.Button BT_Valid_Edit;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.TextBox IB_Edit_Ip_Server;
        private System.Windows.Forms.TextBox IB_Edit_BDD_User;
        private System.Windows.Forms.TextBox IB_Edit_BDD_Pass;
        private System.Windows.Forms.Label LBL_Edit_BDD_Used;
        private System.Windows.Forms.TextBox IB_Edit_BDD_Used;
    }
}