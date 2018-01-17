namespace Google_Places
{
    partial class FormDeleteType
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
            this.lblDeleteType = new System.Windows.Forms.Label();
            this.lblDeleteTypeId = new System.Windows.Forms.Label();
            this.btnDeleteTypeClose = new System.Windows.Forms.Button();
            this.btnTypeDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteType
            // 
            this.lblDeleteType.AutoSize = true;
            this.lblDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteType.Location = new System.Drawing.Point(108, 31);
            this.lblDeleteType.Name = "lblDeleteType";
            this.lblDeleteType.Size = new System.Drawing.Size(133, 25);
            this.lblDeleteType.TabIndex = 4;
            this.lblDeleteType.Text = "Delete type?";
            // 
            // lblDeleteTypeId
            // 
            this.lblDeleteTypeId.AutoSize = true;
            this.lblDeleteTypeId.Location = new System.Drawing.Point(45, 94);
            this.lblDeleteTypeId.Name = "lblDeleteTypeId";
            this.lblDeleteTypeId.Size = new System.Drawing.Size(40, 13);
            this.lblDeleteTypeId.TabIndex = 5;
            this.lblDeleteTypeId.Text = "TypeId";
            this.lblDeleteTypeId.Visible = false;
            // 
            // btnDeleteTypeClose
            // 
            this.btnDeleteTypeClose.Location = new System.Drawing.Point(12, 172);
            this.btnDeleteTypeClose.Name = "btnDeleteTypeClose";
            this.btnDeleteTypeClose.Size = new System.Drawing.Size(159, 77);
            this.btnDeleteTypeClose.TabIndex = 6;
            this.btnDeleteTypeClose.Text = "Close";
            this.btnDeleteTypeClose.UseVisualStyleBackColor = true;
            // 
            // btnTypeDelete
            // 
            this.btnTypeDelete.Location = new System.Drawing.Point(186, 172);
            this.btnTypeDelete.Name = "btnTypeDelete";
            this.btnTypeDelete.Size = new System.Drawing.Size(159, 77);
            this.btnTypeDelete.TabIndex = 7;
            this.btnTypeDelete.Text = "Delete";
            this.btnTypeDelete.UseVisualStyleBackColor = true;
            // 
            // FormDeleteType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.btnTypeDelete);
            this.Controls.Add(this.btnDeleteTypeClose);
            this.Controls.Add(this.lblDeleteTypeId);
            this.Controls.Add(this.lblDeleteType);
            this.Name = "FormDeleteType";
            this.Text = "Brisanje tipa lokacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteType;
        public System.Windows.Forms.Label lblDeleteTypeId;
        private System.Windows.Forms.Button btnDeleteTypeClose;
        private System.Windows.Forms.Button btnTypeDelete;
    }
}