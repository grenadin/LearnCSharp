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
            MB2.changeMask("blue");
            Console.ReadLine();

        }
    }
}
