using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Childrens
{
    class Farm : Building
    {
        public Farm(int id) : base(id, "Farm", 100) { }

        public override Dictionary<ResourceType, int> Produce()
        {
            return new Dictionary<ResourceType, int>
        {
            { ResourceType.Food, 50 }
        };
        }
    }

}
