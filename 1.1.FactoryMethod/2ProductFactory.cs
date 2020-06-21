namespace _1._1.FactoryMethod
{
    public abstract class BaseCreator
    {
        public abstract IProduct FactoryMethod();
        public string Operation()
        {
            var product = FactoryMethod();
            var result = "BaseCreator | Factory method - You have Created Factory Method and " + product.AnyProductOperation();
            return result;
        }
    }

    class ConcreteCreator1 : BaseCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreator2 : BaseCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
