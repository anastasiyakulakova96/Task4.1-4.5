using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Goods
    {
        public List<Product> goods;

        public List<Product> ListOfGoods()
        {
            goods = new List<Product>();
            goods.Add(new Product(1, "Phone", 100));
            goods.Add(new Product(2, "Notebook", 200));
            goods.Add(new Product(3, "TV", 150));

            return goods;
        }

        public void ShowGoodsAndPrice()
        {
            for (int i = 0; i < goods.Count; i++)
            {
                Console.WriteLine("ID:" + goods[i].Id + " name:" + goods[i].Name + " price:" + goods[i].Price);
            }
            Console.WriteLine();
        }
    }
}
