using System;

namespace CircleArea2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 7.001;
            double area;
            area = getCircleArea(r);
            Console.WriteLine(area);
            Console.ReadLine();
        }

        private static double getCircleArea(double radius)
        {
            double area;
            area = (22.0 / 7) * radius * radius;
            return area;
        }
    }
}
