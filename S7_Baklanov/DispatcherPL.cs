using S7_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{
    class DispatcherPL : IDispatcherPL
    {
        IFlightBLL flight;

        public DispatcherPL(IFlightBLL flight)
        {
            this.flight = flight;
        }
        public void CreateFlight()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть Flight Number: ");
            int FlightNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть Destination: ");
            string Destination = Console.ReadLine();
            Console.Write("Введіть Destination: ");
            string PointOfDeparture = Console.ReadLine();
            Console.Write("Введіть Date: ");
            string Date = Console.ReadLine();

            flight.CreateFlight(FlightNumber, Destination, PointOfDeparture, Date);
        }
        public void FindAllFlight()
        {
            List<Flight> bookList = flight.FindAllFlight();
            foreach (Flight f in bookList)
            {
                Console.WriteLine(f);
            }
        }
        public void FindFlightById()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть ідентифікатор Flight, яку Ви хочете знайти: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Flight fl = flight.FindFlightById(id);
            if (fl != null)
            {
                Console.WriteLine(fl);
            }
            else
            {
                Console.WriteLine("Flight із зазначеним ідентифікатором не знайдено.");
            }
        }

        public void DeleteFlight()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Flight> bookList = flight.FindAllFlight();
            foreach (Flight f in bookList)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("Введіть ідентифікатор flight, яку Ви хочете видалити: ");
            int bookId = Convert.ToInt16(Console.ReadLine());
            Flight bookToDelete = bookList.FirstOrDefault(d => d.Id == bookId);
            if (bookToDelete == null)
            {
                Console.WriteLine("Flight не знайдено");
                return;
            }
            bool isDeleted = flight.DeleteFlight(bookToDelete);
            if (isDeleted)
            {
                Console.WriteLine("Flight успішно видалено");
            }
            else
            {
                Console.WriteLine("Flight не знайдено");
            }
        }
        public void UpdateFlight()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть ідентифікатор flight, яку Ви хочете оновити: ");
            int bookId = Convert.ToInt16(Console.ReadLine());
            Flight book = flight.FindFlightById(bookId);
            if (book != null)
            {
                Console.WriteLine("Ви хочете оновити інформацію щодо цієї flight?");
                Console.WriteLine("1. Так");
                Console.WriteLine("2. Ні");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть Flight Number: ");
                        int FlightNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть Destination: ");
                        string Destination = Console.ReadLine();
                        Console.Write("Введіть Destination: ");
                        string PointOfDeparture = Console.ReadLine();
                        Console.Write("Введіть Date: ");
                        string Date = Console.ReadLine();
                        if (flight.UpdateFlight(book, FlightNumber, Destination, PointOfDeparture, Date))
                        {
                            Console.WriteLine("flight успішно оновлено.");
                        }
                        else
                        {
                            Console.WriteLine("Не вдалося оновити flight.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Добре!");
                        break;
                }

            }
        }
    }
}
