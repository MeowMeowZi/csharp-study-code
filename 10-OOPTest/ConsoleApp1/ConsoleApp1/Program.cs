using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AiLuoKe h1 = new AiLuoKe("Meow");
            h1.Hello();
            h1.Skill1();
            h1.Skill2();
            h1.Skill3();
            TaiLa h2 = new TaiLa("lfz");
            h2.Hello();
            h2.Skill1();
            h2.Skill2();
            h2.Skill3();
        }
    }
}
