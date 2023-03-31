namespace ShapeTest.ShapeHelper
{
    public class Triangle : Shape
    {
        readonly double[] Sides;

        public Triangle(double a, double b, double c) : base
            (Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Provided side length is not a positive double");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Provided sides do not form a triangle");

            Sides = new double[3] { a, b, c };
        }

        public bool IsRight(double eps = 1E-6)
        {
            Array.Sort(Sides);
            /// You can see the formula <see href="https://www.mathopenref.com/pythagorastheorem.html">here</see>.
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) <= eps;
        }
    }
}
