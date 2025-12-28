using POO_Class_Pessoa_Example;

var person1 = new Person();
var person2 = new Person();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
person1.Name = Console.ReadLine();
Console.Write("Idade: ");
person1.Age = Int32.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
person2.Name = Console.ReadLine();
Console.Write("Idade: ");
person2.Age = Int32.Parse(Console.ReadLine());

if (person1.Age > person2.Age)
    Console.WriteLine($"Pessoa mais velha: {person1.Name}");
else
    Console.WriteLine($"Pessoa mais velha: {person2.Name}");