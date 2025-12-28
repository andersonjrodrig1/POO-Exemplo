namespace POO_Class_Retangle_Example
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area() => Width * Height;

        public double Perimeter() => (Width + Height) * 2;

        public double Diagonal() => Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
    }
}
