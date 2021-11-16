using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Author
    {
        private string _author;

        public Author(string author)
        {
            this._author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор:{ _author}");
        }
    }
}
