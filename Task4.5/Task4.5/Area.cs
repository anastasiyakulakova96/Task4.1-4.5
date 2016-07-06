using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5
{
    class Area
    {
        public int widthSurface =Int32.Parse(Data.W);
        public int lenghtSurface = Int32.Parse(Data.L);
        public int surfaceArea;
        public int widthInput = 0;
        public int lenghtInput = 0;
        public int numberOfRectanglesHorizontally = 0;
        public int numberOfRectanglesVertically= 0;
        int countRectangles = 0;
        int restLenght = 0;
        int restWidth = 0;
        int tempCountRectangles;

        public void InputSidesOfRectangle()
        {
            Console.WriteLine("Please enter width of rectangle");
            while (!Int32.TryParse(Console.ReadLine(), out widthInput))
            {
                Console.WriteLine("Please enter width side again ");
            }

            Console.WriteLine("Please enter lenght  of rectangle");
            while (!Int32.TryParse(Console.ReadLine(), out lenghtInput))
            {
                Console.WriteLine("Please enter lenght side again ");
            }

        }

        public int CalculateArea(int lenghtSurface, int widthSurface)
        {
            return lenghtSurface * widthSurface;
        }

        public void PrintArea()
        {
            surfaceArea = CalculateArea(lenghtSurface, widthSurface);
            Console.WriteLine("Surface Area= " + surfaceArea + "\n width " + widthSurface + "\n lenght " + lenghtSurface);
        }

        public bool CheckSidesOfRectangle(int lenghtSurface, int widthSurface, int lenghtInput, int widthInput)
        {
            if (lenghtSurface >= lenghtInput && widthSurface >= widthInput)
            {
                return true;
            }
            return false;
        }

        public int CheckCountRectangle(int widthSurface, int lenghtSurface, int widthInput, int lenghtInput)
        {
            int countOfWidth = widthSurface / widthInput;
            int countOfLenght = lenghtSurface / lenghtInput;
            int occupiedLength = lenghtInput * countOfLenght;
            int occupationWidth = widthInput * countOfWidth;
            int occupiedArea = CalculateArea(occupationWidth, occupiedLength); //занятая площадь
            int areaOneSide = CalculateArea(widthInput, lenghtInput); // одного прямоугольника
            restLenght = lenghtSurface - occupiedLength;
            restWidth = widthSurface - occupationWidth;

            tempCountRectangles = occupiedArea / areaOneSide;

            return tempCountRectangles;
        }

        public bool HorizontalCalculateCount()
        {
          
            if (CheckSidesOfRectangle(lenghtSurface, widthSurface, lenghtInput, widthInput)) 
            {
                numberOfRectanglesHorizontally = CheckCountRectangle(widthSurface, lenghtSurface, widthInput, lenghtInput);

                if ((restLenght > 0 || restWidth > 0) && (CheckSidesOfRectangle(restLenght, widthSurface, widthInput, lenghtInput)))
                {
                    int temp =widthInput;
                    widthInput = lenghtInput;
                    lenghtInput = temp;

                    countRectangles = CheckCountRectangle(widthSurface, restLenght, widthInput, lenghtInput);
                    numberOfRectanglesHorizontally += countRectangles;
                }
                return true;
            }
            return false;
           
        }

        public bool VerticalCalculateCount()
        {
            int temp = widthInput;
            widthInput = lenghtInput;
            lenghtInput = temp;

            if (CheckSidesOfRectangle(lenghtSurface, widthSurface, lenghtInput, widthInput))
            {
                numberOfRectanglesVertically = CheckCountRectangle(widthSurface, lenghtSurface, widthInput, lenghtInput);
                if ((restLenght > 0 || restWidth > 0) && (CheckSidesOfRectangle(restLenght, widthSurface, widthInput, lenghtInput)))
                {
                    temp = widthInput;
                    widthInput = lenghtInput;
                    lenghtInput = temp;

                    countRectangles = CheckCountRectangle(widthSurface, restLenght, widthInput, lenghtInput);
                    numberOfRectanglesVertically += countRectangles; 
                }
                return true;
            }
            return false;
        }

        public void ShowResult()
        {
            if (HorizontalCalculateCount() || VerticalCalculateCount()) 
            {
                HorizontalCalculateCount();
                VerticalCalculateCount();
               Console.WriteLine("Count of rectangles: " + Math.Max(numberOfRectanglesHorizontally, numberOfRectanglesVertically)); 
            }
            else
            {
                Console.WriteLine("None of the rectangle does not fit in a given area");
            }
        }
    }
}
