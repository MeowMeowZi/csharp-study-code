namespace ConsoleApp1
{
    public class Weapon
    {
        private int id;
        private string name;
        private int attack;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public Weapon(int id, string name, int attack)
        {
            this.id = id;
            this.name = name;
            this.attack = attack;
        }
        
        public override string ToString()
        {
            return $"id:{id} - name:{name} - attack:{attack}";
        }
    }
}