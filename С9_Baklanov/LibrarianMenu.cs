using C9_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov
{
    internal class LibrarianMenu : IMenu
    {
        public bool Flag { get; set; }
        BookServicePL bookServicePL;
        ConsoleColor defaultColor;

        public LibrarianMenu(BookServicePL bookServicePL)
        {
            this.bookServicePL = bookServicePL;
        }

        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Init");
        }

        public void Idle()
        {
            Console.WriteLine("1 - Average price by pages");
            Console.WriteLine("2 - Exit");

            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    bookServicePL.AveragePriceByPages();
                    break;
                case 2:
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("Виберіть один із пунктів меню");
                    break;
            }
        }

        public void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("CleanUp");
        }
    }
}