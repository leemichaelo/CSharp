using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location, Path path)
        {
            if (path.IsOnPath(location))
            {
                throw new TowerOnPathException(location.X + ", " + location.Y + " is on the path, towers cannot be placed on the path.");
            }
            else
            {
                _location = location;
            }
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            int index = 0;

            while (index < invaders.Length)
            {
                Invader invader = invaders[index];
                //Do stuff with invader

                index++;
            }
        }
    }
}
