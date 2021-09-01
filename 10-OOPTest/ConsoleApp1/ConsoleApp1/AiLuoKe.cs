using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AiLuoKe
    {
        private string heroName;
        private string heroInfo;
        private string nickName;
        private float attack;
        private float defense;
        private float speed;

        public AiLuoKe(String nickName)
        {
            this.nickName = nickName;
            this.heroName = "AiLuoKe";
            this.heroInfo = "hi";
            this.attack = 80;
            this.defense = 80;
            this.speed = 40;
        }

        public string HeroName
        {
            get { return heroName; }
            set { heroName = value; }
        }
        public string HeroInfo
        {
            get { return heroInfo; }
            set { heroInfo = value; }
        }
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public float Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public float Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public void Skill1()
        {
            Console.WriteLine("Skill1");
        }
        public void Skill2()
        {
            Console.WriteLine("Skill2");
        }
        public void Skill3()
        {
            Console.WriteLine("Skill3");
        }
        public void Hello()
        {
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", NickName, HeroName, HeroInfo, Attack, Defense, Speed);
        }
    }
}
