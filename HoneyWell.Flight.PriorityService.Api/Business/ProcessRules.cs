using HoneyWell.Flight.PriorityService.Api.Constants;
using HoneyWell.Flight.PriorityService.Api.Contracts;
using HoneyWell.Flight.PriorityService.Api.Models;
using HoneyWell.Flight.Stream.PriorityService.Data.Models;
using HoneyWell.Flight.Stream.PriorityService.Data.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

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
        public async Task<List<RuleItems>> ProcessFlightRules(List<int> flightDetails)
        {
            _logger.LogInformation("Processing FlightRules");
            List<RuleItems> processedRules = new List<RuleItems>();

            try
            {
                //Get Vlues from repo
                var metas = await _flightRepository.GetFlightsMetadata(flightDetails);
                //Logic for processing start
                
                foreach(var item in metas)
                {
                    item.PrioritySum = Convert.ToInt32((RequestTypes)Enum.Parse(typeof(RequestTypes), item.FileRequestType, true)) +
                                        Convert.ToInt32((PassengerClass)Enum.Parse(typeof(PassengerClass), item.PassengerType, true))+
                                        Convert.ToInt32((FlightTypes)Enum.Parse(typeof(RequestTypes), item.FlightType, true));

                }

                //Sort List based on PrioritySum



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
