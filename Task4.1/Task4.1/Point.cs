using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    class Point
    {
       
        public int x;
        public int y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        static void Main(string[] args)
        {
          
        }

        
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }

        public override string ToString()
        {
            return "x= "+x+" y= "+y;
        }

    }
}
