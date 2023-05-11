using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov
{

    internal class Book : IId
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int NumberOfPages { get; set; }
        public double Price { get; set; }

        public Book(string bookName, int numberOfPages, int price)
        {
            BookName = bookName;
            NumberOfPages = numberOfPages;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format(Id + ", " + BookName + ", " + NumberOfPages + ", " + Price);
        }
    }
}
