namespace ConsoleApp1
{
    public class Meow
    {
        private static Meow _instance;

        private Meow()
        {
            
        }

        public static Meow Instance()
        {
            return _instance ??= new Meow();
        }
    }
}