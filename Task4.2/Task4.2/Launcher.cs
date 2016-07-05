using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Launcher
    {
        public static void Main()
        {
            Launcher launcher = new Launcher();
            launcher.Cases();
        }

        public void Cases()
        {
            Factorial factorial = new Factorial();
            Fibonnachi fibonnachi = new Fibonnachi();

            string switchCase = "";

            while (!switchCase.Equals("3"))
            {
                Console.WriteLine("Please,choose what you want calculate: \n" + "1-FibonnachiNumbers\n" + "2-factirial\n" + "3-Exit");
                switchCase = Console.ReadLine();

                switch (switchCase)
                {
                    case "1":
                        fibonnachi.CalculationFibonnachiNumbers();
                        break;
                    case "2":
                        factorial.CalculationFactorial();
                        break;
                    default:
                        Console.WriteLine("You enter don't 1 or 2");
                        break;
                }
            }
        }
    }
}
