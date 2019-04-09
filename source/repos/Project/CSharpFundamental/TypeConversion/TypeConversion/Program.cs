
using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }

            catch (Exception)
            {
                Console.WriteLine("The Number  Could not be Converted to a byte ");
            }
        }
    }
}
