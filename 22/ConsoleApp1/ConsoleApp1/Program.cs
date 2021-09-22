using System;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new UDisk("金士顿32GB");
            var d2 = new HardDisk("三星500GB");
            
            var c1 = new Computer("联想");
            c1.Start();
            c1.usb_1 = d1;
            c1.usb_2 = d2;
            c1.usb_1.Write("MeowMeowZi");
            c1.usb_1.Read();
            c1.usb_1.Write(",say hello");
            c1.usb_1.Read();
            c1.usb_2.Write("test");
            c1.usb_2.Read();
            c1.End();

            var c2 = new Computer("戴尔");
            c2.Start();
            c2.End();
        }
    }
}