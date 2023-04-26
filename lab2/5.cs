//5.Write a C# program to print CustomerId and CustomerName using Dictionary.
using System;
using System.Collections.Generic;

class Dictionary{
    static void Main(){
        Dictionary<int, string> customList = new Dictionary<int,string>();
        customList.Add(100,"Praful");
        customList.Add(101,"Bibek");
        customList.Add(102,"Rahul");
        customList.Add(103,"John");
        customList.Add(104,"Nihang");
		
       Console.WriteLine("\nCustomer's List: "); 
       foreach(KeyValuePair<int,string> customer in customList) {
            Console.WriteLine($"Id: {customer.Key}, Name: {customer.Value}");
       }
    }
}

