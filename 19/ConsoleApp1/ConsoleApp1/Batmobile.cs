using System;

namespace ConsoleApp1
{
    /// <summary>
    /// 蝙蝠侠战车
    /// </summary>
    public class Batmobile : Car, IFly
    {
        public Batmobile(string brand) : base(brand)
        {
            
        }

        public void Fly()
        {
            Console.WriteLine("{0} is fly.", base.Brand);
        }
    }
}