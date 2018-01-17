namespace Google_Places
{
    partial class FormDeleteMyLocation
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
            this.lblDeleteMyLocation = new System.Windows.Forms.Label();
            this.lblDeleteMyLocationId = new System.Windows.Forms.Label();
            this.btnDeleteMyLocationClose = new System.Windows.Forms.Button();
            this.btnMyLocationDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteMyLocation
            // 
            this.lblDeleteMyLocation.AutoSize = true;
            this.lblDeleteMyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteMyLocation.Location = new System.Drawing.Point(80, 31);
            this.lblDeleteMyLocation.Name = "lblDeleteMyLocation";
            this.lblDeleteMyLocation.Size = new System.Drawing.Size(231, 25);
            this.lblDeleteMyLocation.TabIndex = 2;
            this.lblDeleteMyLocation.Text = "Delete saved location?";
            // 
            // lblDeleteMyLocationId
            // 
            this.lblDeleteMyLocationId.AutoSize = true;
            this.lblDeleteMyLocationId.Location = new System.Drawing.Point(30, 84);
            this.lblDeleteMyLocationId.Name = "lblDeleteMyLocationId";
            this.lblDeleteMyLocationId.Size = new System.Drawing.Size(71, 13);
            this.lblDeleteMyLocationId.TabIndex = 3;
            this.lblDeleteMyLocationId.Text = "MyLocationId";
            this.lblDeleteMyLocationId.Visible = false;
            // 
            // btnDeleteMyLocationClose
            // 
            this.btnDeleteMyLocationClose.Location = new System.Drawing.Point(12, 174);
            this.btnDeleteMyLocationClose.Name = "btnDeleteMyLocationClose";
            this.btnDeleteMyLocationClose.Size = new System.Drawing.Size(158, 75);
            this.btnDeleteMyLocationClose.TabIndex = 4;
            this.btnDeleteMyLocationClose.Text = "Close";
            this.btnDeleteMyLocationClose.UseVisualStyleBackColor = true;
            // 
            // btnMyLocationDelete
            // 
            this.btnMyLocationDelete.Location = new System.Drawing.Point(209, 174);
            this.btnMyLocationDelete.Name = "btnMyLocationDelete";
            this.btnMyLocationDelete.Size = new System.Drawing.Size(158, 75);
            this.btnMyLocationDelete.TabIndex = 5;
            this.btnMyLocationDelete.Text = "Delete";
            this.btnMyLocationDelete.UseVisualStyleBackColor = true;
            // 
            // FormDeleteMyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.btnMyLocationDelete);
            this.Controls.Add(this.btnDeleteMyLocationClose);
            this.Controls.Add(this.lblDeleteMyLocationId);
            this.Controls.Add(this.lblDeleteMyLocation);
            this.Name = "FormDeleteMyLocation";
            this.Text = "Brisanje spremljene lokacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteMyLocation;
        public System.Windows.Forms.Label lblDeleteMyLocationId;
        private System.Windows.Forms.Button btnDeleteMyLocationClose;
        private System.Windows.Forms.Button btnMyLocationDelete;
    }
}