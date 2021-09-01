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
        }
    }
}
