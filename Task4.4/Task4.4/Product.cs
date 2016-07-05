using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Product(int id,String name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public Product(int id, String name, int price, int count)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }
    }
}
