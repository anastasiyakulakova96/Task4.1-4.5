using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Launcher
    {
        Goods goods = new Goods();
        List<Product> basket = new List<Product>();

        static void Main(string[] args)
        {

            Launcher launcher = new Launcher();
            string switchCase = "";

            launcher.goods.ListOfGoods(); 
            launcher.goods.ShowGoodsAndPrice();
            launcher.AddInBasket();

            while (!switchCase.Equals("5"))
            {
                Console.WriteLine("Please enter you want to do\n" + "1-Show basket\n" + "2-Delete product\n" + "3-Add product\n" + "4-Order price\n" + "5-Exit\n");
                switchCase = Console.ReadLine();
                switch (switchCase)
                {
                    case "1":
                        launcher.ShowBasket();
                        break;
                    case "2":
                        launcher.DeleteBasket();
                        break;
                    case "3":
                        launcher.AddInBasket();
                        break;
                    case "4":
                        launcher.CalculateOrderPrice();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("You chose other number that 1,2,3,4,5");
                        break;
                }
            }
        }


        public List<Product> AddInBasket()
        {
            int productId = 0;
            int count = 0;
            string id;
            string c;

            while (productId != -1)
            {
                Console.WriteLine("Enter ID number, what you want add in basket.If you want to exit enter '-1' ");

                while (!Int32.TryParse(Console.ReadLine(), out productId))
                {
                    Console.WriteLine("Please enter number again");
                }

                Console.WriteLine("Enter count this product \n");

                while (!Int32.TryParse(Console.ReadLine(), out count))
                {
                    Console.WriteLine("Please enter count again");
                }

                foreach (var s in goods.ListOfGoods())
                {
                    if (s.Id == productId)
                    {
                        s.Count = count;
                        basket.Add(s);
                    }
                }
            }
            return basket;
        }


        public void ShowBasket()
        {
            if (basket.Count > 0)
            {
                Console.WriteLine("In basket:");
                for (int i = 0; i < basket.Count; i++)
                {
                    Console.WriteLine("ID:" + basket[i].Id + " name:" + basket[i].Name + " price:" + basket[i].Price + " count:" + basket[i].Count);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Basket is empty\n");
            }
        }


        public void DeleteBasket()
        {
            Console.WriteLine("Enter id of product that you want delete");
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
                Console.WriteLine("Order price= " + price + "\n");
            }
            else
            {
                Console.WriteLine("Basket is empty\n");
            }
        }
    }
}
