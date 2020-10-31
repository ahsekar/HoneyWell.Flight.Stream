using HoneyWell.Flight.Stream.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyWell.Flight.Stream.Core.Entities
{
	public class FlightDetails
	{
		public Flight Flight { get; set; }
		public double DataSize { get; set; }
		public DataTransferStatus DataTransferStatus { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
