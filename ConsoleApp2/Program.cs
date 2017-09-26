using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] files = System.IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ @"\Tencent Files");
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item.Substring(item.LastIndexOf('\\')+1, item.Length-1- item.LastIndexOf('\\')));
            //}
            string[] dirs = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Tencent Files");
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            int m = 0;
            List<List<string>> list = new List<List<string>>();
            for (int i = 0; i < dirs.Length; i++)
            {
                string[] files = Directory.GetFiles(dirs[i] + @"\Image\Group");
                foreach (var str in files)
                {
                    list[m].Add(str);
                }
                m++;
            }
            //comboBox1.Items.Add(item.Substring(item.LastIndexOf('\\') + 1, item.Length - 1 - item.LastIndexOf('\\')));
            foreach (var item in list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    foreach (var path in list[i])
                    {
                        Console.WriteLine(path);
                    }
                }
            }

            //string[] path = Directory.GetFiles(item + @"\Image\Group");
            //list1.AddRange(path);
            //for (int i = 0; i <= 2; i++)
            //{
            //    list2.Add(list + "i");
            //}
            Console.ReadKey();
        }
    }
}
