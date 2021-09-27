namespace ConsoleApp1
{
    /// <summary>
    /// 实体类.
    /// </summary>
    public class User
    {
        private string name;
        private int age;
        private string address;

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

        public User()
        {
            
        }

        public User(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public override string ToString()
        {
            return $"{name} | {age} | {address}";
        }
    }
}