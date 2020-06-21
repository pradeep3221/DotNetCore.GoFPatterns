using System;

namespace _1._2.AbstractFactory
{
    public static class Client
{
    public static void CreateAbstFactory(IAbstractFactory aFactory)
    {
        var productA = aFactory.CreateProductA();
        var productB = aFactory.CreateProductB();
        Console.WriteLine(productA.AnyProductAOperation() + productB.AnyProductBOperation());
    }
}
}
