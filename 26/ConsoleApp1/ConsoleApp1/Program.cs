using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Web("BiliBili", "www.bilibili.com");
            var w2 = new Web("百度", "www.baidu.com");
            
            w1.Show();
            w2.Show();

            var m1 = Meow.Instance();
            var m2 = Meow.Instance();
            Console.WriteLine(m1 == m2);
        }
    }
}