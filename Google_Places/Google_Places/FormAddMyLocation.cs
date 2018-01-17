using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CRUD;

namespace GooglePlaces
{
    public partial class FormAddMyLocation : Form
    {
        private readonly Form1 FormAddLocations;
        public FormAddMyLocation(Form1 FormAddLocation)
        {
            FormAddLocations = FormAddLocation;
            InitializeComponent();
        }

        private void btnAddLocation2_Click(object sender, EventArgs e)
        {
            MyLocations oMyLocation = new MyLocations();

            oMyLocation.sMyLocationName = lblSaveMyLocationName.Text;
            oMyLocation.sMyLocationAddress = lblSaveMyLocationAddress.Text;

            Crud oCrud = new Crud();
            oCrud.SaveNewLocation(oMyLocation);

            this.FormAddLocations.dataGridViewMyLocations.DataSource = oCrud.GetAllMyLocations();
            this.Hide();
        }
    }
}
