using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            Console.WriteLine("Length :" + numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 : " + index);

            Array.Clear(numbers, 0,2);

            Console.WriteLine("Effect The Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
