using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacherOne = new Teacher("Luis", "Hernandez", 50, "Node.js");
            Teacher teacherTwo = new Teacher("Dustin", "Myers", 38, "React & Redux");
            Teacher teacherThree = new Teacher("Dan", "Levy", 45, "Fun Bus");



            Student studentOne = new Student("Nicholas", "Patterson", 22);
            Student studentTwo = new Student("Elvis", "Knapman", 33);
            Student studentThree = new Student("Jason", "Vorhees", 52);




            List<List<User>> users = new List<List<User>>()
            {
                new List<User> { teacherOne, teacherTwo,teacherThree},
                new List<User> {studentOne, studentTwo, studentThree}
                    
            };

            Console.WriteLine("Loop through nested list of students and teachers");

            foreach(List<User> lists in users.ToArray())
            {
                foreach(User user in lists)
                {
                    user.SayHello();
                }
            }

        }
    }
}
