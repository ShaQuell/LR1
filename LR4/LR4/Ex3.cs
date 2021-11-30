using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class Ex3 : Ex1
    {
        public int x3 = (int)x1;
        public Ex3(int x3)
        {
            this.x3 = x3;
        }

        public void DebugWrite3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Debug.Write("Тип int:");
            Debug.Write(x3);
            Console.ResetColor();
        }
    }
}
