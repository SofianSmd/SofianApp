using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace SofianApp
{
    public partial class CountriesPage : ContentPage
    {
        
        
        
        public CountriesPage()
        {
            InitializeComponent();
            BindingContext = new CountryViewModel();
            
        }
        
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            var country = e.Item as Country;
            Navigation.PushAsync(new CountryDatailPage(country));
        }
        
    }
}