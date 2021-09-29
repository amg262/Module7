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

            // Console.WriteLine(myCustomer);
            // Student student = new Student("Jane", "Doe", 123);
            // Console.WriteLine(student.ToString());


            Television sony = new Television(true, 12, "Sony");
            Television lg = new Television(false, 2, "LG");
            Television vizio = new Television(true, 32, "Vizio");

            Console.WriteLine(sony.ToString());
            Console.WriteLine(lg.ToString());
            Console.WriteLine(vizio.ToString());


        }
    }
}