using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5
{
    class Launcher
    {
        static void Main(string[] args)
        {
            Area area = new Area();

            area.PrintArea();
            area.InputSidesOfRectangle();
            area.ShowResult();
            
            Console.WriteLine("For exit enter any symbol");
            Console.ReadLine();
        }


    }
}
