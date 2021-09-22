using System;

namespace ConsoleApp1
{
    /// <summary>
    /// 静态类.
    /// </summary>
    public static class Meow
    {
        private static string name;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static void Hello()
        {
            Console.WriteLine("hello");
        }
    }
}