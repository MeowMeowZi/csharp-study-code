using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskNPC n1 = new TaskNPC("挖两根萝卜", "小白兔", NPCType.Task);
            n1.Speak();
            ShopNPC n2 = new ShopNPC("铁剑", "剑人", NPCType.Shop);
            n2.Speak();
        }
    }
}
