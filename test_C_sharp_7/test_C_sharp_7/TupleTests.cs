using System;

namespace test_C_sharp_7
{
    static class TupleTests
    {
        private static (string firstName, string lastName, string middleName) Name
        {
            get
            {
                return (firstName: "FirstName", lastName: "LastName", middleName: "MiddleName");
            }
        }

        private static (string firstName, string lastName, string middleName) NameWithWrongPosition
        {
            get
            {
                // "middleName:" and "firstName:" will be ignore
                return (middleName: "MiddleName", lastName: "LastName", firstName: "FirstName");
            }
        }

        public static void ShowName()
        {
            var fullName = Name;

            Console.WriteLine($"{ fullName }");

            Console.WriteLine($"{nameof(fullName.lastName)}: {fullName.lastName}");
            Console.WriteLine($"{nameof(fullName.firstName)}: {fullName.firstName}");
            Console.WriteLine($"{nameof(fullName.middleName)}: {fullName.middleName}");
        }
    }
}
