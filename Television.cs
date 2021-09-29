namespace Module7
{
    public class Television
    {
        public bool IsOn { get; set; }
        public double Channel { get; set; }
        public string Manufacturer { get; set; }

        public Television(bool isOn = default, double channel = default, string manufacturer = null)
        {
            IsOn = isOn;
            Channel = channel;
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return $"The {Manufacturer} is tuned to {Channel} and currently: {IsOn}";
        }
    }
}