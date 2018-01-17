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
    public partial class FormAddCity : Form
    {
        private readonly Form1 FormAddCities;
        public FormAddCity(Form1 FormAddC)
        {
            FormAddCities = FormAddC;
            InitializeComponent();
        }

        private void btnAddCity2_Click(object sender, EventArgs e)
        {
            City oCity = new City();
            List<City> lCities = new List<City>();
            oCity.sCityName = inptAddCityName.Text;
            oCity.fCityLat = Convert.ToSingle(inptAddCityLat.Text);
            oCity.fCityLng = Convert.ToSingle(inptAddCityLng.Text);

            Crud oCrud = new Crud();
            oCrud.SaveNewCity(oCity);

            this.FormAddCities.dataGridViewCities.DataSource = oCrud.GetAllCities();
            /*lCities = oCrud.GetAllCities();
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            for (int i = 0; i < lCities.Count; i++)
            {
                comboSource.Add(lCities[i].nCityID, lCities[i].sCityName);
            }
            this.FormAddCities.comboBoxCity.DataSource = new BindingSource(comboSource, null);
            this.FormAddCities.comboBoxCity.DisplayMember = "Value";
            this.FormAddCities.comboBoxCity.ValueMember = "Key";*/
            this.Hide();
        }
    }
}
