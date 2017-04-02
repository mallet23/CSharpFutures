using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_C_sharp_7
{
    static class DeconstructionTests
    {
        class Point
        {
            private int X;
            private int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }

        public static void ClassDecontctructionTest()
        {
            Console.Write("Enter x: ");
            var myX = Console.ReadLine();
            Console.Write("Enter y: ");
            var myY = Console.ReadLine();

            Int32.TryParse(myX, out var x);
            Int32.TryParse(myY, out var y);

            var point = new Point(x, y);

            var (valX, valY) = point;

            Console.WriteLine($"x: { valX }, y: { valY }");
        }

        public static void DeconstructionDeclarationIndividualVariablesTest()
        {
            (string firstName, string lastName, string middleName) = TupleTests.Name;

            ShowName(firstName, lastName, middleName);
        }

        public static void DeconstructionCommonDeclarationTest()
        {
            var (firstName, lastName, middleName) = TupleTests.Name;

            ShowName(firstName, lastName, middleName);
        }

        public static void DeconstructionDeclarationWithExistingVariablesTest()
        {
            string firstName;
            string lastName;
            string middleName = "None";

            (firstName, lastName, _) = TupleTests.Name;

            ShowName(firstName, lastName, middleName);
        }

        private static void ShowName(string firstName, string lastName, string middleName)
        {
            Console.WriteLine($"{nameof(lastName)}: {lastName}");
            Console.WriteLine($"{nameof(firstName)}: {firstName}");
            Console.WriteLine($"{nameof(middleName)}: {middleName}");
        }
    }
}
