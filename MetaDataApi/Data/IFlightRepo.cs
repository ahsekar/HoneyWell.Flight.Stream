using HoneyWell.Flight.Stream.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleStudentAPI.Data
{
	public interface IFlightRepo
	{
        IEnumerable<FlightDetails> GetAllFlightData();
        FlightDetails GetFlightDataByFlightNumber(string FlightNumber);
        void AddFlightData(FlightDetails flightDetails);
        bool SaveChanges();
    }
}
