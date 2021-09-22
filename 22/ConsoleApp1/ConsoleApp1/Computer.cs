using System;

namespace ConsoleApp1
{
    public class Computer
    {
        private string brand;
        public IUsb usb_1;
        public IUsb usb_2;

        public Computer(string brand)
        {
            this.brand = brand;
        }

        public void Start()
        {
            Console.WriteLine("{0}牌电脑正在开机...", brand);
        }

        public void End()
        {
            Console.WriteLine("{0}牌电脑正在关机...", brand);
        }
    }
}