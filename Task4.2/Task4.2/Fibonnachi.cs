using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Fibonnachi
    {
        public long end;

        public void EnterNumberForFibonnachi()
        {
            Console.Write("Введите конец диапазона от 1 до : ");
            
            while (!Int64.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("Please enter number again");
            }
        }
        public void CalculationFibonnachiNumbers()
        {
            EnterNumberForFibonnachi();

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
