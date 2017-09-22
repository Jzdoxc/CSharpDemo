using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王麻子");
            foreach (KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("{0}----{1}",kv.Key,kv.Value);
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0}----{1}",item.Key,item.Value);
            }
            Console.ReadKey();
        }
    }
}
