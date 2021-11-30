using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class N3
    {
        public int num1 = 1;

        public void Show0() 
        {
            Debug.Write("Перший (базовий) клас");
            Debug.Write(num1);
        }
    }

    class N31 : N3
    {
        public int num2 = 2;
        public void Show1()
        {
            Debug.Write("Другий (дочірній) клас");
            Debug.Write(num1);
            Debug.Write(num2);
        }
    }

    class N32 : N3
    {
        public int num3 = 3;
        public void Show2()
        {
            Debug.Write("Третій (дочірній) клас");
            Debug.Write(num1);
            Debug.Write(num3);
        }
    }

    class N33 : N3
    {
        public int num4 = 4;
        public void Show3()
        {
            Debug.Write("Четвертий (дочірній) клас");
            Debug.Write(num1);
            Debug.Write(num4);
        }
    }
}
