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
            if(testValue is int number)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine($"NaN: {testValue} ( {testValue.GetType()} )");
            }
        }
    }
}
