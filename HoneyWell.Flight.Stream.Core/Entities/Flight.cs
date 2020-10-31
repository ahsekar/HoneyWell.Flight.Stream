using HoneyWell.Flight.Stream.Core.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HoneyWell.Flight.Stream.Core
{
	public class Flight
	{
		[Key]
		public int Id { get; set; } 

		[Required, MaxLength(10)]
		public string FlightNumber { get; set; }

		[Required]
		public FlightType FlightType { get; set; }

        public List<MediaFile> FlightMedias { get; set; }

    }
}
