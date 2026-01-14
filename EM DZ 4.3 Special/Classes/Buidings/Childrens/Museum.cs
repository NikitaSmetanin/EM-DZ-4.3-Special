using System;
using EM_DZ4;
using EM_DZ4.Building;
using System.Collections.Generic;

namespace EM_DZ4.Building.Chilrens
{
    using System.Collections.Generic;

    namespace DZ4
    {
        class Museum : Building
        {
            public Museum() : base("Museum", 200) { }

            public override Dictionary<RecourceType, int> Produce()
            {
                return new Dictionary<RecourceType, int>
            {
                { RecourceType.hapiness, 40 }
            };
            }
        }
    }

}