using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace SofianApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            var images = new List<string>
            {
                "security1.png",
                "security2.png",
                "security3.png"
            };
            
            async void OnAcceptButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new AcceptPage());
            }
            
            async void OnDeclineButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new DeclinePage());
            }

        }
    }
}