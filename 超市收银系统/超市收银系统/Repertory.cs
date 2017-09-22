using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class Repertory
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();//存储货物
        //创建仓库的时候向仓库添加货架
        public Repertory()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        //list[0]存储三星手机
        //list[1]存储小米手机
        //list[2]存储OPPO手机
        //list[3]存储VIVO手机
        public bool GetGoods(string type,int count )
        {
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "Samsung":list[0].Add(new Samsung("Samsung Galaxy S7", 3777,1, Guid.NewGuid().ToString()));
                        break;
                    case "OPPO":list[1].Add(new OPPO("OPPO R9", 3200, 1, Guid.NewGuid().ToString()));
                        break;
                    case "XiaoMi":list[2].Add(new OPPO("XIAOMI 6", 3600, 1, Guid.NewGuid().ToString()));
                        break;
                    case "VIVO": list[3].Add(new VIVO("VIVO X8", 3100, 1, Guid.NewGuid().ToString()));
                        break;
                    default:
                        break;
                }
            }
            return true;
        }
        public List<ProductFather> PutGoods(string type, int count)
        {
            List<ProductFather> list2 = new List<ProductFather>();
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "Samsung":
                        if (list[0].Count!=0)
                        {
                            list2.Add(list[0][0]);
                            list[0].RemoveAt(0);
                        }
                        else
                        {
                            return null;
                        }
                        break;
                    case "OPPO":
                        if (list[1].Count!=0)
                        {
                            list2.Add(list[1][0]);
                            list[1].RemoveAt(0);
                        }
                        else
                        {
                            return null;
                        }
                        break;
                    case "XiaoMi":
                        if (list[2].Count!=0)
                        {
                            list2.Add(list[2][0]);
                            list[2].RemoveAt(0);
                        }
                        else
                        {
                            return null;
                        }
                        break;
                    case "VIVO":
                        if (list[3].Count!=0)
                        {
                            list2.Add(list[3][0]);
                            list[3].RemoveAt(0);
                        }
                        else
                        {
                            return null;
                        }
                        break;
                    default:
                        break;
                } 
            }
            return list2;
        }
        public void ShowGoods()
        {
            foreach (var item in list)
            {
                if (item.Count!=0)
                {
                    Console.WriteLine("我们仓库有" + item[0].Name + "\t" + item[0].Price + "\t" + item.Count);
                }
            }
        }
    }
}
