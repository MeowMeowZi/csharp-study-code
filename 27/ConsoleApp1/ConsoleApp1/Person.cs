using System;

namespace ConsoleApp1
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Hello()
        {
            Console.WriteLine("hello");
        }

        public class Web
        {
            public string webName;
            public string webUrl;

            public void Show()
            {
                Console.WriteLine("{0}:{1}", webName, webUrl);
            }
        }
    }
}