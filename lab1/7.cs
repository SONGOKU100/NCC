using System;

class Animal {
    public virtual void Sounds() {
        Console.WriteLine("sounds?.");
    }
}

class Dog : Animal {
    public override void Sounds() {
        Console.WriteLine("barks.");
    }
}

class Cat : Animal {
    public override void Sounds() {
        Console.WriteLine("meows.");
    }
}

class Program {
    static void Main(string[] args) {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.Sounds();
        myDog.Sounds();
        myCat.Sounds();
    }
}
