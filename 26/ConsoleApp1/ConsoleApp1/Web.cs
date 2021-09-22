using System;

namespace ConsoleApp1
{
    public class Web
    {
        private string webName;
        private string webUrl;

        public Web(string webName, string webUrl)
        {
            this.webName = webName;
            this.webUrl = webUrl;
        }

        public void Show()
        {
            Console.WriteLine("网站名称: {0}--网站地址: {1}", webName, webUrl);
        }
    }
}