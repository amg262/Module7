namespace Module7
{
    public class Rectangle
    {
        public Rectangle(double length = default, double width = default)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }
    }
}