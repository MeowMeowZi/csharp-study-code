using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// C(Controller) 控制器层---用户处理逻辑.
    /// </summary>
    public class UserController
    {
        private List<User> u = new List<User>();

        // TODO 增加数据
        public void AddItem(string name, int age, string address)
        {
            u.Add(new User(name, age, address));
        }

        // TODO 删除数据
        public void DelteItem(string name)
        {
            foreach (var iUser in u)
            {
                if (iUser.Name == name)
                {
                    u.Remove(iUser);
                    break;
                }
            }
        }
        // TODO 修改数据
        public void ReviseItem(string oldName, string name, int age, string address)
        {
            foreach (var iUser in u)
            {
                if (iUser.Name == oldName)
                {
                    iUser.Name = name;
                    iUser.Age = age;
                    iUser.Address = address;
                }
            }
        }

        // TODO 查询数据
        public void FindAll()
        {
            foreach (var iUser in u)
            {
                Console.WriteLine(iUser);
            }
        }
        
        //
        public int Count()
        {
            return u.Count;
        }
    }
}