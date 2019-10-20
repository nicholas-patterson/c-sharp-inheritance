using System;
namespace inheritance
{
    public class Teacher : User // Teacher is derived from User
    {

        public string Course { get; set;} // Giving Teacher an extra property... just to test it out. So Teacher has one extra prop a course.


        public Teacher(string firstName, string lastName, int age, string course) : base(firstName, lastName, age) // everything comes from User except course base is the user parameters...they also need to be directly in the teacher constructor also
        {
            Course = course;
        }

        public override void SayHello() // Override the abstract method from the User class to make it specific for the teacher.
        {
            Console.WriteLine($"Hi, Im a teacher and my name is {FirstName} {LastName} and I am {Age} years old, I teach {Course}");   
        }
    }
}


// Same thing for the Student class :)..