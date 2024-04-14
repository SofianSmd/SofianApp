using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofianApp;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
        BindingContext = App.CountryViewModel;
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        var country= new Country
        {
            Name = NameEntry.Text,
            Abbreviation = AbbreviationEntry.Text,
            Capital = CapitalEntry.Text,
            Currency = CurrencyEntry.Text,
            Population = int.Parse(PopulationEntry.Text),
            Phone = PhoneCodeEntry.Text,
            Media = new Media
            {
                Flag = FlagURLEntry.Text,
                Emblem = "",
                Orthographic = ""
            }
        };
        
        var countryViewModel = (CountryViewModel)BindingContext;
        countryViewModel.Countries.Add(country);
        await DisplayAlert("Success", "Country added successfully", "OK");
    }
}