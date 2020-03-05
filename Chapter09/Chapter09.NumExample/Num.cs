using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter09.NumExample
{
    class Num
    {
        public Num(int data)
        {
            Data = data;
        }

        public int Data { get; set; }

        public static Num FindMax(Num x,Num y)
        {
            if (x.Data > y.Data)
                return x;
            else return y;
        }
    }
}
