namespace Module7
{
    public class Student : Person
    {
        public Student(string firstName = null, string lastName = null, int studentId = default) : base(firstName,
            lastName)
        {
            StudentId = studentId;
        }

        public int StudentId { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} {StudentId}";
        }
    }
}