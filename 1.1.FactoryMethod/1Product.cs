namespace _1._1.FactoryMethod
{
    public interface IProduct
    {
        string AnyProductOperation();
    }

    class ConcreteProductA : IProduct
    {
        public string AnyProductOperation()
        {
            return "Any Operation on ConcreteProductA\n";
        }
    }

    class ConcreteProductB : IProduct
    {
        public string AnyProductOperation()
        {
            return "Any Operation on ConcreteProductB\n";
        }
    }
}
