using System;

namespace ConsoleApp1
{
    public interface IFly
    {
        // 接口中不能包含字段
        //private string name;

        void Fly();
    }
}