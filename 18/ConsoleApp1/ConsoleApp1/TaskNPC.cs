using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TaskNPC : NPC
    {
        private string taskInfo;
        public string TaskInfo
        {
            get { return taskInfo; }
            set { taskInfo = value; }
        }

        public TaskNPC() { }

        public TaskNPC(string m_taskInfo, string m_name, NPCType m_type)
            : base(m_name, m_type)
        {
            this.taskInfo = m_taskInfo;
        }

        public override void Speak()
        {
            Console.WriteLine("NPC：{0}，任务：{1}", base.Name, TaskInfo);
        }
    }
}
