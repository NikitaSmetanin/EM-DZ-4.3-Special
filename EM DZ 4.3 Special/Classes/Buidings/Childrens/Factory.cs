using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Childrens
{
    class Factory : Building
    {
        public Factory() : base("Factory", 250) { }

        public override Dictionary<RecourceType, int> Produce()
        {
            return new Dictionary<RecourceType, int>
            {
                { RecourceType.money, 50 },
                { RecourceType.hapiness, -10 }
            };
        }
    }
}

