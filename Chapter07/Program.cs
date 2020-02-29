using System;

namespace Chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.name = "HARIRAK";
            me.surname = "SRITHAM";
            Person.GenderP a = Person.GenderP.male;
            Console.WriteLine(a);
            Console.ReadLine();
            
        }
    }
}
