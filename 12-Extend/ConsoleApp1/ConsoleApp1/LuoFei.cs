using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LuoFei: Hero
    {
        public LuoFei() { }
        public LuoFei(string m_nickName, string m_heroName, string m_heroInfo, float m_attack, float m_defense, float m_speed)
            : base(m_nickName, m_heroName, m_heroInfo, m_attack, m_defense, m_speed)
        {

        }
    }
}
