using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            void add(out int a)
            {
                a = 3;
                Console.WriteLine(a);
            }
            add(out i);
            Console.WriteLine(i);
            Console.Read();
        }
    }
}
