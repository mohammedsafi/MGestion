﻿namespace MGestion
{
    partial class How_To_Use
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(How_To_Use));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Contains = new System.Windows.Forms.Label();
            this.BT_Open_Doc = new System.Windows.Forms.Button();
            this.BT_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(76, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(258, 25);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Ouvrir la documentation ?";
            // 
            // LBL_Contains
            // 
            this.LBL_Contains.AutoSize = true;
            this.LBL_Contains.Location = new System.Drawing.Point(33, 55);
            this.LBL_Contains.Name = "LBL_Contains";
            this.LBL_Contains.Size = new System.Drawing.Size(351, 65);
            this.LBL_Contains.TabIndex = 1;
            this.LBL_Contains.Text = resources.GetString("LBL_Contains.Text");
            this.LBL_Contains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_Open_Doc
            // 
            this.BT_Open_Doc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Open_Doc.BackgroundImage")));
            this.BT_Open_Doc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Open_Doc.FlatAppearance.BorderSize = 0;
            this.BT_Open_Doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Open_Doc.Location = new System.Drawing.Point(378, 161);
            this.BT_Open_Doc.Name = "BT_Open_Doc";
            this.BT_Open_Doc.Size = new System.Drawing.Size(42, 41);
            this.BT_Open_Doc.TabIndex = 2;
            this.BT_Open_Doc.UseVisualStyleBackColor = true;
            this.BT_Open_Doc.Click += new System.EventHandler(this.BT_Open_Doc_Click);
            // 
            // BT_Return
            // 
            this.BT_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Return.BackgroundImage")));
            this.BT_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Return.FlatAppearance.BorderSize = 0;
            this.BT_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Return.Location = new System.Drawing.Point(12, 161);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(42, 41);
            this.BT_Return.TabIndex = 36;
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // How_To_Use
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 214);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.BT_Open_Doc);
            this.Controls.Add(this.LBL_Contains);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "How_To_Use";
            this.Text = "Comment utiliser cette application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Contains;
        private System.Windows.Forms.Button BT_Open_Doc;
        private System.Windows.Forms.Button BT_Return;
    }
}