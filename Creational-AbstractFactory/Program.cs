using Creational_AbstractFactory.Domain.Factory;
using Creational_AbstractFactory.Interfaces;

Console.WriteLine("Client: Testing client code with the first factory type...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the second factory type...");
ClientMethod(new ConcreteFactory2());


void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();

    Console.WriteLine(productB.UsefulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
}