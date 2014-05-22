namespace MGestion
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MS_Menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationDeConnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDeLaConnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentUtiliserCetteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationLégaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nousContacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remerciementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BT_Add_User = new System.Windows.Forms.Button();
            this.BT_See_User = new System.Windows.Forms.Button();
            this.BT_Del_User = new System.Windows.Forms.Button();
            this.BT_Edit_User = new System.Windows.Forms.Button();
            this.BT_Add_Soc = new System.Windows.Forms.Button();
            this.BT_See_Soc = new System.Windows.Forms.Button();
            this.BT_Del_Soc = new System.Windows.Forms.Button();
            this.BT_Edit_Soc = new System.Windows.Forms.Button();
            this.BT_Edit_Annon = new System.Windows.Forms.Button();
            this.BT_Del_Annon = new System.Windows.Forms.Button();
            this.BT_See_Annon = new System.Windows.Forms.Button();
            this.BT_Add_Annon = new System.Windows.Forms.Button();
            this.LBL_Gestion_Utilisateur = new System.Windows.Forms.Label();
            this.LBL_Gestion_Société = new System.Windows.Forms.Label();
            this.LBL_Gestion_Annonce = new System.Windows.Forms.Label();
            this.MS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Menu
            // 
            this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.MS_Menu.Location = new System.Drawing.Point(0, 0);
            this.MS_Menu.Name = "MS_Menu";
            this.MS_Menu.Size = new System.Drawing.Size(494, 24);
            this.MS_Menu.TabIndex = 0;
            this.MS_Menu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationDeConnexionToolStripMenuItem,
            this.modificationDeLaConnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // informationDeConnexionToolStripMenuItem
            // 
            this.informationDeConnexionToolStripMenuItem.Name = "informationDeConnexionToolStripMenuItem";
            this.informationDeConnexionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.informationDeConnexionToolStripMenuItem.Text = "Information de connexion";
            this.informationDeConnexionToolStripMenuItem.Click += new System.EventHandler(this.informationDeConnexionToolStripMenuItem_Click);
            // 
            // modificationDeLaConnexionToolStripMenuItem
            // 
            this.modificationDeLaConnexionToolStripMenuItem.Name = "modificationDeLaConnexionToolStripMenuItem";
            this.modificationDeLaConnexionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modificationDeLaConnexionToolStripMenuItem.Text = "Modification de la connexion";
            this.modificationDeLaConnexionToolStripMenuItem.Click += new System.EventHandler(this.modificationDeLaConnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentUtiliserCetteApplicationToolStripMenuItem,
            this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem,
            this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // commentUtiliserCetteApplicationToolStripMenuItem
            // 
            this.commentUtiliserCetteApplicationToolStripMenuItem.Name = "commentUtiliserCetteApplicationToolStripMenuItem";
            this.commentUtiliserCetteApplicationToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
            this.commentUtiliserCetteApplicationToolStripMenuItem.Text = "Comment utiliser cette application";
            this.commentUtiliserCetteApplicationToolStripMenuItem.Click += new System.EventHandler(this.commentUtiliserCetteApplicationToolStripMenuItem_Click);
            // 
            // informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem
            // 
            this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem.Name = "informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem";
            this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
            this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem.Text = "Information sur la connexion à la base de données ";
            this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // commentConfigurerSaBaseDeDonnéesToolStripMenuItem
            // 
            this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem.Name = "commentConfigurerSaBaseDeDonnéesToolStripMenuItem";
            this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
            this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem.Text = "Comment configurer sa base de données";
            this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.commentConfigurerSaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationLégaleToolStripMenuItem,
            this.nousContacterToolStripMenuItem,
            this.remerciementToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // informationLégaleToolStripMenuItem
            // 
            this.informationLégaleToolStripMenuItem.Name = "informationLégaleToolStripMenuItem";
            this.informationLégaleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.informationLégaleToolStripMenuItem.Text = "Information légale";
            this.informationLégaleToolStripMenuItem.Click += new System.EventHandler(this.informationLégaleToolStripMenuItem_Click);
            // 
            // nousContacterToolStripMenuItem
            // 
            this.nousContacterToolStripMenuItem.Name = "nousContacterToolStripMenuItem";
            this.nousContacterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nousContacterToolStripMenuItem.Text = "Nous contacter";
            this.nousContacterToolStripMenuItem.Click += new System.EventHandler(this.nousContacterToolStripMenuItem_Click);
            // 
            // remerciementToolStripMenuItem
            // 
            this.remerciementToolStripMenuItem.Name = "remerciementToolStripMenuItem";
            this.remerciementToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.remerciementToolStripMenuItem.Text = "Remerciement";
            this.remerciementToolStripMenuItem.Click += new System.EventHandler(this.remerciementToolStripMenuItem_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(178, 43);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(140, 25);
            this.LBL_Title.TabIndex = 1;
            this.LBL_Title.Text = "MegaGasting";
            // 
            // BT_Add_User
            // 
            this.BT_Add_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Add_User.BackgroundImage")));
            this.BT_Add_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Add_User.FlatAppearance.BorderSize = 0;
            this.BT_Add_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BT_Add_User.Location = new System.Drawing.Point(242, 114);
            this.BT_Add_User.Name = "BT_Add_User";
            this.BT_Add_User.Size = new System.Drawing.Size(42, 41);
            this.BT_Add_User.TabIndex = 2;
            this.BT_Add_User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Add_User.UseVisualStyleBackColor = true;
            this.BT_Add_User.Click += new System.EventHandler(this.BT_Add_User_Click);
            // 
            // BT_See_User
            // 
            this.BT_See_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_See_User.BackgroundImage")));
            this.BT_See_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_See_User.FlatAppearance.BorderSize = 0;
            this.BT_See_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_See_User.Location = new System.Drawing.Point(305, 114);
            this.BT_See_User.Name = "BT_See_User";
            this.BT_See_User.Size = new System.Drawing.Size(42, 41);
            this.BT_See_User.TabIndex = 3;
            this.BT_See_User.UseVisualStyleBackColor = true;
            this.BT_See_User.Click += new System.EventHandler(this.BT_See_User_Click);
            // 
            // BT_Del_User
            // 
            this.BT_Del_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Del_User.BackgroundImage")));
            this.BT_Del_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Del_User.FlatAppearance.BorderSize = 0;
            this.BT_Del_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Del_User.Location = new System.Drawing.Point(371, 114);
            this.BT_Del_User.Name = "BT_Del_User";
            this.BT_Del_User.Size = new System.Drawing.Size(42, 41);
            this.BT_Del_User.TabIndex = 4;
            this.BT_Del_User.UseVisualStyleBackColor = true;
            this.BT_Del_User.Click += new System.EventHandler(this.BT_Del_User_Click);
            // 
            // BT_Edit_User
            // 
            this.BT_Edit_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Edit_User.BackgroundImage")));
            this.BT_Edit_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Edit_User.FlatAppearance.BorderSize = 0;
            this.BT_Edit_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Edit_User.Location = new System.Drawing.Point(428, 114);
            this.BT_Edit_User.Name = "BT_Edit_User";
            this.BT_Edit_User.Size = new System.Drawing.Size(42, 41);
            this.BT_Edit_User.TabIndex = 5;
            this.BT_Edit_User.UseVisualStyleBackColor = true;
            this.BT_Edit_User.Click += new System.EventHandler(this.BT_Edit_User_Click);
            // 
            // BT_Add_Soc
            // 
            this.BT_Add_Soc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Add_Soc.BackgroundImage")));
            this.BT_Add_Soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Add_Soc.FlatAppearance.BorderSize = 0;
            this.BT_Add_Soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add_Soc.Location = new System.Drawing.Point(242, 204);
            this.BT_Add_Soc.Name = "BT_Add_Soc";
            this.BT_Add_Soc.Size = new System.Drawing.Size(42, 41);
            this.BT_Add_Soc.TabIndex = 6;
            this.BT_Add_Soc.UseVisualStyleBackColor = true;
            this.BT_Add_Soc.Click += new System.EventHandler(this.BT_Del_User_Click);
            // 
            // BT_See_Soc
            // 
            this.BT_See_Soc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_See_Soc.BackgroundImage")));
            this.BT_See_Soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_See_Soc.FlatAppearance.BorderSize = 0;
            this.BT_See_Soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_See_Soc.Location = new System.Drawing.Point(305, 204);
            this.BT_See_Soc.Name = "BT_See_Soc";
            this.BT_See_Soc.Size = new System.Drawing.Size(42, 41);
            this.BT_See_Soc.TabIndex = 7;
            this.BT_See_Soc.UseVisualStyleBackColor = true;
            this.BT_See_Soc.Click += new System.EventHandler(this.BT_See_Soc_Click);
            // 
            // BT_Del_Soc
            // 
            this.BT_Del_Soc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Del_Soc.BackgroundImage")));
            this.BT_Del_Soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Del_Soc.FlatAppearance.BorderSize = 0;
            this.BT_Del_Soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Del_Soc.Location = new System.Drawing.Point(371, 204);
            this.BT_Del_Soc.Name = "BT_Del_Soc";
            this.BT_Del_Soc.Size = new System.Drawing.Size(42, 41);
            this.BT_Del_Soc.TabIndex = 8;
            this.BT_Del_Soc.UseVisualStyleBackColor = true;
            this.BT_Del_Soc.Click += new System.EventHandler(this.BT_Del_Soc_Click);
            // 
            // BT_Edit_Soc
            // 
            this.BT_Edit_Soc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Edit_Soc.BackgroundImage")));
            this.BT_Edit_Soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Edit_Soc.FlatAppearance.BorderSize = 0;
            this.BT_Edit_Soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Edit_Soc.Location = new System.Drawing.Point(428, 204);
            this.BT_Edit_Soc.Name = "BT_Edit_Soc";
            this.BT_Edit_Soc.Size = new System.Drawing.Size(42, 41);
            this.BT_Edit_Soc.TabIndex = 14;
            this.BT_Edit_Soc.UseVisualStyleBackColor = true;
            this.BT_Edit_Soc.Click += new System.EventHandler(this.BT_Edit_Soc_Click);
            // 
            // BT_Edit_Annon
            // 
            this.BT_Edit_Annon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Edit_Annon.BackgroundImage")));
            this.BT_Edit_Annon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Edit_Annon.FlatAppearance.BorderSize = 0;
            this.BT_Edit_Annon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Edit_Annon.Location = new System.Drawing.Point(428, 292);
            this.BT_Edit_Annon.Name = "BT_Edit_Annon";
            this.BT_Edit_Annon.Size = new System.Drawing.Size(42, 41);
            this.BT_Edit_Annon.TabIndex = 18;
            this.BT_Edit_Annon.UseVisualStyleBackColor = true;
            this.BT_Edit_Annon.Click += new System.EventHandler(this.BT_Edit_Annon_Click);
            // 
            // BT_Del_Annon
            // 
            this.BT_Del_Annon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Del_Annon.BackgroundImage")));
            this.BT_Del_Annon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Del_Annon.FlatAppearance.BorderSize = 0;
            this.BT_Del_Annon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Del_Annon.Location = new System.Drawing.Point(371, 292);
            this.BT_Del_Annon.Name = "BT_Del_Annon";
            this.BT_Del_Annon.Size = new System.Drawing.Size(42, 41);
            this.BT_Del_Annon.TabIndex = 17;
            this.BT_Del_Annon.UseVisualStyleBackColor = true;
            this.BT_Del_Annon.Click += new System.EventHandler(this.BT_Del_Annon_Click);
            // 
            // BT_See_Annon
            // 
            this.BT_See_Annon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_See_Annon.BackgroundImage")));
            this.BT_See_Annon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_See_Annon.FlatAppearance.BorderSize = 0;
            this.BT_See_Annon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_See_Annon.Location = new System.Drawing.Point(305, 292);
            this.BT_See_Annon.Name = "BT_See_Annon";
            this.BT_See_Annon.Size = new System.Drawing.Size(42, 41);
            this.BT_See_Annon.TabIndex = 16;
            this.BT_See_Annon.UseVisualStyleBackColor = true;
            this.BT_See_Annon.Click += new System.EventHandler(this.BT_See_Annon_Click);
            // 
            // BT_Add_Annon
            // 
            this.BT_Add_Annon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Add_Annon.BackgroundImage")));
            this.BT_Add_Annon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Add_Annon.FlatAppearance.BorderSize = 0;
            this.BT_Add_Annon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add_Annon.Location = new System.Drawing.Point(242, 292);
            this.BT_Add_Annon.Name = "BT_Add_Annon";
            this.BT_Add_Annon.Size = new System.Drawing.Size(42, 41);
            this.BT_Add_Annon.TabIndex = 15;
            this.BT_Add_Annon.UseVisualStyleBackColor = true;
            this.BT_Add_Annon.Click += new System.EventHandler(this.BT_Add_Annon_Click);
            // 
            // LBL_Gestion_Utilisateur
            // 
            this.LBL_Gestion_Utilisateur.AutoSize = true;
            this.LBL_Gestion_Utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Gestion_Utilisateur.Location = new System.Drawing.Point(12, 123);
            this.LBL_Gestion_Utilisateur.Name = "LBL_Gestion_Utilisateur";
            this.LBL_Gestion_Utilisateur.Size = new System.Drawing.Size(183, 20);
            this.LBL_Gestion_Utilisateur.TabIndex = 19;
            this.LBL_Gestion_Utilisateur.Text = "Gestion des utilisateurs :";
            // 
            // LBL_Gestion_Société
            // 
            this.LBL_Gestion_Société.AutoSize = true;
            this.LBL_Gestion_Société.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Gestion_Société.Location = new System.Drawing.Point(12, 213);
            this.LBL_Gestion_Société.Name = "LBL_Gestion_Société";
            this.LBL_Gestion_Société.Size = new System.Drawing.Size(175, 20);
            this.LBL_Gestion_Société.TabIndex = 20;
            this.LBL_Gestion_Société.Text = "Gestion des sociétées :";
            // 
            // LBL_Gestion_Annonce
            // 
            this.LBL_Gestion_Annonce.AutoSize = true;
            this.LBL_Gestion_Annonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Gestion_Annonce.Location = new System.Drawing.Point(12, 301);
            this.LBL_Gestion_Annonce.Name = "LBL_Gestion_Annonce";
            this.LBL_Gestion_Annonce.Size = new System.Drawing.Size(177, 20);
            this.LBL_Gestion_Annonce.TabIndex = 21;
            this.LBL_Gestion_Annonce.Text = "Gestion des annonces :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.LBL_Gestion_Annonce);
            this.Controls.Add(this.LBL_Gestion_Société);
            this.Controls.Add(this.LBL_Gestion_Utilisateur);
            this.Controls.Add(this.BT_Edit_Annon);
            this.Controls.Add(this.BT_Del_Annon);
            this.Controls.Add(this.BT_See_Annon);
            this.Controls.Add(this.BT_Add_Annon);
            this.Controls.Add(this.BT_Edit_Soc);
            this.Controls.Add(this.BT_Del_Soc);
            this.Controls.Add(this.BT_See_Soc);
            this.Controls.Add(this.BT_Add_Soc);
            this.Controls.Add(this.BT_Edit_User);
            this.Controls.Add(this.BT_Del_User);
            this.Controls.Add(this.BT_See_User);
            this.Controls.Add(this.BT_Add_User);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.MS_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Menu;
            this.Name = "Main";
            this.Text = "MGestion";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MS_Menu.ResumeLayout(false);
            this.MS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationDeConnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDeLaConnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentUtiliserCetteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationSurLaConnexionÀLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentConfigurerSaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationLégaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nousContacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remerciementToolStripMenuItem;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BT_Add_User;
        private System.Windows.Forms.Button BT_See_User;
        private System.Windows.Forms.Button BT_Del_User;
        private System.Windows.Forms.Button BT_Edit_User;
        private System.Windows.Forms.Button BT_Add_Soc;
        private System.Windows.Forms.Button BT_See_Soc;
        private System.Windows.Forms.Button BT_Del_Soc;
        private System.Windows.Forms.Button BT_Edit_Soc;
        private System.Windows.Forms.Button BT_Edit_Annon;
        private System.Windows.Forms.Button BT_Del_Annon;
        private System.Windows.Forms.Button BT_See_Annon;
        private System.Windows.Forms.Button BT_Add_Annon;
        private System.Windows.Forms.Label LBL_Gestion_Utilisateur;
        private System.Windows.Forms.Label LBL_Gestion_Société;
        private System.Windows.Forms.Label LBL_Gestion_Annonce;
    }
}