using System;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer("Andrew", "Gunn", 1);

            // Pet pet = new Pet();
            // Dog dog = new Dog();
            //
            // Console.WriteLine(pet.Speak());
            // Console.WriteLine(dog.Speak());
            //
            // string course = "Intro to Programming in C#";

            Console.WriteLine(myCustomer);
            Student student = new Student("Jane", "Doe", 123);
            Console.WriteLine(student.ToString());
            
        }
    }
}