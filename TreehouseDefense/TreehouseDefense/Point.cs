using System;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + ", " + Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;
        }

        //Multiplying X by a prime number to make it as unqiue as possible
        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));           
        }

        //MapLocation location, int range
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
