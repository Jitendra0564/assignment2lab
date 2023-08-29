using System;

namespace class_animal
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Dog says Woof!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Cat says Meow!");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching the furniture.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 3);
            Cat cat = new Cat("Whiskers", 2);

            Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}");
            dog.MakeSound();
            dog.Fetch();

            Console.WriteLine();

            Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}");
            cat.MakeSound();
            cat.Scratch();
            Console.Read();
        }
    }
}
