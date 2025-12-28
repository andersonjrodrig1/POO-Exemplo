using POO_Class_Triangulo_Example;
using System.Globalization;

var x = new Triangle();
var y = new Triangle();

Console.WriteLine("Informe as medidas do triangulo X: ");
x.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Informe as medidas do triangulo Y: ");
y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)} ");
Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)} ");

if (areaX > areaY)
    Console.WriteLine("Maior área: X");
else
    Console.WriteLine("Maior área: Y");