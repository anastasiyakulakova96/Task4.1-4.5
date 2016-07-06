using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Basket
    {
        List<Product> basket = new List<Product>();
        Goods goods = new Goods();


        public List<Product> AddInBasket()
        {
            int productId = 0;
            int count = 0;

            string key = ""; 
            while (!key.Equals("no"))
            {
                Console.WriteLine("Enter ID number, what you want add in basket:");

                while (!Int32.TryParse(Console.ReadLine(), out productId))
                {
                    Console.WriteLine("Please enter number again");
                }

                Console.WriteLine("Enter count this product ");

                while (!Int32.TryParse(Console.ReadLine(), out count))
                {
                    Console.WriteLine("Please enter count again");
                }

                Console.WriteLine();

                foreach (var s in goods.ListOfGoods())
                {
                    if (s.Id == productId)
                    {
                        s.Count = count;
                        basket.Add(s);
                    }
                }

                Console.WriteLine("Do you want to continue (yes/no):");
                key = Console.ReadLine();
            }
            return basket;
        }

        public void ShowBasket()
        {
            if (basket.Count > 0)
            {
                Console.WriteLine("\nIn basket:");
                for (int i = 0; i < basket.Count; i++)
                {
                    Console.WriteLine("ID:" + basket[i].Id + " name:" + basket[i].Name + " price:" + basket[i].Price + " count:" + basket[i].Count);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nBasket is empty\n");
            }
        }

        public void DeleteBasket()
        {
            Console.WriteLine("\nEnter id of product that you want delete");
            int deleteId;

            while (!Int32.TryParse(Console.ReadLine(), out deleteId))
            {
                Console.WriteLine("Please enter number again");
            }

            foreach (var s in basket)
            {
                if (s.Id == deleteId)
                {
                    basket.Remove(s);
                    break;
                }
            }
            Console.WriteLine();
        }

        public void CalculateOrderPrice()
        {
            int price = 0;
            if (basket.Count > 0)
            {
                foreach (var s in basket)
                {
                    price += s.Price * s.Count;
                }
                Console.WriteLine("\nOrder price= " + price + "\n");
            }
            else
            {
                Console.WriteLine("\nBasket is empty\n");
            }
        }

    }
}
