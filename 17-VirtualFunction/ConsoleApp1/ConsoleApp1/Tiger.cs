using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tiger:CatType
    {
        public override void Cry()
        {
            base.Cry();
            Console.WriteLine("tiger cry");
        }
    }
}
