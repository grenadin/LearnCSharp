using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10.AnimalExample
{
    class Cat : Animal
    {
        public override void Say() => Console.WriteLine($"I'm Cat");
        
    }
}
