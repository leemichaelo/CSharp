using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class PowerTower : Tower
    {
        protected override int Range { get; } = 2;

        public PowerTower(MapLocation location) : base(location)
        {

        }
    }
}
