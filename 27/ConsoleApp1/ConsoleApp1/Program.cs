using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Hello();

            var w = new Person.Web
            {
                webName = "BiliBili",
                webUrl = "www.bilibili.com"
            };
            w.Show();

            var m = new {Name = "Meow", Age = 17};
            Console.WriteLine("{0}:{1}", m.Name, m.Age);
        }
    }
}