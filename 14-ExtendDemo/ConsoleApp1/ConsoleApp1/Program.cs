using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger t1 = new Tiger();
            t1.Leg = 4;
            t1.Walk();
            t1.Eat();
            t1.Sleep();
            t1.Cry();
            t1.YSNL();
            Console.WriteLine("------------------------------------");

            Cat t2 = new Cat();
            t2.Leg = 4;
            t2.Walk();
            t2.Eat();
            t2.Sleep();
            t2.Cry();
            t2.YSNL();
            Console.WriteLine("------------------------------------");

            Eagle t3 = new Eagle();
            t3.Leg = 2;
            t3.Walk();
            t3.Eat();
            t3.Sleep();
            t3.Cry();
            t3.Fly();
            Console.WriteLine("------------------------------------");

            Swallow t4 = new Swallow();
            t4.Leg = 2;
            t4.Walk();
            t4.Eat();
            t4.Sleep();
            t4.Cry();
            t4.Fly();
            t4.WangNanFei();
        }
    }
}
