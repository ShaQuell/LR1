using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Book
    {
        private string _book;

        public Book(string book)
        {
            this._book = book;
        }
        public void Show()
        {
            Console.WriteLine($"Книга:{ _book}");
        }
    }
}
