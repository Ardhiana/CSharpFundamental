using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow3
{
    partial class Program
    {


        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Aku Pulang");
                    break;

                case Season.Summer:
                    Console.WriteLine("Pulang Ke Jonggol");
                    break;

                default:
                    Console.WriteLine("Aku Pulang");
                    break;
            }
        }


    }
}
