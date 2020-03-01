using System;

namespace Chapter08.StaticMemberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Toilet t1 = new Toilet(true);
            Toilet t2 = new Toilet(true);

            Toilet.UnitPrice = 12;
            t1.Flush();
            Console.WriteLine($"Total flush will use water {t1.Unit} unit");
            Console.WriteLine($"Unit of water is now {Toilet.UnitPrice}");
            Console.ReadLine();

            
            Toilet.UnitPrice= 15;
            t1.Flush();
            Console.WriteLine($"Total flush will use water {t1.Unit} unit");
            Console.WriteLine($"Unit of water is now {Toilet.UnitPrice}");
            Console.ReadLine();
            t2.Flush();
            Console.WriteLine($"Every flush will use water {t2.Unit} unit");
            Console.WriteLine($"Unit of water is now {Toilet.UnitPrice}");
            Console.ReadLine();


        }
    }
}
