using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Rectangle
    {
        private double _side1 = 2;
        private double _side2 = 3;

        public Rectangle(double side1,double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }
        public void AreaCalculator()
        {
            Console.WriteLine(_side1 * _side2);
        }
        public void PerimeterCalculator()
        {
            Console.WriteLine(_side1 * _side2);
        }
    }
}
