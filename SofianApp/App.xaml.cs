namespace SofianApp;

public partial class App : Application
{
	public static CountryViewModel CountryViewModel { get; private set; }
	public App()
	{
		InitializeComponent();
		CountryViewModel = new CountryViewModel();
		MainPage = new AppShell();
	}
}

