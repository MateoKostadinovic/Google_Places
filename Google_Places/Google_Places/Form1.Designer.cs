namespace GooglePlaces
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblCity = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.inptRadiusValue = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewLocations = new System.Windows.Forms.DataGridView();
            this.sCityNameLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPlaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPlaceAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMapPlaces = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridViewMyLocations = new System.Windows.Forms.DataGridView();
            this.nMyLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMyLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMyLocationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMapMyPlaces = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.nTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTypeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddType = new System.Windows.Forms.Button();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.nCityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCityLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCityLng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Location = new System.Drawing.Point(0, 28);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(829, 498);
            this.tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GMapPlaces);
            this.tabPage1.Controls.Add(this.dataGridViewLocations);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.trackBarRadius);
            this.tabPage1.Controls.Add(this.lblRadius);
            this.tabPage1.Controls.Add(this.inptRadiusValue);
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.Controls.Add(this.lblType);
            this.tabPage1.Controls.Add(this.comboBoxCity);
            this.tabPage1.Controls.Add(this.lblCity);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pretraga";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GMapMyPlaces);
            this.tabPage2.Controls.Add(this.dataGridViewMyLocations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Moje lokacije";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddType);
            this.tabPage3.Controls.Add(this.dataGridViewTypes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(821, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Administracija tipova";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAddCity);
            this.tabPage4.Controls.Add(this.dataGridViewCities);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(821, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Administracija gradova";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(33, 24);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Grad";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(86, 21);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(244, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(22, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Tip";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(282, 21);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 7;
            // 
            // inptRadiusValue
            // 
            this.inptRadiusValue.Location = new System.Drawing.Point(443, 21);
            this.inptRadiusValue.Name = "inptRadiusValue";
            this.inptRadiusValue.Size = new System.Drawing.Size(72, 20);
            this.inptRadiusValue.TabIndex = 9;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(475, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 10;
            this.lblRadius.Text = "Radius";
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.LargeChange = 100;
            this.trackBarRadius.Location = new System.Drawing.Point(521, 0);
            this.trackBarRadius.Maximum = 50000;
            this.trackBarRadius.Minimum = 100;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(121, 45);
            this.trackBarRadius.SmallChange = 10;
            this.trackBarRadius.TabIndex = 11;
            this.trackBarRadius.TickFrequency = 100;
            this.trackBarRadius.Value = 100;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(686, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridViewLocations
            // 
            this.dataGridViewLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCityNameLocation,
            this.sPlaceName,
            this.sPlaceType,
            this.sPlaceAddress});
            this.dataGridViewLocations.Location = new System.Drawing.Point(17, 60);
            this.dataGridViewLocations.Name = "dataGridViewLocations";
            this.dataGridViewLocations.Size = new System.Drawing.Size(773, 168);
            this.dataGridViewLocations.TabIndex = 13;
            // 
            // sCityNameLocation
            // 
            this.sCityNameLocation.DataPropertyName = "sCityName";
            this.sCityNameLocation.HeaderText = "Grad";
            this.sCityNameLocation.Name = "sCityNameLocation";
            // 
            // sPlaceName
            // 
            this.sPlaceName.DataPropertyName = "sPlaceName";
            this.sPlaceName.HeaderText = "Naziv";
            this.sPlaceName.Name = "sPlaceName";
            // 
            // sPlaceType
            // 
            this.sPlaceType.DataPropertyName = "sPlaceType";
            this.sPlaceType.HeaderText = "Tip";
            this.sPlaceType.Name = "sPlaceType";
            // 
            // sPlaceAddress
            // 
            this.sPlaceAddress.DataPropertyName = "sPlaceAddress";
            this.sPlaceAddress.HeaderText = "Adresa";
            this.sPlaceAddress.Name = "sPlaceAddress";
            // 
            // GMapPlaces
            // 
            this.GMapPlaces.Bearing = 0F;
            this.GMapPlaces.CanDragMap = true;
            this.GMapPlaces.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapPlaces.GrayScaleMode = false;
            this.GMapPlaces.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapPlaces.LevelsKeepInMemmory = 5;
            this.GMapPlaces.Location = new System.Drawing.Point(17, 231);
            this.GMapPlaces.MarkersEnabled = true;
            this.GMapPlaces.MaxZoom = 18;
            this.GMapPlaces.MinZoom = 2;
            this.GMapPlaces.MouseWheelZoomEnabled = true;
            this.GMapPlaces.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapPlaces.Name = "GMapPlaces";
            this.GMapPlaces.NegativeMode = false;
            this.GMapPlaces.PolygonsEnabled = true;
            this.GMapPlaces.RetryLoadTile = 0;
            this.GMapPlaces.RoutesEnabled = true;
            this.GMapPlaces.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapPlaces.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapPlaces.ShowTileGridLines = false;
            this.GMapPlaces.Size = new System.Drawing.Size(773, 238);
            this.GMapPlaces.TabIndex = 14;
            this.GMapPlaces.Zoom = 10D;
            // 
            // dataGridViewMyLocations
            // 
            this.dataGridViewMyLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMyLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMyLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nMyLocationID,
            this.sMyLocationName,
            this.sMyLocationAddress});
            this.dataGridViewMyLocations.Location = new System.Drawing.Point(17, 6);
            this.dataGridViewMyLocations.Name = "dataGridViewMyLocations";
            this.dataGridViewMyLocations.Size = new System.Drawing.Size(773, 230);
            this.dataGridViewMyLocations.TabIndex = 1;
            // 
            // nMyLocationID
            // 
            this.nMyLocationID.DataPropertyName = "nMyLocationID";
            this.nMyLocationID.HeaderText = "ID";
            this.nMyLocationID.Name = "nMyLocationID";
            // 
            // sMyLocationName
            // 
            this.sMyLocationName.DataPropertyName = "sMyLocationName";
            this.sMyLocationName.HeaderText = "Ime lokacije";
            this.sMyLocationName.Name = "sMyLocationName";
            // 
            // sMyLocationAddress
            // 
            this.sMyLocationAddress.DataPropertyName = "sMyLocationAddress";
            this.sMyLocationAddress.HeaderText = "Adresa lokacije";
            this.sMyLocationAddress.Name = "sMyLocationAddress";
            // 
            // GMapMyPlaces
            // 
            this.GMapMyPlaces.Bearing = 0F;
            this.GMapMyPlaces.CanDragMap = true;
            this.GMapMyPlaces.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapMyPlaces.GrayScaleMode = false;
            this.GMapMyPlaces.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapMyPlaces.LevelsKeepInMemmory = 5;
            this.GMapMyPlaces.Location = new System.Drawing.Point(17, 242);
            this.GMapMyPlaces.MarkersEnabled = true;
            this.GMapMyPlaces.MaxZoom = 18;
            this.GMapMyPlaces.MinZoom = 2;
            this.GMapMyPlaces.MouseWheelZoomEnabled = true;
            this.GMapMyPlaces.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapMyPlaces.Name = "GMapMyPlaces";
            this.GMapMyPlaces.NegativeMode = false;
            this.GMapMyPlaces.PolygonsEnabled = true;
            this.GMapMyPlaces.RetryLoadTile = 0;
            this.GMapMyPlaces.RoutesEnabled = true;
            this.GMapMyPlaces.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapMyPlaces.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapMyPlaces.ShowTileGridLines = false;
            this.GMapMyPlaces.Size = new System.Drawing.Size(773, 240);
            this.GMapMyPlaces.TabIndex = 2;
            this.GMapMyPlaces.Zoom = 10D;
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nTypeID,
            this.sTypeName,
            this.sTypeValue});
            this.dataGridViewTypes.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.Size = new System.Drawing.Size(499, 252);
            this.dataGridViewTypes.TabIndex = 1;
            // 
            // nTypeID
            // 
            this.nTypeID.DataPropertyName = "nTypeID";
            this.nTypeID.HeaderText = "ID";
            this.nTypeID.Name = "nTypeID";
            // 
            // sTypeName
            // 
            this.sTypeName.DataPropertyName = "sTypeName";
            this.sTypeName.HeaderText = "Ime tipa lokacije";
            this.sTypeName.Name = "sTypeName";
            // 
            // sTypeValue
            // 
            this.sTypeValue.DataPropertyName = "sTypeValue";
            this.sTypeValue.HeaderText = "Vrijednost tipa lokacije";
            this.sTypeValue.Name = "sTypeValue";
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.DimGray;
            this.btnAddType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddType.Location = new System.Drawing.Point(540, 6);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(118, 37);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.Text = "Dodaj tip";
            this.btnAddType.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCityID,
            this.sCityName,
            this.fCityLat,
            this.fCityLng});
            this.dataGridViewCities.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.Size = new System.Drawing.Size(520, 252);
            this.dataGridViewCities.TabIndex = 2;
            // 
            // nCityID
            // 
            this.nCityID.DataPropertyName = "nCityID";
            this.nCityID.HeaderText = "ID";
            this.nCityID.Name = "nCityID";
            // 
            // sCityName
            // 
            this.sCityName.DataPropertyName = "sCityName";
            this.sCityName.HeaderText = "Ime grada";
            this.sCityName.Name = "sCityName";
            // 
            // fCityLat
            // 
            this.fCityLat.DataPropertyName = "fCityLat";
            this.fCityLat.HeaderText = "Latituda";
            this.fCityLat.Name = "fCityLat";
            // 
            // fCityLng
            // 
            this.fCityLng.DataPropertyName = "fCityLng";
            this.fCityLng.HeaderText = "Longituda";
            this.fCityLng.Name = "fCityLng";
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.DimGray;
            this.btnAddCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCity.Location = new System.Drawing.Point(553, 6);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(118, 37);
            this.btnAddCity.TabIndex = 3;
            this.btnAddCity.Text = "Dodaj grad";
            this.btnAddCity.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 529);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GooglePlaces";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private GMap.NET.WindowsForms.GMapControl GMapPlaces;
        public System.Windows.Forms.DataGridView dataGridViewLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCityNameLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPlaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPlaceAddress;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox inptRadiusValue;
        public System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblType;
        public System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label lblCity;
        private GMap.NET.WindowsForms.GMapControl GMapMyPlaces;
        public System.Windows.Forms.DataGridView dataGridViewMyLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMyLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMyLocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMyLocationAddress;
        private System.Windows.Forms.Button btnAddType;
        public System.Windows.Forms.DataGridView dataGridViewTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTypeValue;
        private System.Windows.Forms.Button btnAddCity;
        public System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCityLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCityLng;
    }
}

