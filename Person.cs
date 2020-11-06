using System;

namespace my_csharp
{

    class Person
    {
        string firstName;
        string lastName;
        DateTime dob;

        public Person()
        {
            firstName = "Jon";
            lastName = "Doe";
            dob = new DateTime();
        }

        public void sayHi()
        {
            Console.WriteLine("Hellooo from Person1");
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
    }
}





