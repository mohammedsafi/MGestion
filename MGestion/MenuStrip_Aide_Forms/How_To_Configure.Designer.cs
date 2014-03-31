namespace MGestion
{
    partial class How_To_Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(How_To_Configure));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Contains = new System.Windows.Forms.Label();
            this.BT_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(12, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(333, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Comment configurer la connexion\r\n";
            // 
            // LBL_Contains
            // 
            this.LBL_Contains.AutoSize = true;
            this.LBL_Contains.Location = new System.Drawing.Point(14, 54);
            this.LBL_Contains.Name = "LBL_Contains";
            this.LBL_Contains.Size = new System.Drawing.Size(355, 117);
            this.LBL_Contains.TabIndex = 1;
            this.LBL_Contains.Text = resources.GetString("LBL_Contains.Text");
            this.LBL_Contains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_Return
            // 
            this.BT_Return.Location = new System.Drawing.Point(143, 195);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(75, 23);
            this.BT_Return.TabIndex = 2;
            this.BT_Return.Text = "Retour";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // How_To_Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 238);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.LBL_Contains);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "How_To_Configure";
            this.Text = "Comment configurer la connexion à la base de données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Contains;
        private System.Windows.Forms.Button BT_Return;
    }
}