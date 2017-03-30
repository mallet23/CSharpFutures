using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_C_sharp_7
{
    static class OutVariablesTests
    {
        public static void OutVariablesTest()
        {
            string number = Console.ReadLine();

            if (int.TryParse(number, out var num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("NaN");
            }
        }

        public static void OutVariablesDiscardsTest()
        {
            string number = Console.ReadLine();

            if (int.TryParse(number, out _))
            {
                Console.WriteLine("Number!");
            }
            else
            {
                Console.WriteLine("NaN");
            }
        }
    }
}
