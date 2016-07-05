using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Factorial
    {
        public long factirial;

        public void EnterNumberForFactorial()
        {
            Console.WriteLine("\n Please,enter number to factirial");

           while (!Int64.TryParse(Console.ReadLine(), out factirial))
            {
                Console.WriteLine("Please enter number again");
            }
        }

        public void CalculationFactorial()
        {
            EnterNumberForFactorial();

            long result = 1;

            for (long i = 1; i <= factirial; i++)
            {
                result *= i;
            }
            Console.WriteLine("FACTORIAL= " + result + "\n");
        }

    }
}
