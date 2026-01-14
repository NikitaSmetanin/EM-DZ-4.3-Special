using System;
using EM_DZ4.Building;
using EM_DZ4;
using System.Collections.Generic;
using EM_DZ4.Building.Childrens;
using EM_DZ4.Country;
using EM_DZ4.Building.Chilrens;

namespace EM_DZ4.City {
    class City
    {
        public string Name { get; }
        public CitySize Size { get; }
        public int Population { get; private set; }
        public int Happiness { get; private set; }
        public int TaxLevel { get; }
        public List<Building> Buildings { get; }

        public City(string name, CitySize size, int population, int happiness, int taxLevel)
        {
            Name = name;
            Size = size;
            Population = population;
            Happiness = happiness;
            TaxLevel = taxLevel;
            Buildings = new List<Building>();
        }

        public bool AddBuilding(Building building)
        {
            if (Buildings.Count >= (int)Size)
                return false;

            Buildings.Add(building);
            return true;
        }

        public Dictionary<ResourceType, int> MonthlyUpdate()
        {
            Dictionary<ResourceType, int> result = new();

            if (Happiness <= 0)
                return result;

            int foodNeeded = Population / 1000;
            int moneyIncome = (Population / 1000) * 10 * TaxLevel / 100;

            result[ResourceType.Food] = -foodNeeded;
            result[ResourceType.Money] = moneyIncome;

            foreach (var building in Buildings)
            {
                foreach (var res in building.Produce())
                {
                    if (!result.ContainsKey(res.Key))
                        result[res.Key] = 0;

                    result[res.Key] += res.Value;

                    if (res.Key == ResourceType.Happiness)
                        Happiness += res.Value;
                }
            }

            if (Happiness > 50)
                Population += Population / 100;

            return result;
        }

        internal void AddBuilding(Mine mine)
        {
            throw new NotImplementedException();
        }

        internal void AddBuilding(Farm farm)
        {
            throw new NotImplementedException();
        }

        internal void AddBuilding(Theatre theatre)
        {
            throw new NotImplementedException();
        }
    }

}
