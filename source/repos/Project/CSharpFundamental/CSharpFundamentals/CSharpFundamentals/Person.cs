using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void introduce()
        {
            Console.WriteLine("My Name is " + FirstName, " " + LastName);
        }
    }
}
