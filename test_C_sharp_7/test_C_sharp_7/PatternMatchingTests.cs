using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_C_sharp_7
{
    static class PatternMatchingTests
    {
        public static void IsExpressionPatternTest(object testValue)
        {
            if (testValue is int number ||
                (testValue is string stringValue && int.TryParse(stringValue, out number)))
            {
                Console.WriteLine($"Number: {number}");
            }
            else
            {
                Console.WriteLine($"NaN: {testValue} ( {testValue.GetType()} )");
            }
        }



        public static void SwitchStatementsPatternTest(object testValue)
        {
            switch (testValue)
            {
                case int positiveNumber when positiveNumber < 0:
                    Console.WriteLine($"Negative number! { positiveNumber }");
                    return;

                case int negativeNumber:
                    Console.WriteLine($"Not negative number! { negativeNumber }");
                    return;

                case string stringValue:
                    Console.WriteLine($"It is string! { stringValue }");
                    return;

                default:
                    Console.WriteLine("<unknown type>");
                    return;

                case null:
                    Console.WriteLine("null");
                    return;

            }
        }
    }
}
