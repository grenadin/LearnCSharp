using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11.ISwim
{
    class Human : Animal,ISwim
    {
        public override void Say() => Console.WriteLine($"I'm Human");

        public void Swim()
        {
            Console.WriteLine($"Human Swim");
        }

        public Human()
        {

        }
       
    }
}
