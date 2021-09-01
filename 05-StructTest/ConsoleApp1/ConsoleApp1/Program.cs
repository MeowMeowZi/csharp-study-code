using System;

namespace ConsoleApp1
{
    public enum Gender
    {
        boy,
        gril
    }

    public struct Person
    {
        public string name;
        public int age;
        public Gender gender;
        public string address;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Meow";
            p1.gender = Gender.boy;
            p1.age = 21;
            p1.address = "杭州";

            Console.WriteLine(p1.name + p1.gender + p1.age + p1.address);
        }
    }
}
