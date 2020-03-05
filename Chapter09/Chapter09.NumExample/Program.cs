using System;

namespace Chapter09.NumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Num a = new Num(7);
            Num b = new Num(5);
            Console.WriteLine(Num.FindMax(a,b).Data);
            Console.ReadLine();
            Console.WriteLine(Num.FindMax(new Num(7),new Num(5)).Data);
            Console.ReadLine();
        }
    }
}
