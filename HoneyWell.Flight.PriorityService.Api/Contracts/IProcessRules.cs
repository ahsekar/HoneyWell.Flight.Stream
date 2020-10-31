using HoneyWell.Flight.PriorityService.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HoneyWell.Flight.PriorityService.Api.Contracts
{
    public interface IProcessRules
    {
        Task<List<RuleItems>> ProcessFlightRules(List<int> ruleItems);
    }
}