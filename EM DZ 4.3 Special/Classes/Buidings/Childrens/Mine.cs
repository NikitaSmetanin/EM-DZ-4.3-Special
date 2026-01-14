using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Childrens
{
    class Mine : Building
    {
        public Mine(int id) : base(id, "Mine", 200) { }

        public override Dictionary<ResourceType, int> Produce()
        {
            return new Dictionary<ResourceType, int>
        {
            { ResourceType.Money, 40 },
            { ResourceType.Happiness, -10 }
        };
        }
    }
}