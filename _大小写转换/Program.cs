using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _大小写转换
{
    class Program
    {
        const string _capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string _lower = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Hashtable hashable = new Hashtable();
            for (int i = 0; i < _capital.Length; i++)
            {
                hashable.Add(_capital[i], _lower[i]);
            }
            Console.WriteLine("请输入单词或句子");
            string input = Console.ReadLine();
           
            for (int i = 0; i < input.Length; i++)
            {
                if (hashable.ContainsKey(input[i]))
                {
                    Console.Write(hashable[input[i]]);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            
            Console.ReadKey();
        }
    }
}
