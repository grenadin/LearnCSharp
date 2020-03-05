using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08.StaticMemberExample
{
    class Toilet
    {
        public bool WaterSave { get; set; }

        private static int unitPrice;

        public static int GetUnitPrice()
        {
            return UnitPrice;
        }

        public static void SetUnitPrice(int value)
        {
            UnitPrice = value;
        }

        public int Total { get; set; }
        public int Unit { get; set; }
        public static int UnitPrice { get => unitPrice; set => unitPrice = value; }

        public Toilet(bool waterSave)
        {
            Total = 0;
            this.WaterSave = waterSave;

        }

        public static void Close()
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
            Console.WriteLine($"Price of water now {Total* GetUnitPrice()}");
            Unit += v;
        }

        static Toilet()
        {
            Console.WriteLine($"start now");
        }

        
    }

}
