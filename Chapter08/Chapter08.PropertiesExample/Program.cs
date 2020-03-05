using System;


namespace Chapter08.PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestObject x = new TestObject();
            x.DataProp = 50;
            
            Console.WriteLine(x.DataProp);
            Console.ReadLine();
        }
    }
}
