using System;

namespace _1._1.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Sample code\n");
            Client.CreateFactory(new ConcreteCreator1());
            Client.CreateFactory(new ConcreteCreator2());
            Console.ReadKey();
        }
    }
}
