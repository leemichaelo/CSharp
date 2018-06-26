using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;

        public SniperTower(MapLocation location) : base(location)
        {

        }
    }
}
