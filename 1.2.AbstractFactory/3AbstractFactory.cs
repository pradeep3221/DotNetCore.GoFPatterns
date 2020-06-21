using _1._2.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1._2.AbstractFactory
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

   class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

   class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
