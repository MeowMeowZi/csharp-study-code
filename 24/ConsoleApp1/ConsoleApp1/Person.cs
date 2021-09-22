namespace ConsoleApp1
{
    public class Person
    {
        public string name;
        public static string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static string Address
        {
            get { return address; }
            set { address = value; }
        }
         
    }
}