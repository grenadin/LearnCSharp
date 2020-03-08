using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10.AnimalExample
{
    class Dog:Animal
    {
        public  override void Say() => Console.WriteLine($"I'm Dog");
    }
}
