using System;

namespace Chapter11.ISwim
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Human h = new Human();
            //ISwim ds = (ISwim)d;
            ISwim h1 = new Human();
            
            Pond p = new Pond();
            
            p.Welcome(h1);
            p.Welcome(d);
            Console.ReadLine();
        }
    }
}
