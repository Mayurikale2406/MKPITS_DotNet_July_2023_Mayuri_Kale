using System;

namespace program
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter element " + i + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            int temp = 0;
            Console.WriteLine("Elements of array in sorted descending order:");

            // Bubble sort in descending order
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr1[i] < arr1[j])  // Check if the current element is smaller than the next one
                    {
                        // Swap elements
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }

            // Print sorted elements
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.ReadKey();
        }
    }
}
