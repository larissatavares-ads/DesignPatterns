using Creational_FactoryMethod.Interfaces;

namespace Creational_FactoryMethod.Domain
{
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
