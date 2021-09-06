using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ZiLei p = new ZiLei();
            //p.Hello();
            p.F();
            p.Z();

            // 不能实例化抽象类
            //FuLei f = new FuLei();
        }
    }
}
