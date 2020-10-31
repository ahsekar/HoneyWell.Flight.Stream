using HoneyWell.Flight.Stream.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HoneyWell.Flight.Stream.Core.Entities
{
	public class FlightDetails
	{
		[Key]
		public int Id { get; set; }
		public Flight Flight { get; set; }
		public double DataSize { get; set; }
		public DataTransferStatus DataTransferStatus { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
