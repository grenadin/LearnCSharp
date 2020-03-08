using System;

namespace Chapter01.InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPod myiPod = new IPod();
            IPodTouch youriPod = new IPodTouch();

            youriPod.Play();
            youriPod.ShowCoverFlowMenu();
            myiPod.ShowMenu();
            youriPod.ShowMenu();
            
            
            Console.WriteLine("End");
        }
    }
}
