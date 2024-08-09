using Creational_FactoryMethod.Interfaces;

namespace Creational_FactoryMethod.Domain
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
