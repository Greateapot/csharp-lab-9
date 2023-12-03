namespace Lab9
{
    public class TriangleArray
    {
        private readonly Triangle[] triangles;

        public TriangleArray()
        {
            triangles = Array.Empty<Triangle>();
            InstanceCounter.Increase<TriangleArray>();
        }

        public TriangleArray(uint length)
        {
            triangles = new Triangle[length];
            InstanceCounter.Increase<TriangleArray>();
        }

        public TriangleArray(params Triangle[] triangles)
        {
            this.triangles = triangles;
            InstanceCounter.Increase<TriangleArray>();
        }

        ~TriangleArray() { InstanceCounter.Decrease<TriangleArray>(); }

        public int Length => triangles.Length;

        public Triangle this[int index]
        {
            get
            {
                return index >= 0 && index < triangles.Length
                    ? triangles[index]
                    : throw new ArgumentException(Messages.OutOfBoundsErrorMessage);
            }
            set
            {
                triangles[index] = index >= 0 && index < triangles.Length
                    ? value
                    : throw new ArgumentException(Messages.OutOfBoundsErrorMessage);
            }
        }

        public static TriangleArray CreateRandom(uint length, Random random)
        {
            var triangles = new TriangleArray(length);

            for (var index = 0; index < length; index++)
                triangles[index] = Triangle.CreateRandom(random);

            return triangles;
        }

        public static TriangleArray Create(uint length)
        {
            var triangles = new TriangleArray(new Triangle[length]);

            for (var index = 0; index < length; index++)
                triangles[index] = Triangle.Create();

            return triangles;
        }

        public override string ToString() => string.Format(Messages.TriangleArrayToString, string.Join<Triangle>(",\n\t", triangles));
    }
}