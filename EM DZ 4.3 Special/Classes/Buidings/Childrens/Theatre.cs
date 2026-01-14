using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Chilrens
{
    class Theatre : Building
    {
        public Theatre(int v) : base("Theatre", 150) { }

        public override Dictionary<RecourceType, int> Produce()
        {
            return new Dictionary<RecourceType, int>
            {
                { RecourceType.hapiness, 20 }
            };
        }
    }
}

