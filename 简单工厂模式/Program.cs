using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你需要的笔记本品牌");
            string str = Console.ReadLine();
            Notebook nb = GetNotebook(str);
            nb.Sayhello();
            Console.ReadKey();
        }
        public static Notebook GetNotebook(string str) {
            Notebook nb = null;
            switch (str)
            {
                case "Acer":nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
                default:
                    break;
            }
            return nb;
        }
    }
    public abstract class Notebook
    {
        public abstract void Sayhello();
    }
    public class Acer : Notebook
    {
        public override void Sayhello()
        {
            Console.WriteLine("我是宏碁笔记本");
        }
    }
    public class Dell : Notebook
    {
        public override void Sayhello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
}
