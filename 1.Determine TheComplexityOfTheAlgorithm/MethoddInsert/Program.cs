using System;
using System.Linq;

namespace MethodInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementToAdd = int.Parse(Console.ReadLine());

            int[] newArray = new int[integerElements.Length + 1];

            int indexToAdd = 0;

            for (int i = 0; i < integerElements.Length; i++)
            {
                if (integerElements[i] >= elementToAdd)
                {
                    indexToAdd = i + 1;
                    newArray[i] = elementToAdd;
                    break;
                }

                newArray[i] = integerElements[i];
            }

            for (int i = indexToAdd; i < newArray.Length; i++)
            {
                newArray[i] = integerElements[i - 1];
            }

            // O(n) = 12 + 12*n + 6*n
            Console.WriteLine($"New array -> {string.Join(", ", newArray)}");
            Console.WriteLine($"Old array -> {string.Join(", ", integerElements)}");
        }
    }
}
