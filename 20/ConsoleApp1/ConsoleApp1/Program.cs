using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person p1 = new Person();
            Console.WriteLine(p1.Name);
            p1.Name = "MeowMeowZi";
            Console.WriteLine(p1.Name);
            p1.Age = 18;
            Console.WriteLine(p1.Age);*/

            UDisk u = new UDisk();
            u.Write();
            u.Read();

            HardDisk h = new HardDisk();
            h.Write();
            h.Read();
        }
    }
}