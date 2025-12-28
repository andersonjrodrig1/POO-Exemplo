using POO_Class_Employee_Example;
using System.Globalization;

var employee1 = new Employee();
var employee2 = new Employee();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
employee1.Name = Console.ReadLine();
Console.Write("Salário: ");
employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
employee2.Name = Console.ReadLine();
Console.Write("Salário: ");
employee2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var average = (employee1.Salary + employee2.Salary) / 2.0;

Console.WriteLine($"Salário médio: {average.ToString("F2", CultureInfo.InvariantCulture)}");