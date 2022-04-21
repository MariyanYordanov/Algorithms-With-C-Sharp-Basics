using System;
using System.Linq;

namespace BelongToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementToFind = int.Parse(Console.ReadLine());

            for (int i = 0; i < integerElements.Length; i++)
            {
                if (integerElements[i] == elementToFind)
                {
                    Console.WriteLine($"{ elementToFind } Exists in the List");
                    return;
                }
            }

            Console.WriteLine($"{elementToFind} Not exists in the List");
        }
    }
}
