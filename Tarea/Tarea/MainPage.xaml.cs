using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.ViewModels;
using Xamarin.Forms;

namespace Tarea
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

          
        }

        private async void BtnPaguinaTres_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }

        
    }
}
