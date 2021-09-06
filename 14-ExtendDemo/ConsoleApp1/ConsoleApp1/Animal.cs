using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Animal
    {
        private int leg;

        public int Leg
        {
            get { return leg; }
            set { leg = value; }
        }

        public void Walk()
        {
            Console.WriteLine("walk");
        }
        public void Eat()
        {
            Console.WriteLine("eat");
        }
        public void Sleep()
        {
            Console.WriteLine("sleep");
        }
        public void Cry()
        {
            Console.WriteLine("cry");
        }
    }
}
