using EM_DZ4.City;
using EM_DZ4.Country;
using EM_DZ4.Building.Childrens;
using EM_DZ4;
using EM_DZ4.Building.Chilrens;

Country country = new Country("Ukraine", GovernmentType.Democracy);

City kyiv = new City("Kyiv", CitySize.Large, 3000000, 60, 20);
City lviv = new City("Lviv", CitySize.Medium, 700000, 70, 15);
City dnipro = new City("Dnipro", CitySize.Medium, 1000000, 50, 25);

kyiv.AddBuilding(new Farm(1));
kyiv.AddBuilding(new Theatre(2));

lviv.AddBuilding(new Theatre(3));
lviv.AddBuilding(new Farm(4));

dnipro.AddBuilding(new Mine(5));
dnipro.AddBuilding(new Farm(6));

country.AddCity(kyiv);
country.AddCity(lviv);
country.AddCity(dnipro);

for (int month = 1; month <= 12; month++)
{
    country.MonthlyUpdate();
    Console.WriteLine($"Month {month}: Money = {country.Resources[ResourceType.Money]}, Food = {country.Resources[ResourceType.Food]}");
}

namespace EM_DZ4
{
    enum GovernmentType
    {
        Monarchy,
        Democracy,
        Dictatorship
    }

    enum CitySize
    {
        Small = 12,
        Medium = 20,
        Large = 36
    }

    enum ResourceType
    {
        Money,
        Food,
        Happiness,
        TaxBonus
    }
}