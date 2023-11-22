using ConsoleIOLib;

namespace Lab9
{
    public class Triangle
    {

        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            InstanceCounter.Increase<Triangle>();
        }

        ~Triangle() { InstanceCounter.Decrease<Triangle>(); }

        public bool IsExists() => IsExists(this);

        public double CalculatePerimeter() => CalculatePerimeter(this);

        public double CalculateArea() => CalculateArea(this);

        public static bool IsExists(Triangle triangle) =>
            triangle. a + triangle.b > triangle.c 
            && triangle.a + triangle.c > triangle.b 
            && triangle.b + triangle.c > triangle.a;

        public static double CalculatePerimeter(Triangle triangle)
        {
            if (!IsExists(triangle))
            {
                return 0;
            }
            else
            {
                return (triangle.a + triangle.b + triangle.c) / 2;
            }
        }

        public static double CalculateArea(Triangle triangle)
        {
            if (!IsExists(triangle))
            {
                return 0;
            }
            else
            {
                double p = CalculatePerimeter(triangle);
                return Math.Sqrt(p * (p - triangle.a) * (p - triangle.b) * (p - triangle.c));
            }
        }

        public static implicit operator double(Triangle triangle) => triangle.CalculatePerimeter();

        public static explicit operator bool(Triangle triangle) => triangle.IsExists();

        public static bool operator >(Triangle a, Triangle b) => a.CalculateArea() < b.CalculateArea();

        public static bool operator <(Triangle a, Triangle b) => a.CalculateArea() > b.CalculateArea();

        public override string ToString() => string.Format(Messages.TriangleToString, a, b, c);

        public static Triangle CreateRandom(Random random) => new(
            random.NextDouble() * 100,
            random.NextDouble() * 100,
            random.NextDouble() * 100
        );

        public static Triangle Create() => new(
            ConsoleIO.Input<double>(Messages.InputTriangleA),
            ConsoleIO.Input<double>(Messages.InputTriangleB),
            ConsoleIO.Input<double>(Messages.InputTriangleC)
        );
    }
}