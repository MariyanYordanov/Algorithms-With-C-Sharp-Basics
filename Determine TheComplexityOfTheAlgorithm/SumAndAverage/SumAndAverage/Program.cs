using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> listNumbers = new List<int>();
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Sum=0; Average=0:00");
                return;
                // O(n) = 8;
            }
            else
            {
                int[] integerElements = input
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int i = 0; i < integerElements.Length; i++)
                {
                    listNumbers.Add(integerElements[i]);
                    sum += integerElements[i];
                }
            }
            
            Console.WriteLine($"Sum={sum}; Average={listNumbers.Average():f2}");
            // O(n) = 14 + 9*n;
        }
    }
}
