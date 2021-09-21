using System;

namespace ConsoleApp1
{
    public class Zi : Fu, IBBB
    {
        public void World()
        {
            Console.WriteLine("我是子类方法.");
        }

        // public override void Hello()
        // {
        //     base.Hello();
        //     Console.WriteLine("hello");
        // }

        public override void Hello()
        {
            Console.WriteLine("hello");
        }

        public void B()
        {
            Console.WriteLine("B");
        }
    }
}