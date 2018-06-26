using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class SharpShooterTower : Tower
    {
        protected override double Accuracy { get; } = .99;

        public SharpShooterTower(MapLocation location) : base(location)
        {

        }
    }
}
