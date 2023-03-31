namespace ShapeTest.ShapeHelper
{
    public class Circle : Shape
    {
        public Circle(double r) : base(Math.PI * r * r)
        {
            if (r <= 0.0)
                throw new ArgumentException("Provided radius is not a positive double");
        }
    }
}
