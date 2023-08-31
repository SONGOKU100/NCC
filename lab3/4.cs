using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        string text;
        Console.WriteLine("Enter a text:\n");
        text = Console.ReadLine();

        var querry1 = from s in text
                      group s by s into y
                      select y;

        

        foreach(var i in querry1)
        {
            Console.WriteLine($"Letter:{i.Key} Frequency:{i.Count()}");
        }


    }
}
