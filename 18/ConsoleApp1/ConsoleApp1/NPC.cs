using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// NPC枚举类.
    /// </summary>
    enum NPCType
    {
        /// <summary>
        /// 任务类.
        /// </summary>
        Task,
        /// <summary>
        /// 商贩类.
        /// </summary>
        Shop
    }

    /// <summary>
    /// NPC父类.
    /// </summary>
    abstract class NPC
    {
        private string name;
        private NPCType type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public NPCType Type
        {
            get { return type; }
            set { type = value; }
        }

        public NPC() { }

        public NPC(string m_name, NPCType m_type)
        {
            this.name = m_name;
            this.type = m_type;
        }

        public abstract void Speak();
    }
}
