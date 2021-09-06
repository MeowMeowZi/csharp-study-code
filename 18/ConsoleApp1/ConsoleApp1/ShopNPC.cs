using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ShopNPC : NPC
    {
        private string item;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        public ShopNPC() { }

        public ShopNPC(string item, string name, NPCType type)
            : base(name, type)
        {
            this.item = item;
        }

        public override void Speak()
        {
            Console.WriteLine("NPC：{0}，商品：{1}", base.Name, Item);
        }
    }
}
