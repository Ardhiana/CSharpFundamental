using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamdani";

            var fullName = firstName + "" + lastName;

            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Marry", "Asep" };

            var formattedNames = string.Join(",", names);

            var text = @"Hi John 
Look Into the Following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
