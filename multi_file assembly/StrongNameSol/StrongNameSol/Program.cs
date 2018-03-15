using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookClass;

namespace StrongNameSol
{
    class Library
    {
        static void Main(string[] args)
        {
            var book = new Book("Title1", "Author1");
            Console.WriteLine(book.ToString());
            Console.ReadLine();
        }
    }
}
