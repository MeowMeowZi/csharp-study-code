using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.Cry();

            CatType ct = new Cat();
            ct.Cry();

            c1.Subclass();
            c1.Parentclass();

            ct.Parentclass();

            Cat c2 = (Cat)ct;
            c2.Subclass();
            c2.Parentclass();

            Console.WriteLine("--------------------");

            //bool isCat = ct is Cat;
            //bool isCat = c2 is CatType;
            //Console.WriteLine(isCat);

            if (ct as Cat == null)
            {
                Console.WriteLine("fail");
            }
            else
            {
                Console.WriteLine("success");
            }
        }
    }
}
