using System;

namespace ConsoleApp1
{
    public class HardDisk : IUsb
    {
        private string content;

        public void Read()
        {
            Console.WriteLine(content);
        }

        public void Write()
        {
            content = "MMZ";
        }
    }
}