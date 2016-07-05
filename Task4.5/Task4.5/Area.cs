using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5
{
    class Area
    {
        public int W =Int32.Parse(Data.W);
        public int L = Int32.Parse(Data.L);
        public int surfaceArea;
        public int w = 0;
        public int l = 0;
        public int result=0;
        public int result1=0;
        int countRectangles = 0;
        int restLenght = 0;
        int restWidth = 0;
        int tempcountRectangles;

        public void InputSidesOfRectangle()
        {
            Console.WriteLine("Please enter width of rectangle");
            while (!Int32.TryParse(Console.ReadLine(), out w))
            {
                Console.WriteLine("Please enter width side again ");
            }

            Console.WriteLine("Please enter lenght  of rectangle");
            while (!Int32.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Please enter lenght side again ");
            }

        }

        public int CalculateArea(int L, int W)
        {
            return L * W;
        }

        public void PrintArea()
        {
            surfaceArea = CalculateArea(L, W);
            Console.WriteLine("Surface Area= " + surfaceArea + "\n width " + W + "\n lenght " + L);
        }

        public bool CheeckSidesOfRectangle(int L, int W, int l, int w)
        {
            if (L >= l && W >= w)
            {
                return true;
            }
            return false;
        }

        public int CheeckCountRectangle(int W, int L, int w, int l)
        {
            int countOfWidth = W / w;
            int countOfLenght = L / l;
            int occupiedLength = l * countOfLenght;
            int occupationWidth = w * countOfWidth;
            int occupiedArea = CalculateArea(occupationWidth, occupiedLength); //занятая площадь
            int areaOneSide = CalculateArea(w, l); // одного прямоугольника
            restLenght = L - occupiedLength;
            restWidth = W - occupationWidth;

            tempcountRectangles = occupiedArea / areaOneSide;

            return tempcountRectangles;
        }

        public bool HorizontCalculateCaunt()
        {
          
            if (CheeckSidesOfRectangle(L, W, l, w))
            {
                result = CheeckCountRectangle(W, L, w, l);

                if ((restLenght > 0 || restWidth > 0) && (CheeckSidesOfRectangle(restLenght, W, w, l)))
                {
                    int temp = 0;
                    temp = w;
                    w = l;
                    l = temp;

                    countRectangles = CheeckCountRectangle(W, restLenght, w, l);
                    result += countRectangles;
                }
                return true;
            }
            else
            {
                Console.WriteLine("None of the rectangle does not fit in a given area");
               return false;
            }
            return false;
        }

        public bool VerticalCalculateCaunt()
        {
            int temp = 0;
            temp = w;
            w = l;
            l = temp;

            if (CheeckSidesOfRectangle(L, W, l, w))
            {
                result1 = CheeckCountRectangle(W, L, w, l);
                if ((restLenght > 0 || restWidth > 0) && (CheeckSidesOfRectangle(restLenght, W, w, l)))
                {
                    temp = 0;
                    temp = w;
                    w = l;
                    l = temp;

                    countRectangles = CheeckCountRectangle(W, restLenght, w, l);
                    result1 += countRectangles;
                }
                return true;
            }
            else
            {
                Console.WriteLine("None of the rectangle does not fit in a given area");
                return false;
            }
           
            
        }

        public void ShowResult()
        {
            if (HorizontCalculateCaunt() || VerticalCalculateCaunt())
            {
                HorizontCalculateCaunt();
                VerticalCalculateCaunt();
               Console.WriteLine("Count of triangles: " + Math.Max(result,result1));
            }
        }
    }
}
