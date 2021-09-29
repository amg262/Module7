using System;

namespace Module7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myCustomer = new Customer("Andrew", "Gunn", 1);

            // Pet pet = new Pet();
            // Dog dog = new Dog();
            //
            // Console.WriteLine(pet.Speak());
            // Console.WriteLine(dog.Speak());
            //
            // string course = "Intro to Programming in C#";

            // Console.WriteLine(myCustomer);
            // Student student = new Student("Jane", "Doe", 123);
            // Console.WriteLine(student.ToString());


            var sony = new Television(true, 12, "Sony");
            var lg = new Television(false, 2, "LG");
            var vizio = new Television(true, 32, "Vizio");

            Console.WriteLine(sony.ToString());
            Console.WriteLine(lg.ToString());
            Console.WriteLine(vizio.ToString());
        }
    }
}