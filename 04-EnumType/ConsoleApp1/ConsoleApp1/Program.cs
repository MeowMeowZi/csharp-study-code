using System;

namespace ConsoleApp1
{
    public enum Week
    {
        星期一,
        星期二,
        星期三,
        星期四,
        星期五,
        星期六,
        星期天
    }

    public enum Gender
    {
        boy,
        girl
    }

    class Program
    {
        static void Main(string[] args)
        {
            Week day = Week.星期二;
            Week day_2 = Week.星期四;
            Console.WriteLine(day);

            Gender p1 = Gender.boy;
            Gender p2 = Gender.girl;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
