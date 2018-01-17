namespace Google_Places
{
    partial class FormEditType
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
            this.lblTypeId = new System.Windows.Forms.Label();
            this.lblEditTypeName = new System.Windows.Forms.Label();
            this.lblEditTypeValue = new System.Windows.Forms.Label();
            this.inptEditTypeName = new System.Windows.Forms.TextBox();
            this.inptEditTypeValue = new System.Windows.Forms.TextBox();
            this.btnEditType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.Location = new System.Drawing.Point(35, 34);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(40, 13);
            this.lblTypeId.TabIndex = 8;
            this.lblTypeId.Text = "TypeId";
            this.lblTypeId.Visible = false;
            // 
            // lblEditTypeName
            // 
            this.lblEditTypeName.AutoSize = true;
            this.lblEditTypeName.Location = new System.Drawing.Point(40, 96);
            this.lblEditTypeName.Name = "lblEditTypeName";
            this.lblEditTypeName.Size = new System.Drawing.Size(35, 13);
            this.lblEditTypeName.TabIndex = 9;
            this.lblEditTypeName.Text = "Name";
            // 
            // lblEditTypeValue
            // 
            this.lblEditTypeValue.AutoSize = true;
            this.lblEditTypeValue.Location = new System.Drawing.Point(41, 152);
            this.lblEditTypeValue.Name = "lblEditTypeValue";
            this.lblEditTypeValue.Size = new System.Drawing.Size(34, 13);
            this.lblEditTypeValue.TabIndex = 10;
            this.lblEditTypeValue.Text = "Value";
            // 
            // inptEditTypeName
            // 
            this.inptEditTypeName.Location = new System.Drawing.Point(133, 93);
            this.inptEditTypeName.Name = "inptEditTypeName";
            this.inptEditTypeName.Size = new System.Drawing.Size(156, 20);
            this.inptEditTypeName.TabIndex = 11;
            // 
            // inptEditTypeValue
            // 
            this.inptEditTypeValue.Location = new System.Drawing.Point(133, 149);
            this.inptEditTypeValue.Name = "inptEditTypeValue";
            this.inptEditTypeValue.Size = new System.Drawing.Size(156, 20);
            this.inptEditTypeValue.TabIndex = 12;
            // 
            // btnEditType
            // 
            this.btnEditType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditType.Location = new System.Drawing.Point(133, 193);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(156, 50);
            this.btnEditType.TabIndex = 13;
            this.btnEditType.Text = "Save";
            this.btnEditType.UseVisualStyleBackColor = false;
            // 
            // FormEditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 264);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.inptEditTypeValue);
            this.Controls.Add(this.inptEditTypeName);
            this.Controls.Add(this.lblEditTypeValue);
            this.Controls.Add(this.lblEditTypeName);
            this.Controls.Add(this.lblTypeId);
            this.Name = "FormEditType";
            this.Text = "Uredi tip lokacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTypeId;
        private System.Windows.Forms.Label lblEditTypeName;
        private System.Windows.Forms.Label lblEditTypeValue;
        public System.Windows.Forms.TextBox inptEditTypeName;
        public System.Windows.Forms.TextBox inptEditTypeValue;
        private System.Windows.Forms.Button btnEditType;
    }
}