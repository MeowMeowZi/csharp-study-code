using System;

namespace ConsoleApp1
{
    public class UDisk : IUsb
    {
        /// <summary>
        /// U盘本身存储空间
        /// </summary>
        private string content;


        public void Read()
        {
            Console.WriteLine(content);
        }

        public void Write()
        {
            content = "MeowMeowZi";
        }
    }
}