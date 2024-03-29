//1.Write a C# program using async and wait  for long process.

using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            SomeMethod();

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            //Thread.Sleep(TimeSpan.FromSeconds(5));
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n");
            Console.WriteLine("Some Method End");
        }
    }
}
