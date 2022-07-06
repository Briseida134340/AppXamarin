using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Models;
using Tarea.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Song selectedItem = e.CurrentSelection[0] as Song;
            await this.Navigation.PushAsync(new Detalles(selectedItem));
        }
    }
}