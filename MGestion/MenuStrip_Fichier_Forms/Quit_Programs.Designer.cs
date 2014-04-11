namespace MGestion
{
    partial class Quit_Programs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quit_Programs));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Contains = new System.Windows.Forms.Label();
            this.LBL_Quit_Ok = new System.Windows.Forms.Label();
            this.LBL_Return = new System.Windows.Forms.Button();
            this.BT_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(115, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(355, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Voulez vous vraiment nous quitter ?";
            // 
            // LBL_Contains
            // 
            this.LBL_Contains.AutoSize = true;
            this.LBL_Contains.Location = new System.Drawing.Point(110, 72);
            this.LBL_Contains.Name = "LBL_Contains";
            this.LBL_Contains.Size = new System.Drawing.Size(360, 78);
            this.LBL_Contains.TabIndex = 1;
            this.LBL_Contains.Text = resources.GetString("LBL_Contains.Text");
            this.LBL_Contains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Quit_Ok
            // 
            this.LBL_Quit_Ok.AutoSize = true;
            this.LBL_Quit_Ok.Location = new System.Drawing.Point(180, 154);
            this.LBL_Quit_Ok.Name = "LBL_Quit_Ok";
            this.LBL_Quit_Ok.Size = new System.Drawing.Size(0, 13);
            this.LBL_Quit_Ok.TabIndex = 2;
            // 
            // LBL_Return
            // 
            this.LBL_Return.Location = new System.Drawing.Point(395, 200);
            this.LBL_Return.Name = "LBL_Return";
            this.LBL_Return.Size = new System.Drawing.Size(116, 23);
            this.LBL_Return.TabIndex = 3;
            this.LBL_Return.Text = "J\'ai changé d\'avis";
            this.LBL_Return.UseVisualStyleBackColor = true;
            this.LBL_Return.Click += new System.EventHandler(this.LBL_Return_Click);
            // 
            // BT_Quit
            // 
            this.BT_Quit.Location = new System.Drawing.Point(113, 200);
            this.BT_Quit.Name = "BT_Quit";
            this.BT_Quit.Size = new System.Drawing.Size(116, 23);
            this.BT_Quit.TabIndex = 4;
            this.BT_Quit.Text = "Quitter";
            this.BT_Quit.UseVisualStyleBackColor = true;
            this.BT_Quit.Click += new System.EventHandler(this.BT_Quit_Click);
            // 
            // Quit_Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 244);
            this.Controls.Add(this.BT_Quit);
            this.Controls.Add(this.LBL_Return);
            this.Controls.Add(this.LBL_Quit_Ok);
            this.Controls.Add(this.LBL_Contains);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quit_Programs";
            this.Text = "Quitter le programme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Contains;
        private System.Windows.Forms.Label LBL_Quit_Ok;
        private System.Windows.Forms.Button LBL_Return;
        private System.Windows.Forms.Button BT_Quit;
    }
}