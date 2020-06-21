namespace _1._2.FactoryMethod
{
    public interface IProductA
    {
        string AnyProductAOperation();
    }
    public interface IProductB
    {
        string AnyProductBOperation();
    }

    class ConcreteProductA1 : IProductA
    {
        public string AnyProductAOperation()
        {
            return "Any Operation on ConcreteProductA1\n";
        }
    }
    class ConcreteProductA2 : IProductA
    {
        public string AnyProductAOperation()
        {
            return "Any Operation on ConcreteProductA2\n";
        }
    }

    class ConcreteProductB1 : IProductB
    {
        public string AnyProductBOperation()
        {
            return "Any Operation on ConcreteProductB1\n";
        }
    }
    class ConcreteProductB2 : IProductB
    {
        public string AnyProductBOperation()
        {
            return "Any Operation on ConcreteProductB2\n";
        }
    }
}
