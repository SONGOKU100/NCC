//4.Write a C# program how Name of Students are stored and retrieved using indexer.
using System;

namespace Program
{
    internal class Students
    {
        private string[] name = new string[5];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }

        }
    }
    internal class Indexer
    {
        static void Main()
        {
            Students students = new Students();

            students[0] = "John Doe";
            students[1] = "Sam Bankman";
            students[2] = "Martial Mathews";

            Console.WriteLine(students[0]); 
            Console.WriteLine(students[1]); 
            Console.WriteLine(students[2]); 
        }
    }
}
