using System;

namespace ConsoleApp1
{
    public class Person
    {
        #region 字段

        private string name;
        private int age;
        private string address;

        #endregion

        #region 属性

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        #endregion

        #region 构造方法

        // public Person(string name, int age, string address)
        // {
        //     this.name = name;
        //     this.age = age;
        //     this.address = address;
        // }

        #endregion

        #region 普通方法

        public void Hello()
        {
            Console.WriteLine($"{name}--{age}--{address}");
        }
        
        public override string ToString()
        {
            return $"{name}--{age}--{address}";
        }

        #endregion

    }
}