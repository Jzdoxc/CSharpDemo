using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface Koulanable
    {
        void Koulan();
    }
    class Program
    {
        static void Main(string[] args)
        {
            NBAplayer nb = new NBAplayer();
            nb.Koulan();
            Console.ReadKey();
        }
    }
    class Person
    {
        public void Eat()
        {
            Console.WriteLine("正在吃饭");
        }
    }
    class NBAplayer:Person,Koulanable
    {
        public void Koulan()
    {
        Console.WriteLine("扣篮成功");
    }
    }
}
