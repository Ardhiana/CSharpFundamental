using System;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            Console.ReadKey();
           
        }
    }
}
