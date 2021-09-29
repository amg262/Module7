namespace Module7
{
    public class Cube : Rectangle
    {
        public Cube(double length = default, double width = default, double height = default) : base(length, width)
        {
            Height = height;
        }

        public double Height { get; set; }
    }
}