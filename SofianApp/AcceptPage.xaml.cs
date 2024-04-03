using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofianApp;

public partial class AcceptPage : ContentPage
{
    public AcceptPage()
    {
        InitializeComponent();
    }
    
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(100);
        AcceptGif.IsAnimationPlaying = true;
    }
}