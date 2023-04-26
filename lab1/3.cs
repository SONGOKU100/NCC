//3.Write a C# program to reverse element of an array.
using System;

namespace Program
{
    internal class Reverse
    {
        static void Main()
        {
            int[] arr = { 4, 9, 22, 11, 3, 999, 369, 67 };
            Console.WriteLine("Before Reverse");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            int n = arr.Length;
            for(int i  = 0; i < n/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }

            Console.WriteLine("\nAfter Reverse");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
