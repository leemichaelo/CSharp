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
        protected virtual double Accuracy { get; } = .75;

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

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    invader.DecreaseHealth(Power);

                    if (invader.IsNeutralized)
                    {
                        Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}
