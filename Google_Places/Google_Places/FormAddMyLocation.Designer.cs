namespace Google_Places
{
    partial class FormAddMyLocation
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
            this.lblSaveMyLocation = new System.Windows.Forms.Label();
            this.lblSaveMyLName = new System.Windows.Forms.Label();
            this.lblSaveMyLAddress = new System.Windows.Forms.Label();
            this.btnAddLocation2 = new System.Windows.Forms.Button();
            this.lblSaveMyLocationName = new System.Windows.Forms.Label();
            this.lblSaveMyLocationAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaveMyLocation
            // 
            this.lblSaveMyLocation.AutoSize = true;
            this.lblSaveMyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSaveMyLocation.Location = new System.Drawing.Point(134, 19);
            this.lblSaveMyLocation.Name = "lblSaveMyLocation";
            this.lblSaveMyLocation.Size = new System.Drawing.Size(155, 25);
            this.lblSaveMyLocation.TabIndex = 2;
            this.lblSaveMyLocation.Text = "Save location?";
            // 
            // lblSaveMyLName
            // 
            this.lblSaveMyLName.AutoSize = true;
            this.lblSaveMyLName.Location = new System.Drawing.Point(99, 98);
            this.lblSaveMyLName.Name = "lblSaveMyLName";
            this.lblSaveMyLName.Size = new System.Drawing.Size(35, 13);
            this.lblSaveMyLName.TabIndex = 3;
            this.lblSaveMyLName.Text = "Name";
            // 
            // lblSaveMyLAddress
            // 
            this.lblSaveMyLAddress.AutoSize = true;
            this.lblSaveMyLAddress.Location = new System.Drawing.Point(89, 164);
            this.lblSaveMyLAddress.Name = "lblSaveMyLAddress";
            this.lblSaveMyLAddress.Size = new System.Drawing.Size(45, 13);
            this.lblSaveMyLAddress.TabIndex = 4;
            this.lblSaveMyLAddress.Text = "Address";
            // 
            // btnAddLocation2
            // 
            this.btnAddLocation2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddLocation2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLocation2.Location = new System.Drawing.Point(135, 208);
            this.btnAddLocation2.Name = "btnAddLocation2";
            this.btnAddLocation2.Size = new System.Drawing.Size(178, 41);
            this.btnAddLocation2.TabIndex = 8;
            this.btnAddLocation2.Text = "Add";
            this.btnAddLocation2.UseVisualStyleBackColor = false;
            // 
            // lblSaveMyLocationName
            // 
            this.lblSaveMyLocationName.AutoSize = true;
            this.lblSaveMyLocationName.Location = new System.Drawing.Point(227, 98);
            this.lblSaveMyLocationName.Name = "lblSaveMyLocationName";
            this.lblSaveMyLocationName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSaveMyLocationName.Size = new System.Drawing.Size(76, 13);
            this.lblSaveMyLocationName.TabIndex = 9;
            this.lblSaveMyLocationName.Text = "LocationName";
            // 
            // lblSaveMyLocationAddress
            // 
            this.lblSaveMyLocationAddress.AutoSize = true;
            this.lblSaveMyLocationAddress.Location = new System.Drawing.Point(227, 164);
            this.lblSaveMyLocationAddress.Name = "lblSaveMyLocationAddress";
            this.lblSaveMyLocationAddress.Size = new System.Drawing.Size(86, 13);
            this.lblSaveMyLocationAddress.TabIndex = 10;
            this.lblSaveMyLocationAddress.Text = "LocationAddress";
            // 
            // FormAddMyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.lblSaveMyLocationAddress);
            this.Controls.Add(this.lblSaveMyLocationName);
            this.Controls.Add(this.btnAddLocation2);
            this.Controls.Add(this.lblSaveMyLAddress);
            this.Controls.Add(this.lblSaveMyLName);
            this.Controls.Add(this.lblSaveMyLocation);
            this.Name = "FormAddMyLocation";
            this.Text = "Dodavanje lokacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaveMyLocation;
        private System.Windows.Forms.Label lblSaveMyLName;
        private System.Windows.Forms.Label lblSaveMyLAddress;
        private System.Windows.Forms.Button btnAddLocation2;
        public System.Windows.Forms.Label lblSaveMyLocationName;
        public System.Windows.Forms.Label lblSaveMyLocationAddress;
    }
}