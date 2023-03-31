namespace ShapeTest.ShapeHelper
{
    public abstract class Shape
    {
        private readonly double area;
        public double GetArea => area;
        protected Shape(double area) => this.area = area;
        public override string ToString() =>
            $"Type: {this.GetType().Name}, Area = {area:F3}";
    }
}
