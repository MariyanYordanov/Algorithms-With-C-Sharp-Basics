using System;
using System.Linq;

namespace SearchInOrderArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < integerElements.Length; i++)
            {
                if (number == integerElements[i])
                {
                    Console.WriteLine($"{number} Exists in the List");
                    return;
                }
            }

            Console.WriteLine($"{number} Not exists in the List");
            // O(n) = 11 + 8*n
        }
    }
}
