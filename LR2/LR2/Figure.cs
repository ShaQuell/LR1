using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Figure
    {
        public Figure(int pointA, int pointB, int pointC, string figname)
        {
            figname = "Triangle";
        }
        public Figure(int pointA, int pointB, int pointC, int pointD, string figname)
        {
            figname = "Tetragon";
        }

        public Figure(int pointA, int pointB, int pointC, int pointD, int pointE, string figname)
        {
            figname = "Pentagon";
        }

        public void LengthSide(int pointA,int pointB) 
        {
            Console.WriteLine(pointA + pointB);
        }

        public void PerimeterCalculator(int pointA, int pointB, int pointC, string figname)
        {
            Console.WriteLine(pointA + pointB + pointC);
            Console.WriteLine(figname);
        }
        public void PerimeterCalculator(int pointA, int pointB, int pointC, int pointD, string figname)
        {
            Console.WriteLine(pointA + pointB + pointC + pointD);
            Console.WriteLine(figname);
        }
        public void PerimeterCalculator(int pointA, int pointB, int pointC, int pointD, int pointE, string figname)
        {
            Console.WriteLine(pointA + pointB + pointC + pointD + pointE);
            Console.WriteLine(figname);
        }
    }
}
