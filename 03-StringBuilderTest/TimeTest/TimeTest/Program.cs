using System;
using System.Text;
using System.Diagnostics;

namespace TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string str = "";
            for (int i = 0; i < 100000; i++)
            {
                str += i;
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                sb.Append(i);
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
