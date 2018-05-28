using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Invader
    {
        private MapLocation _location;

        //Getter
        public MapLocation GetLocation()
        {
            return _location;
        }

        //Setter
        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
    }
}
