using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Flight.PriorityService.Api.Models
{
    public class FlightMetadata
    {
        public int FlightId { get; set; }
        public string FlightType { get; set; }
        public string FileRequestType { get; set; }
        public string PassengerType { get; set; }
    }
}
