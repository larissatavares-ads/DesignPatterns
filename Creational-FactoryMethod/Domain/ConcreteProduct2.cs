using Creational_FactoryMethod.Interfaces;

namespace Creational_FactoryMethod.Domain
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
