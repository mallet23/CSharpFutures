using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_C_sharp_7
{
    static class RefReturnsLocalsTests
    {
        private static ref T Find<T>(this T[] source, T value)
            where T: IComparable
        {
            if(source == null)
            {
                throw new NullReferenceException(nameof(source));
            }

            for (int i=0;i<source.Length; i++)
            {
                if(value.CompareTo(source[i]) == 0)
                {
                    return ref source[i];
                }
            }

            throw new IndexOutOfRangeException($"{nameof(value)} not found");
        }

        public static void ChangeArrayValueTest()
        {
            var array = new[] { 990, 2_000, 3_000_000, 49_099 };

            Console.WriteLine($"Old array: {string.Join(", ", array)}");

            ref int val = ref array.Find(2_000);

            val = 3_111;

            Console.WriteLine($"New array: {string.Join(", ", array)}");
        }
    }
}
