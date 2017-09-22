using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[] md5buffer = md5.ComputeHash(buffer);
            //return Encoding.Default.GetString(md5buffer);
            string strnew = "";
            for (int i = 0; i < md5buffer.Length; i++)
            {
                strnew += md5buffer[i].ToString("x");
            }
            return strnew;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("请输入一段");
            //123
            //202cb962ac59075b964b07152d234b70
            string str = Console.ReadLine();
            Console.WriteLine(GetMD5(str)); 
            Console.ReadKey();
            
        }
       
    }
}
