using HoneyWell.Flight.PriorityService.Api.Contracts;
using HoneyWell.Flight.PriorityService.Api.Models;
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

        public ProcessRules(ILogger<ProcessRules> logger)
        {
            _logger = logger;
        }
        public List<RuleItems> ProcessFlightRules(List<FlightDetails> flightDetails)
        {
            
            _logger.LogInformation("Processing FlightRules");
            var flightMetaData = "Fetch from INMemory";
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
