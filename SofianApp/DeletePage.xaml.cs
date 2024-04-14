using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofianApp;

public partial class DeletePage : ContentPage
{
    public DeletePage()
    {
        InitializeComponent();
        BindingContext = App.CountryViewModel;
    }

    private async void DelButton_OnClicked(object sender, EventArgs e)
    {
        var name = NameEntryToDelete.Text;
        var countryViewModel = (CountryViewModel)BindingContext;

        var countryToDelete = countryViewModel.Countries.FirstOrDefault(c => c.Name == name);

        if (countryToDelete != null)
        {
            countryViewModel.Countries.Remove(countryToDelete);
            await DisplayAlert("Success", "Country deleted successfully", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Country not found", "OK");
        }
    }
}