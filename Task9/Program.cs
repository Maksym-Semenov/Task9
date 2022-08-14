using System;
using System.Collections.Generic;
using System.Linq;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integer = new int[] { -5, 6, -2, 12, 4, -8, 3, 7, -1, 9 };
            IEnumerable<int> enumerableNeg = integer.Where(x => x < 0);
            foreach (int x in enumerableNeg)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            IEnumerable<int> enumerablePos = integer.Where(x => x > 0);
            foreach (int x in enumerablePos)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            int elementMax = integer.Max();
            Console.WriteLine(elementMax);
            Console.WriteLine();

            int elementMin = integer.Min();
            Console.WriteLine(elementMin);
            Console.WriteLine();

            double averageValue = integer.Average();
            Console.WriteLine($"Average value = {averageValue}");
            int firstLargeElement = integer.Where(x => x < averageValue).Max();
            Console.WriteLine(firstLargeElement);

            IEnumerable<int> sortArray = integer.OrderBy(x => x);
            foreach (int x in sortArray)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}
