//5.Write a C# program for showing single, multiple, multilevel and hierarchical inheritance.
using System;

namespace Program
{
    //Single Inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    //Multiple Inheritance

    interface I1
    {
        void Method1();
    }

    interface I2
    {
        void Method2();
    }

    class MultipleInheritance : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 called.");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 called.");
        }
    }

    //Multilevel Inheritance

    class A
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA called.");
        }
    }

    class B : A
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB called.");
        }
    }

    class C: B
    {
        public void MethodC()
        {
            Console.WriteLine("MethodC called.");
        }
    }

    //Hierarchical Inheritance
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing  a rectangle.");
        }
    }

    class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawingg a circle");
        }
    }

    internal class Inheritance
    {
        static void Main()
        {
            //Single Inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            //Multiple Inheritance
            MultipleInheritance multiInheritance = new MultipleInheritance();
            multiInheritance.Method1();
            multiInheritance.Method2();

            //Multilevl Inheritance
            C c = new C();
            c.MethodA();
            c.MethodB();
            c.MethodC();

            //Hierarchical Inheritance
            Shape shape1 = new Rectangle();
            Shape shape2 = new Circle();
            shape1.Draw();
            shape2.Draw();


        }
    }
}
