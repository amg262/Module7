namespace Module7
{
    public class Customer : Person
    {
        public int AccountNumber { get; set; }

        public Customer(string firstName = null, string lastName = null, int accountNumber = default) : base(firstName,
            lastName)
        {
            AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $" {base.ToString()} {AccountNumber}";
        }
    }
}