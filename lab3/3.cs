using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var querry1 = from n in num
                      let sqrval = n * n
                      where sqrval > 10
                      select new { value=n, sqrval = n * n };
                      
        var querry2 = num.Where(x => x * x > 10).Select(x => new {val=x, sqrval = x * x });

        foreach(var s in querry1)
        {
            Console.WriteLine(s);
        }

        foreach(var i in querry2)
        {
            Console.WriteLine("{0},{1}",i.val,i.sqrval);
        }
    }
}
