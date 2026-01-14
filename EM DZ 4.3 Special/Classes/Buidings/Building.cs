using System.Collections.Generic;
using EM_DZ4;

namespace EM_DZ4.Building
{
    abstract class Building
    {
        private static int autoInc = 1;

        public int Id { get; }
        public string Name { get; }
        public int Price { get; }

        protected Building(string name, int price)
        {
            Id = autoInc++;
            Name = name;
            Price = price;
        }

        public abstract Dictionary<RecourceType, int> Produce();
    }
}
