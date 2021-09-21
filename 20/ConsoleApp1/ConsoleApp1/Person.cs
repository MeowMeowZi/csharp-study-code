namespace ConsoleApp1
{
    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return "name is null or empty";
                }
                else
                {
                    return name;
                }
            }
            set { name = value; }
        }
        
        public int Age { get; set; }
    }
}