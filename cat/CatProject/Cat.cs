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

        public void Meow(){}

        public void Eat(string food){}

        public void Sleep(){}
    }
}
