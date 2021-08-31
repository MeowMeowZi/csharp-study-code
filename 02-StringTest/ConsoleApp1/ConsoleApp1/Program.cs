using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Meow";
            Console.WriteLine("ToUpper: " + name.ToUpper());
            Console.WriteLine("ToLower: " + name.ToLower());

            string name_2 = "lfz";
            Console.WriteLine("Equals: " + name.Equals(name_2));

            string address = "中国|浙江|杭州";
            char[] c = new char[] { '|' };
            string[] addr = address.Split(c);
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine(addr[i]);
            }

            Console.WriteLine("Substring: " + name.Substring(2));
            Console.WriteLine("Substring: " + name.Substring(2, 1));

            string name_3 = "MeMwM";
            Console.WriteLine("IndexOf: " + name_3.IndexOf("M"));
            Console.WriteLine("IndexOf: " + name_3.IndexOf("m"));
            Console.WriteLine("LastIndexOf: " + name_3.LastIndexOf("M"));
            Console.WriteLine("LastIndexOf: " + name_3.LastIndexOf("m"));

            Console.WriteLine("StartsWith: " + name.StartsWith("Me"));
            Console.WriteLine("StartsWith: " + name.StartsWith("me"));
            Console.WriteLine("EndsWith: " + name.EndsWith("ow"));
            Console.WriteLine("EndsWith: " + name.EndsWith("oW"));

            Console.WriteLine("Replace: " + name.Replace("M", "m"));

            Console.WriteLine("Contains: " + name.Contains("me"));
            Console.WriteLine("Contains: " + name.Contains("ow"));

            string name_4 = "    M e o w      ";
            Console.WriteLine("Trim: " + name_4.Trim() + "$");
            Console.WriteLine("TrimStart: " + name_4.TrimStart() + "$");
            Console.WriteLine("TrimEnd: " + name_4.TrimEnd() + "$");

            string name_5 = "";
            string name_6 = null;
            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(name_5));
            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(name_6));

            string name_7 = "生活不易，喵喵叹气";
            for (int i = 0; i < name_7.Length; i++)
            {
                Console.WriteLine(name_7[i]);
            }
        }
    }
}
