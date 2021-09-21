using System;

namespace ConsoleApp1
{
    /// <summary>
    /// 汽车的父类
    /// </summary>
    public class Car
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        protected Car()
        {
            
        }

        public Car(string brand)
        {
            this.brand = brand;
        }

        public void Run()
        {
            Console.WriteLine("{0} is run.", brand);
        }
    }
}