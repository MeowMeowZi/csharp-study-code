using System;

namespace ConsoleApp1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var zi = new Zi();
            zi.Hello();
            zi.World();
            zi.B();

            var a = "hello";
            Console.WriteLine(a);
            a = "world";
            Console.WriteLine(a);

            // Fu fu = new Fu();
            // fu.Hello();
        }
    }
}