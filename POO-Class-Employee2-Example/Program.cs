using POO_Class_Employee2_Example;
using System.Globalization;

var employee = new Employee();

Console.Write("Nome: ");
employee.Name = Console.ReadLine();
Console.Write("Salário Bruto: ");
employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"\nFuncionário: {employee}");

Console.Write($"\nDigite a porcentagem para aumentar o salário: ");
var porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

employee.AumentarSalario(porcentagem);

Console.WriteLine($"\nDados atualizados: {employee}");