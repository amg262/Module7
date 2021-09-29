namespace Module7
{
    public class Customer : Person
    {
        public Customer(string firstName = null, string lastName = null, int accountNumber = default) : base(firstName,
            lastName)
        {
            AccountNumber = accountNumber;
        }

        public int AccountNumber { get; set; }

        public override string ToString()
        {
            return $" {base.ToString()} {AccountNumber}";
        }
    }
}