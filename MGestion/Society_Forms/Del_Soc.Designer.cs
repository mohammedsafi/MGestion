namespace MGestion
{
    partial class Del_Soc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_Soc));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Name_Todelete = new System.Windows.Forms.Label();
            this.TB_Name_Todelete = new System.Windows.Forms.TextBox();
            this.BT_Return = new System.Windows.Forms.Button();
            this.BT_Del_Soc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(73, 33);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(227, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Supprimer une société";
            // 
            // LBL_Name_Todelete
            // 
            this.LBL_Name_Todelete.AutoSize = true;
            this.LBL_Name_Todelete.Location = new System.Drawing.Point(12, 86);
            this.LBL_Name_Todelete.Name = "LBL_Name_Todelete";
            this.LBL_Name_Todelete.Size = new System.Drawing.Size(103, 13);
            this.LBL_Name_Todelete.TabIndex = 1;
            this.LBL_Name_Todelete.Text = "Nom de l\'entreprise :";
            // 
            // TB_Name_Todelete
            // 
            this.TB_Name_Todelete.Location = new System.Drawing.Point(121, 83);
            this.TB_Name_Todelete.Name = "TB_Name_Todelete";
            this.TB_Name_Todelete.Size = new System.Drawing.Size(179, 20);
            this.TB_Name_Todelete.TabIndex = 2;
            // 
            // BT_Return
            // 
            this.BT_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Return.BackgroundImage")));
            this.BT_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Return.FlatAppearance.BorderSize = 0;
            this.BT_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Return.Location = new System.Drawing.Point(12, 121);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(42, 41);
            this.BT_Return.TabIndex = 35;
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // BT_Del_Soc
            // 
            this.BT_Del_Soc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Del_Soc.BackgroundImage")));
            this.BT_Del_Soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Del_Soc.FlatAppearance.BorderSize = 0;
            this.BT_Del_Soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Del_Soc.Location = new System.Drawing.Point(308, 121);
            this.BT_Del_Soc.Name = "BT_Del_Soc";
            this.BT_Del_Soc.Size = new System.Drawing.Size(42, 41);
            this.BT_Del_Soc.TabIndex = 36;
            this.BT_Del_Soc.UseVisualStyleBackColor = true;
            this.BT_Del_Soc.Click += new System.EventHandler(this.BT_Del_Soc_Click);
            // 
            // Del_Soc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 174);
            this.Controls.Add(this.BT_Del_Soc);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.TB_Name_Todelete);
            this.Controls.Add(this.LBL_Name_Todelete);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Del_Soc";
            this.Text = "Supprimer une société";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Name_Todelete;
        private System.Windows.Forms.TextBox TB_Name_Todelete;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.Button BT_Del_Soc;
    }
}