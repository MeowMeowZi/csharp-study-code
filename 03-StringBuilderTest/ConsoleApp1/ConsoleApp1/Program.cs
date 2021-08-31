using System;
using System.Text;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            StringBuilder sb = new StringBuilder();
            sb.Append("Meow");
            sb.Append(21);
            sb.Append(true);
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());

            sb.Clear();
            Console.WriteLine(sb.ToString());

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
