using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合练习_分离奇偶数
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            list.AddRange(new int[] { 12, 23, 34, 54, 65, 67, 78, 34, 65 });
            foreach (int item in list)
            {
                if (item%2==0)
                {
                    list2.Add(item);
                }
                else
                {
                    list1.Add(item);
                }
            }
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
