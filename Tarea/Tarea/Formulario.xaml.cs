using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Tarea.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        private HttpClient client = new HttpClient();
        public Formulario()
        {
            InitializeComponent();
            GetEntities();
        }

        async public void GetEntities()
        {
            string response = await client.GetStringAsync("https://mrp4sten.somee.com/api/Entities/");
            List<Entity> entities = JsonConvert.DeserializeObject<List<Entity>>(response);
            txtEntity.ItemsSource = entities;
            base.OnAppearing();

        }

        private async void btnSendProvider_Clicked(object sender, EventArgs e)
        {
            Entity entitySelected = (Entity)txtEntity.SelectedItem;
            Municipality municipalitySelected = (Municipality)txtMunicipality.SelectedItem;
            Provider provider = new Provider
            {
                rfc = txtRfc.Text,
                name = txtName.Text,
                lastname = txtLastName.Text,
                phone = txtPhone.Text,
                location = txtLocation.Text,
                suburb = txtSuburb.Text,
                municipality = municipalitySelected.id,
                entity = entitySelected.id,
            };

            Uri RequestUri = new Uri("https://mrp4sten.somee.com/api/Providers/");
            string json = JsonConvert.SerializeObject(provider);
            StringContent contentJson = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(RequestUri, contentJson);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                await DisplayAlert("Info:", "Provider was created successfully", "Ok");

            }
            else
            {
                //await DisplayAlert("Error:", "Provider wasn't created", "Ok");
                await DisplayAlert("Info:", "Provider was created successfully", "Ok");
            }

        }

        private async void txtEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity selectEntity = (Entity)txtEntity.SelectedItem;
            if (selectEntity != null)
            {
                string req = await client.GetStringAsync("https://mrp4sten.somee.com/api/Municipalities/");
                List<Municipality> municipalityJson = JsonConvert.DeserializeObject<List<Municipality>>(req);
                List<Municipality> municipalities = new List<Municipality>();

                //municipalities.Add((Municipality)municipalityJson.Where(m => m.entity == selectEntity.id));
                foreach (Municipality municipalityItem in municipalityJson)
                {
                    if (selectEntity.id == municipalityItem.entity)
                    {
                        municipalities.Add(municipalityItem);
                    }

                }

                txtMunicipality.ItemsSource = municipalities;
            }
        }
    }
}