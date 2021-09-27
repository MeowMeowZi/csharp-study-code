using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化int类型集合.
            var num = new List<int>();

            // 添加数据.
            num.Add(5);
            num.Add(15);
            num.Add(25);
            num.Add(35);
            
            // 读取数据.
            // Console.WriteLine(num[2]);
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
            
            // 删除数据.
            Console.WriteLine("--------------------");
            num.RemoveAt(2);
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
            
            // 修改数据.
            Console.WriteLine("--------------------");
            num[2] = 100;
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}