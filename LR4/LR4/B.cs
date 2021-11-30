using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class B
    {
        private int _b1;
        private int _b2;

        public B(int b1, int b2)
        {
            this._b1 = b1;
            this._b2 = b2;
        }

        public void Calcul() 
        {
            Console.WriteLine(_b1 + _b2);
        }
    }

    class B1 : B
    {
        public int _b1;
        public int _b2;

        public void Calcul1()
        {
            Console.WriteLine(_b1 - _b2);
        }
    }

    class B2 : B
    {
        public int _b1;
        public int _b2;

        public void Calcul2()
        {
            Console.WriteLine(_b1 * _b2);
        }
    }

    class B3 : B
    {
        public int _b1;
        public int _b2;

        public void Calcul3()
        {
            Console.WriteLine(_b1 / _b2);
        }
    }
}
