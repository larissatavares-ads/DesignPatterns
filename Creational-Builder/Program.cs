using Creational_Builder.Domain.Service;

var director = new Director();
var builder = new ConcreteBuilderHouse();

director.Builder = builder;

Console.WriteLine("Standard basic house:");
director.BuildMinimalHouse();
Console.WriteLine(builder.GetHouse().ListParts());

Console.WriteLine("Standard complete house:");
director.BuildCompleteHouse();
Console.WriteLine(builder.GetHouse().ListParts());

Console.WriteLine("Custom house:");
builder.BuildWall();
builder.BuildWindow();
Console.Write(builder.GetHouse().ListParts());