using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_C_sharp_7
{
    static class DeconstructionTests
    {
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
            string middleName;

            (firstName, lastName, middleName) = TupleTests.Name;

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
