using System;

namespace ConsoleApp1
{
    public class Disk : IUsb
    {
        private string content;
        private string brand;

        public Disk(string brand)
        {
            this.brand = brand;
        }

        public void Write(string content)
        {
            this.content += content;
            Console.WriteLine("{0}牌硬盘写入: {1}", brand, content);
        }

        public void Read()
        {
            Console.WriteLine("{0}牌硬盘读取: {1}", brand, content);
        }
    }
}