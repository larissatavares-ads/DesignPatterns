using Creational_AbstractFactory.Interfaces;

namespace Creational_AbstractFactory.Domain
{
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            throw new NotImplementedException();
        }

        public IAbstractProductB CreateProductB()
        {
            throw new NotImplementedException();
        }
    }
}
