using System;

namespace ConsoleApp1
{
    public class Person
    {
        private string name;
        private int age;
        private string address;

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Hello()
        {
            Console.WriteLine($"{name}--{age}--{address}");
        }

        public override string ToString()
        {
            return $"{name}--{age}--{address}";
        }
    }
}