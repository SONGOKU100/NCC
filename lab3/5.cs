using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] city = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEWDELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
        char start;
        char end;
        Console.WriteLine("Enter the starting and ending letter");
        start = Console.ReadLine()[0];
        end = Console.ReadLine()[0];

        var query = from s in city
                    where s.StartsWith(start)
                    where s.EndsWith(end)
                    select s;

        if (query.Any())
        {
            foreach (var x in query)
            {
                Console.WriteLine(x);
            }
        }
        else
        {
			Console.WriteLine("\n");
            Console.WriteLine("No cities found matching the criteria.");
        }
    }
}

