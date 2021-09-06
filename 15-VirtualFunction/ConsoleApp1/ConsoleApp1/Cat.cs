using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cat:CatType
    {
        public override void Cry()
        {
            base.Cry();
            Console.WriteLine("cat cry");
        }
    }
}
