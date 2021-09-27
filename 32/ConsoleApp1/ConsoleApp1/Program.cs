using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// V(View) 视图层---用户交互层. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var userController = new UserController();
            
            Console.WriteLine("--------------------");
            Console.WriteLine("----用户管理系统----");
            Console.WriteLine("--------------------");
            while (true)
            {
                Console.WriteLine("1.添加信息|2.删除信息|3.修改信息|4.查询信息|5.退出");
                string userCommand = Console.ReadLine();
                
                // 添加信息.
                if (userCommand == "1")
                {
                    Console.Write("请输入名字：");
                    string name = Console.ReadLine();
                    Console.Write("请输入年龄：");
                    int age = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("请输入地址：");
                    string address = Console.ReadLine();
                    userController.AddItem(name, age, address);
                }
                // 删除信息.
                else if (userCommand == "2")
                {
                    Console.Write("请输入删除信息的名字：");
                    userController.DelteItem(Console.ReadLine());
                }
                // 修改信息.
                else if (userCommand == "3")
                {
                    Console.Write("请输入修改信息的名字：");
                    string oldName = Console.ReadLine();
                    Console.Write("请输入变更后的名字：");
                    string name = Console.ReadLine();
                    Console.Write("请输入变更后的年龄：");
                    int age = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("请输入变更后的地址：");
                    string address = Console.ReadLine();
                    userController.ReviseItem(oldName, name, age, address);
                }
                // 查询信息.
                else if (userCommand == "4")
                {
                    if (userController.Count() == 0)
                    {
                        Console.WriteLine("尚未添加信息");
                    }
                    else
                    {
                        userController.FindAll();
                    }
                }
                // 退出系统.
                else if (userCommand == "5")
                {
                    break;;
                }
                else
                {
                    Console.WriteLine("指令错误请重新输入!");
                }
            }
        }
    }
}