using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_C_sharp_7
{
    static class LocalFunctionTests
    {
        private static IEnumerable<Tout> Execute<Tin, Tout>(this IEnumerable<Tin> source, Func<Tin, Tout> execute)
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (execute == null)
            {
                throw new ArgumentNullException(nameof(execute));
            }

            return Iterator();

            IEnumerable<Tout> Iterator()
            {
                foreach(var item in source)
                {
                    yield return execute(item);
                }
            }
        }

        public static void MultIndex(int coefficient)
        {
            var indexes = new [] { 0, 1, 2, 3, 4 };
            
            Console.WriteLine($"{nameof(indexes)}: {string.Join(", ", indexes)}, {nameof(coefficient)} : {coefficient}");

            var newIndexes = indexes.Execute(x => x * coefficient);

            Console.WriteLine($"{nameof(newIndexes)}: {string.Join(", ", newIndexes)}");
        }
    }
}
