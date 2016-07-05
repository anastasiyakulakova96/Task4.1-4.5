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
            string switchCase = "";

            while (!switchCase.Equals("3"))
            {
                Console.WriteLine("Please,choose what you want calculate: \n" + "1-FibonnachiNumbers\n" + "2-factirial\n" + "3-Exit");
                switchCase = Console.ReadLine();

                switch (switchCase)
                {
                    case "1":
                        launcher.CalculationFibonnachiNumbers();
                        break;
                    case "2":
                        launcher.CalculationFactorial();
                        break;
                    default:
                        Console.WriteLine("You enter don't 1 or 2");
                        break;
                }
            }
        }

        public void CalculationFactorial()
        {
            Console.WriteLine("\n Please,enter number to factirial");

            long x;
            while (!Int64.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Please enter number again");
            }

            long result = 1;
            for (long i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine("FACTORIAL= " + result + "\n");
        }


        public void CalculationFibonnachiNumbers()
        {
            Console.Write("Введите конец диапазона от 1 до : ");
            long end;
            while (!Int64.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("Please enter number again");
            }

            long j = 1;
            for (long i = 1; i <= end; i += j)
            {
                Console.Write("{0} ", i);
                j = i - j;
            }
            Console.WriteLine("\n");
        }
    }
}
