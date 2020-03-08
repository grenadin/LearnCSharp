using System;


namespace Chapter10.AnimalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DogHouse dh = new DogHouse();
            Dog[] MyDog = new Dog[3];
            MyDog[0] = new StBernard();
            MyDog[1] = new ChowChow();
            Cat cat = new Cat();
            dh.Welcome(MyDog[0]);
            dh.Welcome(MyDog[1]);
            
            Console.ReadLine();
                
        }
    }
}
