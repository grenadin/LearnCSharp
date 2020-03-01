using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08.StaticMemberExample
{
    class Toilet
    {
        public bool WaterSave { get; set; }
        public static int UnitPrice { get; set; }
        public int Total { get; set; }
        public int Unit { get; set; }

        public Toilet(bool waterSave)
        {
            Total = 0;
            this.WaterSave = waterSave;

        }

        public void Close()
        {
            Console.WriteLine($"Close Lid");
        }

        public void Open()
        {
            Console.WriteLine($"Open");
        }

        public void Flush()
        {
            Console.WriteLine($"Flush");
            if(WaterSave==true)
            {
                Calculate(5);
            }
        }

        private void Calculate(int v)
        {
            Total += v;
            Console.WriteLine($"Price of water now {Total*UnitPrice}");
            Unit += v;
        }

        
    }

}
