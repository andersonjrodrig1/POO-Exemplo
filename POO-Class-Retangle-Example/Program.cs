using POO_Class_Retangle_Example;
using System.Globalization;

var rectangle = new Rectangle();

Console.WriteLine("Entre com a largura e altura do retangulo: ");
rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
rectangle.Height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

var area = rectangle.Area();
var perimeter  = rectangle.Perimeter();
var diagonal = rectangle.Diagonal();

Console.WriteLine($"AREA: {area.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERIMETRO: {perimeter.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");