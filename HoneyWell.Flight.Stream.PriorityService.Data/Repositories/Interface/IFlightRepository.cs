using HoneyWell.Flight.Stream.PriorityService.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyWell.Flight.Stream.PriorityService.Data.Repositories
{
   public interface IFlightRepository
    {
        Task<FlightMetadata> GetFlightMetadata(int flightId);
        Task<bool> AddFlightMetadata(FlightMetadata flight);
    }
}
