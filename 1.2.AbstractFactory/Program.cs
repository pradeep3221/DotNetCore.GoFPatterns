using System;

namespace _1._2.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstact Factory sample code");
            Client.CreateAbstFactory(new ConcreteFactory1());
            Client.CreateAbstFactory(new ConcreteFactory2());
            Console.ReadKey();
        }
    }
}
