using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("I am a good person");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(3.14);
            //list.Add(true);
            //Person p = new Person();
            //list.Add(p);
            //list.Add("张三");
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = r.Next(10);
                if (!list.Contains(number))
                {
                    list.Add(number);
                }
                else
                {
                    i--;
                }
            }
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] is int[])
            //    {r
            //        for (int j = 0; j < ((int[])list[i]).Length; j++)
            //        {
            //            Console.WriteLine(((int[])list[i])[j]);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(list[i]);
            //    }
            //}
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum +=(int)list[i];
                Console.WriteLine(list[i]);
                
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum/list.Count);
            Console.ReadKey();
        }
    }
    
}
