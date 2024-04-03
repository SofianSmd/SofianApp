namespace SofianApp;

public class Country
{
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string Capital { get; set; }
    public string Currency { get; set; }
    public int Population { get; set; }
    
    public Media Media { get; set; }
    public string Phone { get; set; }
    
    public string WelcomeMessage => $"Bienvenue en {Name} ( {Abbreviation} ) :";
    public string CapitalMessage => $"La capitale de {Name} est {Capital}";
    public string CurrencyMessage => $"La monnaie de {Name} est {Currency}";
    public string PopulationMessage => $"La population de {Name} est {Population}";
    public string PhoneMessage => $"Le code téléphonique de {Name} est {Phone}";
    
}

public class Media
{
    public string Flag { get; set; }
    public string Emblem { get; set; }
    public string Orthographic { get; set; }
}