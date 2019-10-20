using System;

namespace inheritance
    // Base Class
{
    public abstract class User // Abstract class...Cannot make person out of User object. Cannot say User me = new User(); Users can only be made from Student and Teacher.
    {
       public string FirstName { get; } // Read only property that has private field (bts). Once used in Constructor user can not update.
       public string LastName { get; } // Same rules as above ^^
       public int Age { get; set; } // User can change their.

        protected User(string firstName, string lastName, int age) // Since class is abstract the construtor needs to be protected not public.
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        public abstract void SayHello(); // Abstract method. Method can be access from derived classes. 
       

    }
}
