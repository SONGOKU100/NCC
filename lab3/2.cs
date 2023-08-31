using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //string[] s = { "Hari", "RaM", "ShyAM" };
        string s1 = "Find ThE CaPItaL LEttER";
        var n1 = from str in s1
                 where char.IsUpper(str)
                select str;

         //var n1 = s1.Where(x => char.IsUpper(x)).Select(x => new {uppercase=x});

        Console.WriteLine(s1);

        foreach(var s in n1)
        {
            Console.WriteLine(s);
        }
    }
}
