using HoneyWell.Flight.PriorityService.Api.Constants;

namespace HoneyWell.Flight.PriorityService.Api.Models
{
    public class RuleItems
    {
        public int priority { get; set; }
        public FlightTypes FlightTypes { get; set; }
        public PassengerClass PassengerClass { get; set; }
        //More Rules can be added
    }
}
