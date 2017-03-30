using System;

namespace test_C_sharp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            OutVariablesDiscardsTest();

            OutVariablesTest();
        }

        private static void OutVariablesTest()
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

        private static void OutVariablesDiscardsTest()
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
