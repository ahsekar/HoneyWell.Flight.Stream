using HoneyWell.Flight.Stream.Core.Enums;
using System;
using System.Collections;
using System.Collections;
using System.Collections.Generic;


namespace HoneyWell.Flight.Stream.Core
{
	public class Flight
	{
		public string FlightNumber { get; set; }
		public FlightType FlightType { get; set; }

        public List<MediaFile> FlightMedias { get; set; }

    }
}
