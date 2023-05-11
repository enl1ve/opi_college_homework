using C9_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov
{
    internal class BookServicePL
    {

        BookServiceBLL bookServiceBLL;

        public BookServicePL(BookServiceBLL bookServiceBLL)
        {
            this.bookServiceBLL = bookServiceBLL;
        }

        public void AveragePriceByPages()
        {
            Console.Write("Введіть кількість сторінок більше за яку потрібно рахувати: ");
            int numberOfPages = int.Parse(Console.ReadLine());
            double averagePrice = bookServiceBLL.AveragePriceByPages(numberOfPages);
            Console.Write("Середня ціна дорівнює: ");
            Console.WriteLine(averagePrice);
        }
    }
}