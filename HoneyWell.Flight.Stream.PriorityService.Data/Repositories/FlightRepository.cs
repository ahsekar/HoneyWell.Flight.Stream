using HoneyWell.Flight.Stream.PriorityService.Data.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyWell.Flight.Stream.PriorityService.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {

        private PriorityServiceDbContext _dbContext;
        private readonly ILogger<FlightRepository> _logger;
        public FlightRepository(PriorityServiceDbContext dbContext, Logger<FlightRepository> logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;

            var flightMetadata1 = new FlightMetadata() { 
                FileRequestType = "Upload",
                FlightId = 1,
                FlightType = "Chartered"
            };

            var flightMetadata2 = new FlightMetadata()
            {
                FileRequestType = "Upload",
                FlightId = 2,
                FlightType = "Cargo"
            };

            var flightMetadata3 = new FlightMetadata()
            {
                FileRequestType = "Upload",
                FlightId = 3,
                FlightType = "Passenger"
            };

            var flightMetadata4 = new FlightMetadata()
            {
                FileRequestType = "Download",
                FlightId = 4,
                FlightType = "Medical"
            };

            AddFlightMetadata(flightMetadata1);
            AddFlightMetadata(flightMetadata2);
            AddFlightMetadata(flightMetadata3);
            AddFlightMetadata(flightMetadata4);
        }

        public async Task<bool> AddFlightMetadata(FlightMetadata flight)
        {
            try
            {
                _dbContext.FlightMetadata.Add(flight);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error adding the medicine: {ex.Message}");
                throw;
            }

            return true;
        }

        public async Task<FlightMetadata> GetFlightMetadata(int flightId)
        {

            var flight = _dbContext.FlightMetadata.FirstOrDefault(flight => flight.FlightId == flightId);
            return flight;
        }
    }
}
