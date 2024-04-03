using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SofianApp
{
    public class CountryViewModel : INotifyPropertyChanged
    {
        private readonly ApiService _apiService;
        private ObservableCollection<Country> _countries;
        
        public ObservableCollection<Country> getCountries()
        {
            return _countries;
        }
        
        public void setCountries(ObservableCollection<Country> countries)
        {
            _countries = countries;
        }
        
        

        public ObservableCollection<Country> Countries
        {
            get { return _countries; }
            set
            {
                _countries = value;
                OnPropertyChanged();
            }
        }

        public CountryViewModel()
        {
            _apiService = new ApiService();
            LoadCountries();
        }

        private async void LoadCountries()
        {
            
            Countries = new ObservableCollection<Country>(await _apiService.GetDataAsync<List<Country>>("https://api.sampleapis.com/countries/countries"));
            
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}