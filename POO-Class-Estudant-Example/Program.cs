using POO_Class_Student_Example;
using System.Globalization;

var student = new Student();

Console.Write("Nome do aluno: ");
student.Name = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");

for (var i = 0; i < student.Notes.Length; i++)
    student.Notes[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var finalNote = student.FinalNote();

Console.WriteLine($"NOTA FINAL = {finalNote.ToString("F2", CultureInfo.InvariantCulture)}");

if (finalNote >= 60)
    Console.WriteLine("APROVADO");
else
{
    var remainderPoints = student.RemainderMissing(finalNote);

    Console.WriteLine("REPROVADO");
    Console.WriteLine($"FALTARAM {remainderPoints.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
}