using S7_Baklanov;
using System;
using System.Text;

namespace S7_Baklanov
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IDBItemDAL<Flight> dbBook = new DBItemDAL<Flight>();

            Flight book1 = new Flight(12, "zxc", "zxc", "zxc");
            dbBook.AddItem(book1);

            Flight book2 = new Flight(13, "qwe", "qwe", "qwe");
            dbBook.AddItem(book2);

            IFlightBLL bookBLL = new FlightBLL(dbBook);
            IDispatcherPL librarianPL = new DispatcherPL(bookBLL);
            DispatcherMenu librarianMenu = new DispatcherMenu(librarianPL);
            MenuStrategy menuStrategyLibrarian = new MenuStrategy(librarianMenu);
            MainMenu mainMenu = new MainMenu(menuStrategyLibrarian);
            MenuStrategy menuStrategyMain = new MenuStrategy(mainMenu);
            menuStrategyMain.Run();

            Console.ReadLine();
        }
    }
}
