using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter01.InheritanceExample
{
    class IPod
    {
        bool isPlaying = false;
        public void Play() { }
        public void ShowMenu() => 
            Console.WriteLine($"Show Menu from Mother Class");
    }
}
