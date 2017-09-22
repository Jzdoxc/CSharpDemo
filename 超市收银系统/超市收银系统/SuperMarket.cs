using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class SuperMarket
    {
        Repertory repertory = new Repertory();
        public SuperMarket()
        {
            repertory.GetGoods("Samsung", 100);
            repertory.GetGoods("XiaoMi", 50);
            repertory.GetGoods("OPPO", 30);
            repertory.GetGoods("VIVO", 30);
        }
        public void AskBuying()
        {
            Console.WriteLine("这里有三星，小米，OPPO，VIVO");
            Console.WriteLine("请输入需要购买的商品名称");
            string strtype = Console.ReadLine();
            Console.WriteLine("请输入数量");
            int count = int.Parse(Console.ReadLine());
            List<ProductFather> list = repertory.PutGoods(strtype, count);
            if (list==null)
            {
                Console.WriteLine("对不起，我们的库存不足");
            }
            else
            {
                double money = list[0].Price * count;
                Console.WriteLine("你总共购买了\t" + list[0].Name + "手机" + "\t" + count + "件" + ",一共花费" + money + "元");
            }

        }
        public void Show()
        {
            repertory.ShowGoods();
        }
    }
}
