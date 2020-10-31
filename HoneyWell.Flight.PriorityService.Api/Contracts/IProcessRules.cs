using HoneyWell.Flight.Stream.PriorityService.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HoneyWell.Flight.PriorityService.Api.Contracts
{
    public interface IProcessRules
    {
        Task<List<FlightMetadata>> ProcessFlightRules(List<int> ruleItems);
    }
}