using HoneyWell.Flight.PriorityService.Api.Contracts;
using HoneyWell.Flight.PriorityService.Api.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace HoneyWell.Flight.PriorityService.Api.Business
{
    public class ProcessRules : IProcessRules
    {
        private readonly ILogger<ProcessRules> _logger;

        public ProcessRules(ILogger<ProcessRules> logger)
        {
            _logger = logger;
        }
        public List<RuleItems> ProcessFlightRules(List<RuleItems> ruleItems)
        {
            _logger.LogInformation("Processing FlightRules");
            List<RuleItems> processedRules = new List<RuleItems>();
            try
            {
                //Logic for processing start
                var items = ruleItems;
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
