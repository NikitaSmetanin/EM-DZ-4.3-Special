using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Chilrens
{
    class Market : Building
    {
        public Market(int id) : base(id, "Market", 150) { }

        public override Dictionary<ResourceType, int> Produce()
        {
            return new Dictionary<ResourceType, int>
        {
            { ResourceType.Money, 20 }
        };
        }
    }
}
