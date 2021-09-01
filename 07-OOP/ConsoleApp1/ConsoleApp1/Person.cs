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
        
        /*public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }*/
    }
}
