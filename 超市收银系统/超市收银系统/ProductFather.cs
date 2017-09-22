using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;    
        }
        public string Name
        {
            get;
            set;
        }
        public ProductFather(string name,double price, int count, string id)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.ID = id;
        }

        public ProductFather(double price, int count, string id)
        {
            Price = price;
            Count = count;
            ID = id;
        }
    }
}
