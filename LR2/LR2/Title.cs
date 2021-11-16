using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Title
    {
        private string _title;

        public Title(string title)
        {
            this._title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Назва:{ _title}");
        }
    }
}
