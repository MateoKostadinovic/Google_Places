using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CRUD;
using REST;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace GooglePlaces
{
    public partial class Form1 : Form
    {
        public List<GooglePlacesView> lGPlaces = new List<GooglePlacesView>();
        List<Types> lTypes = new List<Types>();
        List<City> lCities = new List<City>();
        List<MyLocations> lMyLocations = new List<MyLocations>();
        public Form1()
        {
            InitializeComponent();
            Crud oCrud = new Crud();
            lCities = oCrud.GetAllCities();
            lTypes = oCrud.GetAllTypes();
            lMyLocations = oCrud.GetAllMyLocations();

            dataGridViewTypes.DataSource = lTypes;
            dataGridViewCities.DataSource = lCities;
            dataGridViewMyLocations.DataSource = lMyLocations;


            //button za uredivanje tipova
            DataGridViewImageColumn oEditButtonType = new DataGridViewImageColumn();//nova kolona tipa Image
            oEditButtonType.Image = Image.FromFile("if_ic_mode_edit_48px_352547.png");
            oEditButtonType.Width = 20;
            oEditButtonType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTypes.Columns.Add(oEditButtonType);

            //buttona za uredivanje gradova
            DataGridViewImageColumn oEditButtonCity = new DataGridViewImageColumn();//nova kolona tipa Image
            oEditButtonCity.Image = Image.FromFile("if_ic_mode_edit_48px_352547.png");
            oEditButtonCity.Width = 20;
            oEditButtonCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCities.Columns.Add(oEditButtonCity);

            //button za brisanje tipa
            DataGridViewImageColumn oDeleteButtonType = new DataGridViewImageColumn();//nova kolona tipa Image
            oDeleteButtonType.Image = Image.FromFile("if_ic_delete_48px_352303.png");
            oDeleteButtonType.Width = 20;
            oDeleteButtonType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTypes.Columns.Add(oDeleteButtonType);

            //button za brisanje grada
            DataGridViewImageColumn oDeleteButtonCity = new DataGridViewImageColumn();//nova kolona tipa Image
            oDeleteButtonCity.Image = Image.FromFile("if_ic_delete_48px_352303.png");
            oDeleteButtonCity.Width = 20;
            oDeleteButtonCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCities.Columns.Add(oDeleteButtonCity);

            //button za brisanje moje lokacije
            DataGridViewImageColumn oDeleteButtonMyLocation = new DataGridViewImageColumn();//nova kolona tipa Image
            oDeleteButtonMyLocation.Image = Image.FromFile("if_ic_delete_48px_352303.png");
            oDeleteButtonMyLocation.Width = 20;
            oDeleteButtonMyLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMyLocations.Columns.Add(oDeleteButtonMyLocation);

            dataGridViewTypes.AutoGenerateColumns = false;//program nece sam stvoriti sve kolone, lijepo ce se posloziti
            dataGridViewCities.AutoGenerateColumns = false;
            dataGridViewMyLocations.AutoGenerateColumns = false;

            //COMBO- BOX GRADOVI

            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            for (int i = 0; i < lCities.Count; i++)
            {
                comboSource.Add(lCities[i].nCityID, lCities[i].sCityName);
            }
            comboBoxCity.DataSource = new BindingSource(comboSource, null);
            comboBoxCity.DisplayMember = "Value";
            comboBoxCity.ValueMember = "Key";

            //COMBO- BOX TIPOVI
            List<string> lType = lTypes.Where(o => o.sTypeValue != "").Select(o => o.sTypeValue).Distinct().ToList();
            comboBoxType.DataSource = lType;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormAddType FormAddType = new FormAddType(this);
            FormAddType.Show();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            FormAddCity FormAddCity = new FormAddCity(this);
            FormAddCity.Show();
        }

        private void dataGridViewTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTypes.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (dataGridViewTypes.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                FormEditType FormEditType = new FormEditType(this);//kreira novu formu koja prima objekt tipa Form1 sa pokazivacem this
                FormEditType.lblTypeId.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditType.inptEditTypeName.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditType.inptEditTypeValue.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[2].Value.ToString();          
                FormEditType.Show();
            }
            if (dataGridViewTypes.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                FormDeleteType FormDeleteType = new FormDeleteType(this);
                FormDeleteType.lblDeleteTypeId.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteType.Show();
            }
        }

        private void dataGridViewCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCities.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (dataGridViewCities.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                FormEditCity FormEditCity = new FormEditCity(this);//kreira novu formu koja prima objekt tipa Form1 sa pokazivacem this
                FormEditCity.lblCityId.Text = dataGridViewCities.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditCity.inptEditCityName.Text = dataGridViewCities.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditCity.inptEditCityLat.Text = dataGridViewCities.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditCity.inptEditCityLng.Text = dataGridViewCities.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditCity.Show();
            }
            if (dataGridViewCities.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormDeleteCity FormDeleteCity = new FormDeleteCity(this);
                FormDeleteCity.lblDeleteCityId.Text = dataGridViewCities.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteCity.Show();
            }
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mateo Kostadinović");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /* button za pretragu lokacija preko api-a*/

            Rest oRest = new Rest();
            Crud oCrud = new Crud();
            string sCity = ((KeyValuePair<int, string>)comboBoxCity.SelectedItem).Value;
            int nCityId2 = 5;
            int nCityId;
            lCities = oCrud.GetAllCities();
            Trace.WriteLine("Lista lCities " + lCities.Count);

            List<KeyValuePair<int, string>> KV_List = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < lCities.Count; i++)
            {
                KV_List.Add(new KeyValuePair<int, string>(lCities[i].nCityID, lCities[i].sCityName));
            }
            Trace.WriteLine("Lista KV_List " + KV_List.Count);
            for (int i = 0; i < KV_List.Count; i++)
            {
                Trace.WriteLine("Ulazak u petlju for " + 10);
                if (KV_List[i].Value == sCity)
                {
                    Trace.WriteLine("Ulazak u petlju if " + 1);
                    nCityId2 = KV_List[i].Key;
                }
            }
            nCityId = nCityId2;
            Trace.WriteLine("Id odabranog grada " + nCityId);
            lCities = lCities.Where(o => o.nCityID == nCityId).ToList();
            string sCityLat;
            string sCityLng;
            sCityLat = (lCities[0].fCityLat).ToString(CultureInfo.InvariantCulture);
            sCityLng = (lCities[0].fCityLng).ToString(CultureInfo.InvariantCulture);
            Trace.WriteLine("Latitude " + sCityLat);
            Trace.WriteLine("Longitude " + sCityLng);

            string sType = (string)comboBoxType.SelectedItem;
            float fRadius = (int)trackBarRadius.Value;

            lGPlaces = oRest.GetPlaces(sCity, sCityLat, sCityLng, sType, fRadius);
            dataGridViewLocations.DataSource = lGPlaces;

            //button za spremanje moje lokacije
            DataGridViewImageColumn oSaveButtonMyLocation = new DataGridViewImageColumn();//nova kolona tipa Image
            oSaveButtonMyLocation.Image = Image.FromFile("if_save_2639912.png");
            oSaveButtonMyLocation.Width = 20;
            oSaveButtonMyLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLocations.Columns.Add(oSaveButtonMyLocation);

            //button za zumiranje lokacije
            DataGridViewImageColumn oZoomButtonMyLocation = new DataGridViewImageColumn();//nova kolona tipa Image
            oZoomButtonMyLocation.Image = Image.FromFile("if_search_326690.png");
            oZoomButtonMyLocation.Width = 20;
            oZoomButtonMyLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLocations.Columns.Add(oZoomButtonMyLocation);

            dataGridViewLocations.AutoGenerateColumns = false;

            //adding marker
            /*float fCityLat2 = float.Parse(sCityLat, CultureInfo.InvariantCulture);
            float fCityLng2 = Convert.ToSingle(sCityLng);*/
            double fCityLat2 = Double.Parse(sCityLat);
            double fCityLng2 = Double.Parse(sCityLng);
            Trace.WriteLine(fCityLat2);
            Trace.WriteLine("LAT PROBA " + fCityLat2);
            Trace.WriteLine("LNG PROBA " + fCityLng2);



            GMapOverlay markers = new GMapOverlay("markers");
            for (int i = 0; i < lGPlaces.Count; i++)
            {
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(lGPlaces[i].fPlaceLat, lGPlaces[i].fPlaceLng),
                    GMarkerGoogleType.red);
                markers.Markers.Add(marker);
            }
            GMapPlaces.Overlays.Add(markers);
        }

        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            inptRadiusValue.Text = "" + trackBarRadius.Value;
        }

        private void dataGridViewMyLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMyLocations.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (dataGridViewMyLocations.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                FormDeleteMyLocation FormDeleteMyLocation = new FormDeleteMyLocation(this);
                FormDeleteMyLocation.lblDeleteMyLocationId.Text = dataGridViewMyLocations.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteMyLocation.Show();
            }
        }

        private void dataGridViewLocations_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLocations.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (dataGridViewLocations.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                //ovdje jos dodati formsavemylocation i pokupiti parametre iz tablice???
                FormAddMyLocation FormAddMyLocation = new FormAddMyLocation(this);
                FormAddMyLocation.lblSaveMyLocationName.Text = dataGridViewLocations.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormAddMyLocation.lblSaveMyLocationAddress.Text = dataGridViewLocations.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormAddMyLocation.Show();
            }
        }

        private void GMapPlaces_Load(object sender, EventArgs e)
        {
            GMapPlaces.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            GMapPlaces.SetPositionByKeywords("Slatina, Croatia");
            GMapPlaces.ShowCenter = false;
        }

        private void GMapMyPlaces_Load(object sender, EventArgs e)
        {
            GMapMyPlaces.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            GMapMyPlaces.SetPositionByKeywords("Slatina, Croatia");
            GMapMyPlaces.ShowCenter = false;
        }
    }
}
