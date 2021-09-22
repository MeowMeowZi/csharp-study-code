using System;

namespace ConsoleApp1
{
    public class Person
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Hello()
        {
            Console.WriteLine("我是父类中的Hello方法");
        }
        
    }
}