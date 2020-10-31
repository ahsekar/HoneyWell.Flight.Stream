using HoneyWell.Flight.Stream.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataApi.Data
{
	public class SQLFlightDataRepo : IFlightRepo
	{
		private readonly FlightDataContext _flightDBContext;

		public SQLFlightDataRepo(FlightDataContext schoolDBContext)
		{
			this._flightDBContext = schoolDBContext;
		}

		public bool SaveChanges()
		{
			return (_flightDBContext.SaveChanges() >= 0);
		}

		public IEnumerable<FlightDetails> GetAllFlightData()
		{
			return _flightDBContext.FlightDetail.Select(x => new FlightDetails()
			{
				Id = x.Id,
				Flight = _flightDBContext.Flight.Where(i => i.Id == x.FlightId).FirstOrDefault(),
				DataSize = x.DataSize,
				DataTransferStatus = x.DataTransferStatus,
				FlightId = x.FlightId,
				CreatedDate = x.CreatedDate,
				UpdatedDate = x.UpdatedDate
			})?.ToList();
		}

		public FlightDetails GetFlightDataByFlightNumber(string FlightNumber)
		{
			if (_flightDBContext.FlightDetail == null)
				return null;

			return _flightDBContext.FlightDetail.ToList().Where(s => s.Flight.FlightNumber == FlightNumber).FirstOrDefault();
		}

		public void AddFlightData(FlightDetails flightDetails)
		{
			if (flightDetails == null || flightDetails.Flight == null)
				throw new System.ArgumentNullException(nameof(flightDetails));

			if(flightDetails.Flight.Id == 0 && flightDetails.FlightId == 0)
				throw new System.ArgumentNullException(nameof(flightDetails.FlightId));
			
			if (flightDetails.FlightId == 0)
				flightDetails.FlightId = flightDetails.Flight.Id;

			if (flightDetails.Flight.Id != flightDetails.FlightId)
				throw new System.InvalidOperationException(nameof(flightDetails.FlightId));

			_flightDBContext.Add(flightDetails);
		}
	}
}
