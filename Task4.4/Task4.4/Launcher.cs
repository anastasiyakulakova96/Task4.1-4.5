using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Launcher
    {
        Basket basket = new Basket();

        static void Main(string[] args)
        {
            Launcher launcher = new Launcher();
            Goods goods = new Goods();

            goods.ListOfGoods();
            goods.ShowGoodsAndPrice();
            launcher.basket.AddInBasket();
            launcher.Cases();
        }

        public void Cases()
        {
            string switchCase = "";

            while (!switchCase.Equals("5"))
            {
                Console.WriteLine("Please enter you want to do\n" + "1-Show basket\n" + "2-Delete product\n" + "3-Add product\n" + "4-Order price\n" + "5-Exit");
                switchCase = Console.ReadLine();
                switch (switchCase)
                {
                    case "1":
                        basket.ShowBasket();
                        break;
                    case "2":
                        basket.DeleteBasket();
                        break;
                    case "3":
                        basket.AddInBasket();
                        break;
                    case "4":
                        basket.CalculateOrderPrice();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("You chose other number that 1,2,3,4,5");
                        break;
                }
            }
        }

    }
}
