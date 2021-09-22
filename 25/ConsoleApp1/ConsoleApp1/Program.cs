using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person.address = "ShangHai";
            
            var p1 = new Person();
            p1.name = "Meow";
            Console.WriteLine(p1.name + "--" + Person.address + "--" + p1.Name + "--" + Person.Address);
            p1.P1();
            Person.P2();
            
            var p2 = new Person();
            p2.name = "MeowMeowZi";
            Console.WriteLine(p2.name + "--" + Person.address + "--" + p2.Name + "--" + Person.Address);

            Meow.Name = "MeowMeowZi";
            Console.WriteLine(Meow.Name);
            Meow.Hello();
        }
    }
}