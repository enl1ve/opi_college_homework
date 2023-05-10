using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{
    class Flight : IId
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string Destination { get; set; }
        public string PointOfDepartunity { get; set; }
        public string Data { get; set; }


        public Flight(int FlightNumber, string Destination, string PointOfDepartunity, string Data)
        {
            this.FlightNumber = FlightNumber;
            this.Destination = Destination;
            this.PointOfDepartunity = PointOfDepartunity;
            this.Data = Data;
        }

        public override string ToString()
        {
            return String.Format("Id: " + Id + ", FlightNumber: " + FlightNumber+ ", Destination: " + Destination + ", Point of departunity:" + PointOfDepartunity + ", Data: " + Data);
        }
    }
}
