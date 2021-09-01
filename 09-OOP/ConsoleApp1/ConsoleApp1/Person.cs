using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum Gender
    {
        boy,
        girl
    }

    /// <summary>
    /// Person类，描述人
    /// </summary>
    class Person
    {
        private string name;
        private int age;
        private Gender gender;
        private string address;

        public Person() { }

        public Person(string name, int age, Gender gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    age = -1;
                }
            }
        }        

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }        

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void Eat()
        {
            Console.WriteLine(Name + " can eat");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " can sleep");
        }

        public void Work()
        {
            Console.WriteLine(Name + " can work");
        }

        public void Hello()
        {
            Console.WriteLine("{0},{1},{2},{3}", Name, Age, Gender, Address);
        }
    }
}
