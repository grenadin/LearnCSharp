using System;

namespace FunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 9; b = 7;
            Console.WriteLine(sum(a,b));
            Console.WriteLine(sum(a,sum(sum(a,b),sum(a,b))));
            Console.ReadLine();

            int[] x = new int[5] { 6, 5, 1, 9, 2 };
            Console.WriteLine(ArrayMax(x,5));
            Console.ReadLine();

        }

        private static int ArrayMax(int[] x, int v)
        {
            int temp = x[0];
            for(int i = 1;i<v; i++)
            {
                if (x[i] > temp)
                    temp = x[i];
                Console.WriteLine(sum(5,7)); 
                
            }
            return temp;
        }

        private static int sum(int a, int b)
        {
            return a + b;
        }
    }


}
