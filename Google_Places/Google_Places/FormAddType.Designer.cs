﻿namespace Google_Places
{
    partial class FormAddType
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
            this.lblAddTypeName = new System.Windows.Forms.Label();
            this.lblAddTypeValue = new System.Windows.Forms.Label();
            this.inptAddTypeName = new System.Windows.Forms.TextBox();
            this.inptAddTypeValue = new System.Windows.Forms.TextBox();
            this.btnAddType2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddTypeName
            // 
            this.lblAddTypeName.AutoSize = true;
            this.lblAddTypeName.Location = new System.Drawing.Point(48, 49);
            this.lblAddTypeName.Name = "lblAddTypeName";
            this.lblAddTypeName.Size = new System.Drawing.Size(35, 13);
            this.lblAddTypeName.TabIndex = 1;
            this.lblAddTypeName.Text = "Name";
            // 
            // lblAddTypeValue
            // 
            this.lblAddTypeValue.AutoSize = true;
            this.lblAddTypeValue.Location = new System.Drawing.Point(49, 123);
            this.lblAddTypeValue.Name = "lblAddTypeValue";
            this.lblAddTypeValue.Size = new System.Drawing.Size(34, 13);
            this.lblAddTypeValue.TabIndex = 2;
            this.lblAddTypeValue.Text = "Value";
            // 
            // inptAddTypeName
            // 
            this.inptAddTypeName.Location = new System.Drawing.Point(151, 46);
            this.inptAddTypeName.Name = "inptAddTypeName";
            this.inptAddTypeName.Size = new System.Drawing.Size(166, 20);
            this.inptAddTypeName.TabIndex = 3;
            // 
            // inptAddTypeValue
            // 
            this.inptAddTypeValue.Location = new System.Drawing.Point(151, 120);
            this.inptAddTypeValue.Name = "inptAddTypeValue";
            this.inptAddTypeValue.Size = new System.Drawing.Size(166, 20);
            this.inptAddTypeValue.TabIndex = 4;
            // 
            // btnAddType2
            // 
            this.btnAddType2.Location = new System.Drawing.Point(151, 167);
            this.btnAddType2.Name = "btnAddType2";
            this.btnAddType2.Size = new System.Drawing.Size(166, 68);
            this.btnAddType2.TabIndex = 5;
            this.btnAddType2.Text = "Add";
            this.btnAddType2.UseVisualStyleBackColor = true;
            // 
            // FormAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.btnAddType2);
            this.Controls.Add(this.inptAddTypeValue);
            this.Controls.Add(this.inptAddTypeName);
            this.Controls.Add(this.lblAddTypeValue);
            this.Controls.Add(this.lblAddTypeName);
            this.Name = "FormAddType";
            this.Text = "Dodavanje tipa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddTypeName;
        private System.Windows.Forms.Label lblAddTypeValue;
        private System.Windows.Forms.TextBox inptAddTypeName;
        private System.Windows.Forms.TextBox inptAddTypeValue;
        private System.Windows.Forms.Button btnAddType2;
    }
}