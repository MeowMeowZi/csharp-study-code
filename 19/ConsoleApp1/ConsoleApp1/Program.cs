using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BMWCar b1 = new BMWCar("宝马750");
            b1.Run();

            BMWCar b2 = new BMWCar("宝马740");
            b2.Run();

            Batmobile b3 = new Batmobile("蝙蝠侠战车");
            b3.Run();
            b3.Fly();
        }
    }
}