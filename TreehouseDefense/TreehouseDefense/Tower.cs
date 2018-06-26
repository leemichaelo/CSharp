using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
    //power tower
    //sniper tower
    //long range tower
    //super tower
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get;  } = .75;

        private static readonly Random _random = new Random();


        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;

        }

        public bool isShotSuccessful()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    invader.DecreaseHealth(Power);
                    break;
                }
            }
        }
    }
}
