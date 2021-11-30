using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class Ex2 : Ex1
    {
        public double x2 = (double)x1;
        public Ex2(double x2)
        {
            this.x2 = x2;
        }

        public void DebugWrite2() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Debug.Write("Тип double:");
            Debug.Write(x2);
            Console.ResetColor();
        }
    }
}
