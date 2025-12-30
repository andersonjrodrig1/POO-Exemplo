using System.Globalization;

namespace POO_Class_Employee2_Example
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public double GrossSalary { get; set; }
        public double Tax { get; set; }

        public double SalarioLiquido() => GrossSalary - Tax;

        public void AumentarSalario(double porcentagem)
        {
            var valorPorcentagem = GrossSalary * porcentagem / 100;
            GrossSalary += valorPorcentagem;
        }

        public override string ToString() =>
            Name +
            ", $ " +
            SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

    }
}
