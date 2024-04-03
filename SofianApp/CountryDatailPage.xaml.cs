using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofianApp;

public partial class CountryDatailPage : ContentPage
{
    public CountryDatailPage(Country country)
    {
        InitializeComponent();
        BindingContext = country;
        
    }
}