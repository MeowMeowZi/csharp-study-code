using System;

namespace ConsoleApp1
{
    public class Meow : Person
    {
        public void World()
        {
            Console.WriteLine(base.Name);
            Console.WriteLine(base.name);
        }
    }
}