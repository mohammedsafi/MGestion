namespace MGestion
{
    partial class Del_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_User));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mail_Tofind = new System.Windows.Forms.Label();
            this.IB_Mail_Tofind = new System.Windows.Forms.TextBox();
            this.BT_Del_User = new System.Windows.Forms.Button();
            this.BT_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(97, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(239, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Supprimer un utilisateur";
            // 
            // LBL_Mail_Tofind
            // 
            this.LBL_Mail_Tofind.AutoSize = true;
            this.LBL_Mail_Tofind.Location = new System.Drawing.Point(35, 59);
            this.LBL_Mail_Tofind.Name = "LBL_Mail_Tofind";
            this.LBL_Mail_Tofind.Size = new System.Drawing.Size(138, 13);
            this.LBL_Mail_Tofind.TabIndex = 1;
            this.LBL_Mail_Tofind.Text = "Adresse mail de l\'utilisateur :";
            // 
            // IB_Mail_Tofind
            // 
            this.IB_Mail_Tofind.Location = new System.Drawing.Point(179, 56);
            this.IB_Mail_Tofind.Name = "IB_Mail_Tofind";
            this.IB_Mail_Tofind.Size = new System.Drawing.Size(168, 20);
            this.IB_Mail_Tofind.TabIndex = 2;
            // 
            // BT_Del_User
            // 
            this.BT_Del_User.Location = new System.Drawing.Point(66, 82);
            this.BT_Del_User.Name = "BT_Del_User";
            this.BT_Del_User.Size = new System.Drawing.Size(132, 23);
            this.BT_Del_User.TabIndex = 3;
            this.BT_Del_User.Text = "Je supprime l\'utilisateur";
            this.BT_Del_User.UseVisualStyleBackColor = true;
            this.BT_Del_User.Click += new System.EventHandler(this.BT_Del_User_Click);
            // 
            // BT_Return
            // 
            this.BT_Return.Location = new System.Drawing.Point(204, 82);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(132, 23);
            this.BT_Return.TabIndex = 4;
            this.BT_Return.Text = "Retour";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // Del_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 140);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.BT_Del_User);
            this.Controls.Add(this.IB_Mail_Tofind);
            this.Controls.Add(this.LBL_Mail_Tofind);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Del_User";
            this.Text = "Suppression d\'un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mail_Tofind;
        private System.Windows.Forms.TextBox IB_Mail_Tofind;
        private System.Windows.Forms.Button BT_Del_User;
        private System.Windows.Forms.Button BT_Return;
    }
}