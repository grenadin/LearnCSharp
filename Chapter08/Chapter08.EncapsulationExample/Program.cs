using System;

namespace Chapter08.EncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone MB1 = new NokiaPhone("8250", "silver", true);

            NokiaPhone MB2 = new NokiaPhone("8888", "black");

            MB1.changeMask("blue");
            Console.WriteLine(MB1.getModel());
            MB2.changeMask("blue");
            Console.WriteLine(MB2.getModel());

            Console.ReadLine();

        }
    }
}
