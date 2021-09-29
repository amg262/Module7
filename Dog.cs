namespace Module7
{
    public class Dog : Pet
    {
        public override string Speak()
        {
            return "Ruff!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}