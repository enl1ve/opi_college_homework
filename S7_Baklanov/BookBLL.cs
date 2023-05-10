using S7_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{

    internal class FlightBLL : IFlightBLL
    {
        IDBItemDAL<Flight> dbBook;

        public FlightBLL(IDBItemDAL<Flight> dbBook)
        {
            this.dbBook = dbBook;
        }
        public void CreateFlight(int FlightNumber, string Destination, string PointOfDepartune, string Data)
        {
            Flight book = new Flight(FlightNumber, Destination, PointOfDepartune, Data);
            dbBook.AddItem(book);
        }
        public List<Flight> FindAllFlight()
        {
            return dbBook.Items.ToList();
        }

        public Flight FindFlightById(int id)
        {
            return dbBook.FindById(id);
        }

        public bool DeleteFlight(Flight book)
        {
            return dbBook.Delete(book);
        }

        public bool UpdateFlight(Flight oldItem, int FlightNumber, string Destination, string PointOfDepartune, string Data)
        {
            Flight newItem = new Flight(FlightNumber, Destination, PointOfDepartune, Data);
            if (dbBook.UpdateItem(oldItem, newItem))
            {
                return true;
            }
            return false;
        }
    }
}
