using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Childrens
{
    class Bank : Building
    {
        public Bank(int id) : base(id, "Bank", 300) { }

        public override Dictionary<ResourceType, int> Produce()
        {
            return new Dictionary<ResourceType, int>
        {
            { ResourceType.Money, 0 } 
        };
        }
    }

}