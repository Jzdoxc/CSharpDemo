using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(4);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
