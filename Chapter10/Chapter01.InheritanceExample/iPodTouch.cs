using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter01.InheritanceExample
{
    class IPodTouch : IPod
    {
        public void ShowCoverFlowMenu() => 
            Console.WriteLine($"Show Cover Flow Menu");
        
        public new void ShowMenu() =>this.ShowCoverFlowMenu();
    }
}
