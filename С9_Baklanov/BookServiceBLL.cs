using C9_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov
{
    internal class BookServiceBLL
    {
        IDBItemDAL<Book> dbBook;

        public BookServiceBLL(IDBItemDAL<Book> dbBook)
        {
            this.dbBook = dbBook;
        }

        public double AveragePriceByPages(int NumberOfPages)
        {
            int qty = 0;
            double sumPrices = 0;
            double averagePrice = 0;
            foreach (var item in this.dbBook.Items)
            {
                if (item.NumberOfPages > NumberOfPages)
                {
                    qty++;
                    sumPrices += item.Price;
                }
            }

            if (qty != 0) { averagePrice = sumPrices / qty; }

            return averagePrice;
        }

    }
}
