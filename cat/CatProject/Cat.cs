using System;

namespace CatProject
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Meow(){
            Console.WriteLine($"{Name} says: Meow!");
        }

        public void Eat(string food){
        Console.WriteLine($"{Name} is eating{food}.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping now. Zzz...");
        }
    }
}
