using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaiLa h1 = new TaiLa("h1", "TaiLa", "hello", 80, 80, 50);
            AiLuoKe h2 = new AiLuoKe("h2", "AiLuoKe", "hello", 70, 70, 40);
            LuKaSi h3 = new LuKaSi("h3", "LuKaSi", "hello", 50, 60, 70);
            LuoFei h4 = new LuoFei("h4", "LuoFei", "hello", 10, 20, 30);

            h1.Skll1();
            h2.Skll2();
            h3.Skll3();
            h1.Hello();
            h2.Hello();
            h3.Hello();
            h4.Hello();
        }
    }
}
