using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                Name = "Meow",
                Age = 17,
                Address = "ShangHai"
            };
            p.Hello();
        
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetType().ToString());

            Object m1;
            object m2;

            int a = 10;
            Console.WriteLine(a);
            object b = a;           // 装箱 -- 值类型->引用类型
            Console.WriteLine(b);
            a = (int) b;            // 拆箱 -- 引用类型->值类型
            Console.WriteLine(a);
            
        }
    }
}