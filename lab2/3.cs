//3. Write a C# program to Add, Subtract, Multiply, Divide using Interface.
using System;

interface Operations{
    public void add(double a, double b);
    public void subtract(double a, double b);
    public void multiply(double a, double b);
    public void divide(double a, double b);
}

class Op : Operations {
    public void add(double a, double b) {
        double sum = a+b;
        Console.WriteLine($"Addition: {a} + {b} = {sum}");

    }
    
    public void subtract(double a, double b) {
        double sub = a-b;
        Console.WriteLine($"Subtraction: {a} - {b} = {sub}");
    }
    public void multiply(double a, double b) {
        double product = a*b;
        Console.WriteLine($"Multiplication: {a} * {b} = {product}");
    }
    public void divide(double a, double b) {
        double div = a/b;
        Console.WriteLine($"Division: {a} / {b} = {div}");

    }
}

class Calc{
    static void Main(){
        Op o1 = new Op();
        o1.add(98,32);
        o1.subtract(2,70);
        o1.multiply(5,5);
        o1.divide(100,10);
    }
}
