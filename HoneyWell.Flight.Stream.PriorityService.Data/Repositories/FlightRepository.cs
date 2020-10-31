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
            /// Create the seed list of flight Metadata
            var flightMetadata1 = new FlightMetadata() { 
                FileRequestType = "Upload",
                FlightId = 1,
                FlightType = "Chartered",
                PassengerType = "Business"
            };

            var flightMetadata2 = new FlightMetadata()
            {
                FileRequestType = "Upload",
                FlightId = 2,
                FlightType = "Cargo",
                PassengerType = "Business"
            };

            var flightMetadata3 = new FlightMetadata()
            {
                FileRequestType = "Upload",
                FlightId = 3,
                FlightType = "Passenger",
                PassengerType = "Business"
            };

            var flightMetadata4 = new FlightMetadata()
            {
                FileRequestType = "Download",
                FlightId = 4,
                FlightType = "Medical",
                PassengerType = "Business"
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
        /// <summary>
        /// get flight metada data by ID
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        public async Task<FlightMetadata> GetFlightMetadata(int flightId)
        {

            var flight = _dbContext.FlightMetadata.FirstOrDefault(flight => flight.FlightId == flightId);
            return flight;
        }

        /// <summary>
        /// get flights metada data by ID
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>

        public async Task<IEnumerable<FlightMetadata>> GetFlightsMetadata(List<int> flightIds)
        {

            var flightsMetadata = _dbContext.FlightMetadata.Where(flight => flightIds.Contains(flight.FlightId));
            return flightsMetadata;
        }
    }
}
