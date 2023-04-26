//1.Write a C# program to add two digit using delegates.
using System;

namespace Addition{
    delegate int Sum(int a, int b);
    class Delegate{
        public int add(int a, int b) {
            return a+b;
        }
    }

    class Testing{
        static void Main(string[] args){
            int a = 100, b = 500;
            
            Delegate m = new Delegate();
           
            Sum s = new Sum(m.add);
            
            int result = s(a,b);
            Console.WriteLine($"The sum of {a} and {b} is {result}");
        }
    }
}
