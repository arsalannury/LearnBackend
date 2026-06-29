var earth = new World();
var result = earth.ValidCountry("Yemen");

Console.WriteLine(result.countryName);
Console.WriteLine(result.continentName);


class World
{
    List<string> _continents = new List<string> { "Asia", "Europe", "Africa", "America", "Austrlia" };
    public int countryCounts = 290;
    public long worldAge = 10000000000000000;
    List<CountryInfo> _countries = new List<CountryInfo>
    {
    new CountryInfo("Afghanistan", "Asia"),
    new CountryInfo("Albania", "Europe"),
    new CountryInfo("Algeria", "Africa"),
    new CountryInfo("Argentina", "South America"),
    new CountryInfo("Australia", "Australia"),
    new CountryInfo("Austria", "Europe"),
    new CountryInfo("Azerbaijan", "Asia"),
    new CountryInfo("Bahrain", "Asia"),
    new CountryInfo("Bangladesh", "Asia"),
    new CountryInfo("Belgium", "Europe"),
    new CountryInfo("Brazil", "South America"),
    new CountryInfo("Bulgaria", "Europe"),
    new CountryInfo("Canada", "North America"),
    new CountryInfo("Chile", "South America"),
    new CountryInfo("China", "Asia"),
    new CountryInfo("Colombia", "South America"),
    new CountryInfo("Croatia", "Europe"),
    new CountryInfo("Czech Republic", "Europe"),
    new CountryInfo("Denmark", "Europe"),
    new CountryInfo("Egypt", "Africa"),
    new CountryInfo("Finland", "Europe"),
    new CountryInfo("France", "Europe"),
    new CountryInfo("Germany", "Europe"),
    new CountryInfo("Greece", "Europe"),
    new CountryInfo("Hungary", "Europe"),
    new CountryInfo("India", "Asia"),
    new CountryInfo("Indonesia", "Asia"),
    new CountryInfo("Iran", "Asia"),
    new CountryInfo("Iraq", "Asia"),
    new CountryInfo("Ireland", "Europe"),
    new CountryInfo("Italy", "Europe"),
    new CountryInfo("Japan", "Asia"),
    new CountryInfo("Kazakhstan", "Asia"),
    new CountryInfo("Kenya", "Africa"),
    new CountryInfo("Malaysia", "Asia"),
    new CountryInfo("Mexico", "North America"),
    new CountryInfo("Morocco", "Africa"),
    new CountryInfo("Netherlands", "Europe"),
    new CountryInfo("New Zealand", "Australia"),
    new CountryInfo("Nigeria", "Africa"),
    new CountryInfo("Norway", "Europe"),
    new CountryInfo("Pakistan", "Asia"),
    new CountryInfo("Peru", "South America"),
    new CountryInfo("Poland", "Europe"),
    new CountryInfo("Portugal", "Europe"),
    new CountryInfo("Qatar", "Asia"),
    new CountryInfo("Romania", "Europe"),
    new CountryInfo("Russia", "Europe/Asia"),
    new CountryInfo("Saudi Arabia", "Asia"),
    new CountryInfo("Singapore", "Asia"),
    new CountryInfo("South Africa", "Africa"),
    new CountryInfo("South Korea", "Asia"),
    new CountryInfo("Spain", "Europe"),
    new CountryInfo("Sweden", "Europe"),
    new CountryInfo("Switzerland", "Europe"),
    new CountryInfo("Thailand", "Asia"),
    new CountryInfo("Turkey", "Europe/Asia"),
    new CountryInfo("Ukraine", "Europe"),
    new CountryInfo("United Arab Emirates", "Asia"),
    new CountryInfo("United Kingdom", "Europe"),
    new CountryInfo("United States", "North America"),
    new CountryInfo("Uruguay", "South America"),
    new CountryInfo("Venezuela", "South America"),
    new CountryInfo("Vietnam", "Asia"),
    new CountryInfo("Yemen", "Asia"),
    new CountryInfo("Zimbabwe", "Africa")
    };

    public List<string> GetContinents()
    {
        return _continents;
    }

    public CountryInfo ValidCountry(string name) => _countries.Find(country => country.countryName == name) ?? new CountryInfo("None", "None");


}

class CountryInfo
{

    public string countryName;
    public string continentName;

    public CountryInfo(string name, string continent)
    {
        countryName = name;
        continentName = continent;
    }

}
