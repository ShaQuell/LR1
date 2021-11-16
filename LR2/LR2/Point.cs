using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Point
    {
        private int _pointA;
        private int _pointB;
        private int _pointC;
        private int _pointD;
        private int _pointE;
        private string _figname;

        public Point(int pointA, int pointB, int pointC, int pointD, int pointE, string figname)
        {
            this._pointA = pointA;
            this._pointB = pointB;
            this._pointC = pointC;
            this._pointD = pointD;
            this._pointE = pointE;
            this._figname = figname;
        }
    }
}
