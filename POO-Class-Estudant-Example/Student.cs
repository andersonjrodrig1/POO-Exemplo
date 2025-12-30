namespace POO_Class_Student_Example
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public double[] Notes { get; set; } = new double[3];

        public double FinalNote()
        {
            double notes = 0.0;

            foreach (var note in Notes)
                notes += note;

            return notes;
        }

        public double RemainderMissing(double average) => 60.00 - average;
    }
}
