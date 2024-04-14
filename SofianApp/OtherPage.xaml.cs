using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofianApp;

public partial class OtherPage : ContentPage
{
    public OtherPage()
    {
        InitializeComponent();
    }
    
    async void OnDeleteCountryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeletePage());
    }
    
    async void ActualizeClicked(object sender, EventArgs e)
    {
        await App.CountryViewModel.LoadCountries();
        await DisplayAlert("Actualisation", "La liste des pays a été actualisée.", "OK");

    }

    
}