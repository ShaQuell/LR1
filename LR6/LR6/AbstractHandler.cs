using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    abstract class AbstractHandler
    {
        public void ReadTxt() 
        {
            StreamReader read1 = new StreamReader(@"C:\Users\admin\source\repos\Hello.txt");
        }
        public void CreateTxt()
        {
            FileStream fs = File.Create(@"C:\Users\admin\source\repos\Hello.txt");
        }
        public void WriteTxt()
        {
            StreamWriter read1 = new StreamWriter(@"C:\Users\admin\source\repos\Hello.txt");
        }
    }
}
