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
    public partial class FormDeleteMyLocation : Form
    {
        private readonly Form1 FormDeleteMyLocations;
        public FormDeleteMyLocation(Form1 FormDeleteMyL)
        {
            FormDeleteMyLocations = FormDeleteMyL;
            InitializeComponent();
        }

        private void btnDeleteMyLocationClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMyLocationDelete_Click(object sender, EventArgs e)
        {
            int nMyLocationId = Int32.Parse(lblDeleteMyLocationId.Text);
            Crud oCrud = new Crud();
            oCrud.DeleteMyLocation(nMyLocationId);

            this.FormDeleteMyLocations.dataGridViewMyLocations.DataSource = oCrud.GetAllMyLocations();
            this.Hide();
        }
    }
}
