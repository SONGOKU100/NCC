using System;

namespace Lab1
{
    class AddTwoNum
    {
        private int a;
        private int b;

        public AddTwoNum(int c,int d)
        {
            a = c;
            b = d;
        }

        public int AddNum()
        {
            return a + b;
        }

    }

    class ProgramMain 
    { 
        static void Main()
        {
            int a = 19;
            int b = 21;
            AddTwoNum o = new AddTwoNum(a, b);
            int res = o.AddNum();

            Console.WriteLine($"The sum of {a} and {b} is {res}.");
        }
    }
}
