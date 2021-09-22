using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string name;
        public static string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void P1()
        {
            P2();
            Console.WriteLine("我是普通方法");;
        }

        public static void P2()
        {
            Console.WriteLine("我是静态方法");
        }

        static Person()
        {
            address = "AnHui";
        }
    }
}