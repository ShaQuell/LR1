using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR4
{
    class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Триальній режим");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версія");
        }
    }
}
