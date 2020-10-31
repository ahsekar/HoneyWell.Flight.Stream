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
			return _flightDBContext.FlightDetail?.ToList();
		}

		public FlightDetails GetFlightDataByFlightNumber(string FlightNumber)
		{
			if (_flightDBContext.FlightDetail == null)
				return null;

			return _flightDBContext.FlightDetail.ToList().Where(s => s.Flight.FlightNumber == FlightNumber).FirstOrDefault();
		}

		public void AddFlightData(FlightDetails flightDetails)
		{
			if (flightDetails == null)
				throw new System.ArgumentNullException(nameof(flightDetails));

			_flightDBContext.Add(flightDetails);
		}
	}
}
