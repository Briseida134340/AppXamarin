using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalles : ContentPage
    {
        public Detalles(Song song)
        {
            InitializeComponent();
            imageContainer.Source = song.Image;
            titulo1.Text = song.Name;
           
           
        }

        private async void btnFormulario_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Formulario());
        }
    }
}