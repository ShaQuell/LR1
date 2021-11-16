using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Content
    {
        private string _cont;

        public Content(string cont)
        {
            this._cont = cont;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Зміст:{ _cont}");
        }
    }
}
