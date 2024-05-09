using System.Runtime.InteropServices;

namespace Assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            point1.x = 5.5;
            point2.x = 5.5;

            if (point1.x == point2.x) 
            {
                Console.WriteLine("Points are on the same axis");
            }
            else 
            { 
                Console.WriteLine("Points are not on same axis");
            }
        }
        
    }
    struct Point
    {
        public double x;
        public double y;

    }
}
