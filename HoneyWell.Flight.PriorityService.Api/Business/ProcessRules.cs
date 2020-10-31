using HoneyWell.Flight.PriorityService.Api.Contracts;
using HoneyWell.Flight.PriorityService.Api.Models;
using HoneyWell.Flight.Stream.PriorityService.Data.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HoneyWell.Flight.PriorityService.Api.Business
{
    public class ProcessRules : IProcessRules
    {
        private readonly ILogger<ProcessRules> _logger;
        private readonly IFlightRepository _flightRepository;

        public ProcessRules(ILogger<ProcessRules> logger, IFlightRepository flightRepository)
        {
            _logger = logger;
            _flightRepository = flightRepository;
        }
        public List<RuleItems> ProcessFlightRules(List<int> flightDetails)
        {
            
            _logger.LogInformation("Processing FlightRules");
            List<RuleItems> processedRules = new List<RuleItems>();
            try
            {
                //Logic for processing start



                //Logic for processing end
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return processedRules;
        }
    }
}
