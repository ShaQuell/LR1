using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class Ex1
    {
        private string x1 = "3.182";

        public void DebugWrite()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Debug.Write("Тип string:");
            Debug.Write(x1);
            Console.ResetColor();
        }
        
    }
}
