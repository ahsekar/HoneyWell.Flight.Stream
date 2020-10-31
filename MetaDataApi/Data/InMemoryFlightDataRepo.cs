using HoneyWell.Flight.Stream.Core.Entities;
using HoneyWell.Flight.Stream.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataApi.Data
{
	public class InMemoryFlightDataRepo : IFlightRepo
	{
		private List<FlightDetails> _flightDetailsRepo;
		private List<Flight> _flightRepo;

		public InMemoryFlightDataRepo()
		{
			_flightRepo = new List<Flight>() {
					new Flight(){
						Id = 1,
						FlightNumber ="AI-301",
						FlightType = FlightType.Commercial
					}
			};

			_flightDetailsRepo = new List<FlightDetails>() {
				new FlightDetails(){
					Id = 1,
					Flight = _flightRepo.Where(i => i.FlightNumber == "AI-301").FirstOrDefault(),
					DataSize = 1000,
					DataTransferStatus = DataTransferStatus.Completed,
					FlightId = 1,
					CreatedDate = DateTime.Now,
					UpdatedDate= DateTime.Now
				}
			};
		}

		public bool SaveChanges()
		{
			return true;
		}

		public IEnumerable<FlightDetails> GetAllFlightData()
		{
			return _flightDetailsRepo;
		}

		public FlightDetails GetFlightDataByFlightNumber(string FlightNumber)
		{
			if (_flightDetailsRepo == null)
				return null;

			return _flightDetailsRepo.Where(s => s.Flight.FlightNumber == FlightNumber).FirstOrDefault();
		}

		public void AddFlightData(FlightDetails flightDetails)
		{
			if (flightDetails == null || flightDetails.Flight == null)
				throw new System.ArgumentNullException(nameof(flightDetails));

			if (flightDetails.Flight.Id == 0 && flightDetails.FlightId == 0)
				throw new System.ArgumentNullException(nameof(flightDetails.FlightId));

			if (flightDetails.FlightId == 0)
				flightDetails.FlightId = flightDetails.Flight.Id;

			if (flightDetails.Flight.Id != flightDetails.FlightId)
				throw new System.InvalidOperationException(nameof(flightDetails.FlightId));

			if(!_flightRepo.Exists(x => x.Id == flightDetails.FlightId))
				throw new System.InvalidOperationException(nameof(flightDetails.FlightId) + " Not Found!");

			_flightDetailsRepo.Add(flightDetails);
		}
	}
}
