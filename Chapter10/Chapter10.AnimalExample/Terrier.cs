using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10.AnimalExample
{
    class Terrier : Dog
    {
        public override void Say()
        {
            Console.WriteLine($"Terrier");
        }
    }
}
