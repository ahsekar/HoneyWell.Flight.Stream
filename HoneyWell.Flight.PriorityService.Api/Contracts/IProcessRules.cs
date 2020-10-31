using HoneyWell.Flight.PriorityService.Api.Models;
using System.Collections.Generic;

namespace HoneyWell.Flight.PriorityService.Api.Contracts
{
    public interface IProcessRules
    {
        List<RuleItems> ProcessFlightRules(List<RuleItems> ruleItems);
    }
}