using System;

namespace _1._1.FactoryMethod
{
    public static class Client
    {
        public static void CreateFactory(BaseCreator creator)
        {
            Console.WriteLine("Client performs product operations" + "\n" + creator.Operation());
        }
    }
}
