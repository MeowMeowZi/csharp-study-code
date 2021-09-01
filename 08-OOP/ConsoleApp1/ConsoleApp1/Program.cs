using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a1 = new Apple();
            a1.color = Color.red;
            a1.weigth = 200;
            a1.shape = "circle";
            Console.WriteLine("{0},{1},{2}", a1.color, a1.weigth, a1.shape);

            Person p1 = new Person();
            p1.Name = "Meow";
            p1.Age = 21;
            p1.Gender = Gender.boy;
            p1.Address = "ShangHai";
            Console.WriteLine("{0},{1},{2},{3}", p1.Name, p1.Age, p1.Gender, p1.Address);
            p1.Eat();
            p1.Sleep();
            p1.Work();

            Person p2 = new Person("lfz", 21, Gender.girl, "BengBu");
            Console.WriteLine("{0},{1},{2},{3}", p2.Name, p2.Age, p2.Gender, p2.Address);
        }
    }
}
