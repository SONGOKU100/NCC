using System;
using System.Linq;

namespace lab3
{
    public class CountAndSquare
    {

        public static void calculate(int[] nums)
        {
            //number of elements in the array
            int count = nums.Length;

            //LINQ to find the square of each element in the array
            var squares = from n in nums
                          select n * n;

            Console.WriteLine($"Given array:");
            foreach (var n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n=========================");

            //results
            Console.WriteLine($"> Number of elements in the array: {count}");

            Console.WriteLine($"> Square of each element in the array:");
            foreach (var square in squares)
            {
                Console.Write("   " + square);
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5 };

            CountAndSquare.calculate(numbers);
        }

    }
}
