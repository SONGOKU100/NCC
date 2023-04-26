//4. Write a C# program to print 1 to 10 using generic list.
using System.Collections.Generic;
using System;

class GenericList{
    static void Main(){
        List<int> numbers = new List<int>();

        for(int i=0; i<10; i++) {
            numbers.Add(i+1); 
        } 

        foreach(var num in numbers){
            Console.WriteLine($"{num}");
        }
    }
}
