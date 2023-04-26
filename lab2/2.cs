//2.Write a C# program to Add, Subtract, Multiply, Divide using OOP.

using System;
class Maths
{
    public void add(double a, double b){
        double sum = a + b;
        Console.WriteLine($"Addition: {a} + {b} = {sum}");
    }
    public void subtract(double a, double b){
        double diff = a - b;
        Console.WriteLine($"Subtraction: {a} - {b} = {diff}");
    }
    public void multiply(double a, double b){
        double mul = a * b;
        Console.WriteLine($"Multiplication: {a} * {b} = {mul}");
    }
    public void divide(double a, double b){
        double div = a / b;
        Console.WriteLine($"Division: {a} / {b} = {div}");
    }
}
class Operation{
    static void Main(string[] args){
        Maths m1 = new Maths();
        m1.add(98,32);
        m1.subtract(2,70);
        m1.multiply(5,5);
        m1.divide(100,10);
    }
}
