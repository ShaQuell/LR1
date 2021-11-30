using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            Ex1 debugg = new Ex1();
            debugg.DebugWrite();

            Ex2 debugg2 = new Ex2();
            debugg2.DebugWrite2();

            Ex3 debugg3 = new Ex3();
            debugg3.DebugWrite3();

            //Задача 2
            B exb = new B(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Debug.Write($"Перший параметр:{exb.b1}, другий параметр:{exb.b2}");

            //Задача 3
            N3 count1 = new N3();
            N31 count2 = new N31();
            N32 count3 = new N32();
            N33 count4 = new N33();
            count1.Show0();
            count2.Show1();
            count3.Show2();
            count4.Show3();

            //Задача 4
            int key1 = 123;
            int key2 = 456;

            ApplicationLicense lice1 = new ApplicationLicense();
            int code1 = int.Parse(Console.ReadLine());

            if (code1 == key1) 
            {
                lice1.AllowTrial();
            }

            if (code1 == key2)
            {
                lice1.AllowPro();
            }

            else
            {
                lice1.AllowCommon();
            }
        }
    }
}
