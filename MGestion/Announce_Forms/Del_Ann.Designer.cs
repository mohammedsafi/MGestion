namespace MGestion
{
    partial class Del_Ann
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_Ann));
            this.BT_Ref_Todelete = new System.Windows.Forms.Button();
            this.TB_Ref_Todelete = new System.Windows.Forms.TextBox();
            this.LBL_Ref_Todelete = new System.Windows.Forms.Label();
            this.LBL_Title_Deux = new System.Windows.Forms.Label();
            this.BT_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Ref_Todelete
            // 
            this.BT_Ref_Todelete.Location = new System.Drawing.Point(28, 121);
            this.BT_Ref_Todelete.Name = "BT_Ref_Todelete";
            this.BT_Ref_Todelete.Size = new System.Drawing.Size(130, 23);
            this.BT_Ref_Todelete.TabIndex = 8;
            this.BT_Ref_Todelete.Text = "Supprimer l\'annonce";
            this.BT_Ref_Todelete.UseVisualStyleBackColor = true;
            this.BT_Ref_Todelete.Click += new System.EventHandler(this.BT_Ref_Todelete_Click);
            // 
            // TB_Ref_Todelete
            // 
            this.TB_Ref_Todelete.Location = new System.Drawing.Point(158, 76);
            this.TB_Ref_Todelete.Name = "TB_Ref_Todelete";
            this.TB_Ref_Todelete.Size = new System.Drawing.Size(160, 20);
            this.TB_Ref_Todelete.TabIndex = 7;
            // 
            // LBL_Ref_Todelete
            // 
            this.LBL_Ref_Todelete.AutoSize = true;
            this.LBL_Ref_Todelete.Location = new System.Drawing.Point(25, 76);
            this.LBL_Ref_Todelete.Name = "LBL_Ref_Todelete";
            this.LBL_Ref_Todelete.Size = new System.Drawing.Size(127, 13);
            this.LBL_Ref_Todelete.TabIndex = 6;
            this.LBL_Ref_Todelete.Text = "Référence de l\'annonce :";
            // 
            // LBL_Title_Deux
            // 
            this.LBL_Title_Deux.AutoSize = true;
            this.LBL_Title_Deux.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title_Deux.Location = new System.Drawing.Point(39, 23);
            this.LBL_Title_Deux.Name = "LBL_Title_Deux";
            this.LBL_Title_Deux.Size = new System.Drawing.Size(288, 29);
            this.LBL_Title_Deux.TabIndex = 5;
            this.LBL_Title_Deux.Text = "Supprimer une annonce : ";
            // 
            // BT_Return
            // 
            this.BT_Return.Location = new System.Drawing.Point(229, 121);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(130, 23);
            this.BT_Return.TabIndex = 9;
            this.BT_Return.Text = "Retour";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // Del_Ann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 156);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.BT_Ref_Todelete);
            this.Controls.Add(this.TB_Ref_Todelete);
            this.Controls.Add(this.LBL_Ref_Todelete);
            this.Controls.Add(this.LBL_Title_Deux);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Del_Ann";
            this.Text = "Supprimer une annonce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Ref_Todelete;
        private System.Windows.Forms.TextBox TB_Ref_Todelete;
        private System.Windows.Forms.Label LBL_Ref_Todelete;
        private System.Windows.Forms.Label LBL_Title_Deux;
        private System.Windows.Forms.Button BT_Return;
    }
}