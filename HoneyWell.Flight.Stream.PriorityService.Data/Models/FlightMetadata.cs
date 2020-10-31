using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HoneyWell.Flight.Stream.PriorityService.Data.Models
{
    public class FlightMetadata
    {
        public int FlightId { get; set; }

        public string FlightType { get; set; }

        public string FileRequestType { get; set; }

        public string PassengerType { get; set; }

        public int PrioritySum { get; set; }
    }
}
