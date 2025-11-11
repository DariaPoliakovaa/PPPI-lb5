using System;

namespace CatProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Mittens", 3);
            
            myCat.Meow();
            myCat.Eat("fish");
            myCat.Sleep();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
