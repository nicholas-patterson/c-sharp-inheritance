using System;
namespace inheritance
{
    public class Student : User
    {

        public Student(string firstName, string lastName ,int age) :base(firstName,lastName,age)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, I am  a student my name is {FirstName} {LastName} and I am {Age} years old !");
        }
    }
}
