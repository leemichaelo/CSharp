using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Map
    {
        //--**Attributes**--
        //readonly makes it so that they can't change the attribute
        public readonly int Width;
        public readonly int Height;

        //--**Behaviors**--
        //Constructor
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //Checks if the point is within bounds of the map
        public bool OnMap(Point point)
        { 
            return point.X >= 0 && point.X < Width && 
                   point.Y >= 0 && point.Y < Height;
        }
    }
}
