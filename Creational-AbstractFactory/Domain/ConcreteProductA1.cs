using Creational_AbstractFactory.Interfaces;

namespace Creational_AbstractFactory.Domain
{
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1";
        }
    }
}
