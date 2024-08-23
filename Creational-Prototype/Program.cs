using Creational_Prototype.Domain.Model;

Person person1 = new Person();
person1.Age = 26;
person1.BirthDate = Convert.ToDateTime("1997-01-01");
person1.Name = "John Marston";
person1.IdInfo = new IdInfo(3354);

// executando uma copia superficial de person1 para person2
Person person2 = person1.ShallowCopy();

// executando uma copia profunda de person1 para person3
Person person3 = person1.DeepCopy();

// Mostra os valores de person 1, 2 e 3
Console.WriteLine("Original values of p1, p2, p3:");
Console.WriteLine("   person1 instance values: ");
DisplayValues(person1);
Console.WriteLine("   person2 instance values:");
DisplayValues(person2);
Console.WriteLine("   person3 instance values:");
DisplayValues(person3);


// mudando os valores das propriedades de person1 e mostrando os valores de person 1, 2 e 3
person1.Age = 32;
person1.BirthDate = Convert.ToDateTime("1992-01-01");
person1.Name = "Arthur Morgan";
person1.IdInfo.IdNumber = 9984;

Console.WriteLine("\nValues of person1, person2 and person3 after changes to person1:");
Console.WriteLine("   person1 instance values: ");
DisplayValues(person1);
Console.WriteLine("   person2 instance values (reference values have changed):");
DisplayValues(person2);
Console.WriteLine("   person3 instance values (everything was kept the same):");
DisplayValues(person3);



static void DisplayValues(Person p)
{
    Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p.Name, p.Age, p.BirthDate);
    Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
}