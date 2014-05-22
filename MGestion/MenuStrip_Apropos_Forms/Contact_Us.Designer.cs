namespace MGestion
{
    partial class Contact_Us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Us));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Object = new System.Windows.Forms.Label();
            this.IB_Object = new System.Windows.Forms.TextBox();
            this.LBL_Contains = new System.Windows.Forms.Label();
            this.IB_Contains = new System.Windows.Forms.TextBox();
            this.BT_Send = new System.Windows.Forms.Button();
            this.LBL_SendFrom = new System.Windows.Forms.Label();
            this.IB_SendFrom = new System.Windows.Forms.TextBox();
            this.LBL_FAI = new System.Windows.Forms.Label();
            this.CB_FAI = new System.Windows.Forms.ComboBox();
            this.BT_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(140, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(163, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Nous contacter ";
            // 
            // LBL_Object
            // 
            this.LBL_Object.AutoSize = true;
            this.LBL_Object.Location = new System.Drawing.Point(13, 130);
            this.LBL_Object.Name = "LBL_Object";
            this.LBL_Object.Size = new System.Drawing.Size(98, 13);
            this.LBL_Object.TabIndex = 1;
            this.LBL_Object.Text = "Objet du message :";
            // 
            // IB_Object
            // 
            this.IB_Object.Location = new System.Drawing.Point(16, 162);
            this.IB_Object.Name = "IB_Object";
            this.IB_Object.Size = new System.Drawing.Size(287, 20);
            this.IB_Object.TabIndex = 2;
            // 
            // LBL_Contains
            // 
            this.LBL_Contains.AutoSize = true;
            this.LBL_Contains.Location = new System.Drawing.Point(13, 194);
            this.LBL_Contains.Name = "LBL_Contains";
            this.LBL_Contains.Size = new System.Drawing.Size(119, 13);
            this.LBL_Contains.TabIndex = 3;
            this.LBL_Contains.Text = "Contenue du message :";
            // 
            // IB_Contains
            // 
            this.IB_Contains.Location = new System.Drawing.Point(12, 225);
            this.IB_Contains.Multiline = true;
            this.IB_Contains.Name = "IB_Contains";
            this.IB_Contains.Size = new System.Drawing.Size(456, 97);
            this.IB_Contains.TabIndex = 4;
            // 
            // BT_Send
            // 
            this.BT_Send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Send.BackgroundImage")));
            this.BT_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Send.FlatAppearance.BorderSize = 0;
            this.BT_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Send.Location = new System.Drawing.Point(430, 400);
            this.BT_Send.Name = "BT_Send";
            this.BT_Send.Size = new System.Drawing.Size(42, 41);
            this.BT_Send.TabIndex = 8;
            this.BT_Send.UseVisualStyleBackColor = true;
            this.BT_Send.Click += new System.EventHandler(this.BT_Send_Click);
            // 
            // LBL_SendFrom
            // 
            this.LBL_SendFrom.AutoSize = true;
            this.LBL_SendFrom.Location = new System.Drawing.Point(9, 62);
            this.LBL_SendFrom.Name = "LBL_SendFrom";
            this.LBL_SendFrom.Size = new System.Drawing.Size(94, 13);
            this.LBL_SendFrom.TabIndex = 10;
            this.LBL_SendFrom.Text = "Email envoyé par :";
            // 
            // IB_SendFrom
            // 
            this.IB_SendFrom.Location = new System.Drawing.Point(12, 94);
            this.IB_SendFrom.Name = "IB_SendFrom";
            this.IB_SendFrom.Size = new System.Drawing.Size(287, 20);
            this.IB_SendFrom.TabIndex = 11;
            // 
            // LBL_FAI
            // 
            this.LBL_FAI.AutoSize = true;
            this.LBL_FAI.Location = new System.Drawing.Point(13, 347);
            this.LBL_FAI.Name = "LBL_FAI";
            this.LBL_FAI.Size = new System.Drawing.Size(170, 13);
            this.LBL_FAI.TabIndex = 12;
            this.LBL_FAI.Text = "Votre fournisseur d\'accès internet :";
            // 
            // CB_FAI
            // 
            this.CB_FAI.FormattingEnabled = true;
            this.CB_FAI.Items.AddRange(new object[] {
            "orange",
            "free",
            "sfr",
            "bouygues",
            "numericable",
            "wanadoo"});
            this.CB_FAI.Location = new System.Drawing.Point(189, 344);
            this.CB_FAI.Name = "CB_FAI";
            this.CB_FAI.Size = new System.Drawing.Size(151, 21);
            this.CB_FAI.TabIndex = 13;
            // 
            // BT_Return
            // 
            this.BT_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Return.BackgroundImage")));
            this.BT_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Return.FlatAppearance.BorderSize = 0;
            this.BT_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Return.Location = new System.Drawing.Point(12, 400);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(42, 41);
            this.BT_Return.TabIndex = 37;
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // Contact_Us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 453);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.CB_FAI);
            this.Controls.Add(this.LBL_FAI);
            this.Controls.Add(this.IB_SendFrom);
            this.Controls.Add(this.LBL_SendFrom);
            this.Controls.Add(this.BT_Send);
            this.Controls.Add(this.IB_Contains);
            this.Controls.Add(this.LBL_Contains);
            this.Controls.Add(this.IB_Object);
            this.Controls.Add(this.LBL_Object);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contact_Us";
            this.Text = "Nous contacter";
            this.Load += new System.EventHandler(this.Contact_Us_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Object;
        private System.Windows.Forms.TextBox IB_Object;
        private System.Windows.Forms.Label LBL_Contains;
        private System.Windows.Forms.TextBox IB_Contains;
        private System.Windows.Forms.Button BT_Send;
        private System.Windows.Forms.Label LBL_SendFrom;
        private System.Windows.Forms.TextBox IB_SendFrom;
        private System.Windows.Forms.Label LBL_FAI;
        private System.Windows.Forms.ComboBox CB_FAI;
        private System.Windows.Forms.Button BT_Return;
    }
}