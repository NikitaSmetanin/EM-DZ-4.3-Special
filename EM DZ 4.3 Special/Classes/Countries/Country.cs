using System;
using EM_DZ4.Building;
using EM_DZ4;
using EM_DZ4.City;

namespace EM_DZ4.Country {
    class Country
    {
        public string Name { get; }
        public GovernmentType Government { get; }
        public Dictionary<ResourceType, int> Resources { get; }
        public List<City> Cities { get; }

        public Country(string name, GovernmentType government)
        {
            Name = name;
            Government = government;
            Resources = new Dictionary<ResourceType, int>
        {
            { ResourceType.Money, 0 },
            { ResourceType.Food, 0 },
            { ResourceType.Happiness, 0 }
        };
            Cities = new List<City>();
        }

        public void AddCity(City city) => Cities.Add(city);

        public void MonthlyUpdate()
        {
            foreach (var city in Cities)
            {
                var cityResult = city.MonthlyUpdate();

                foreach (var res in cityResult)
                {
                    Resources[res.Key] += res.Value;
                }
            }

            if (Government == GovernmentType.Monarchy)
                Resources[ResourceType.Money] += Resources[ResourceType.Money] * 5 / 100;

            if (Government == GovernmentType.Dictatorship)
                Resources[ResourceType.Happiness] += 20;
        }

        internal void AddCity(City.City kyiv)
        {
            throw new NotImplementedException();
        }
    }

}
