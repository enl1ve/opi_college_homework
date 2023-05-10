namespace S7_Baklanov
{
    internal interface IFlightBLL
    {
        void CreateFlight(int FlightNumber, string Destination, string PointOfDepartune, string Data);
        bool DeleteFlight(Flight book);
        List<Flight> FindAllFlight();
        Flight FindFlightById(int id);
        bool UpdateFlight(Flight oldItem, int FlightNumber, string Destination, string PointOfDepartune, string Data);
    }
}