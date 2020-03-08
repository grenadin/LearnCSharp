using System;
using System.Collections.Generic;
using System.Text;


namespace Chapter11.ISwim
{
    class Dog : Animal,ISwim
    {
        public override void Say() => Console.WriteLine($"I'm Dog");

        public void Swim()
        {
            Console.WriteLine($"Dog Swim");
        }
    }
}
