using System;

namespace BooleanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x;
            x = (3 > 7);
            Console.WriteLine($"x >>>{x}");
            x = (9 > 7);
            Console.WriteLine($"x >>>{x}");
            Console.ReadLine();
        }
    }
}
