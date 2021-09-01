using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Hero
    {
        private string nickName;
        private string heroName;
        private string heroInfo;
        private float attack;
        private float defense;
        private float speed;

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
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
        public float Attack
        {
            get { return attack; }
            set { attack = value;  }
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

        public void Skll1()
        {
            Console.WriteLine("Skill1");
        }
        public void Skll2()
        {
            Console.WriteLine("Skill2");
        }
        public void Skll3()
        {
            Console.WriteLine("Skill3");
        }
    }
}
