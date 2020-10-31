using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using SampleStudentAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetaDataApi.Controllers
{
	[Route("api/MetaData")]
	[ApiController]
	public class MetaDataController : ControllerBase
	{
		private readonly IFlightRepo _repository;

		public MetaDataController(IFlightRepo studentRepo)
		{
			_repository = studentRepo;
		}

		[HttpGet]
		public ActionResult<IEnumerable<FlightDetails>> GetAllFlightData()
		{
			var result = _repository.GetAllFlightData();

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpGet("{id}", Name = "GetFlightDataByFlightNumber")]
		public ActionResult<FlightDetails> GetFlightDataByFlightNumber(string FlightNumber)
		{
			var result = _repository.GetFlightDataByFlightNumber(FlightNumber);

			if (result != null)
				return Ok(result);

			return NotFound();
		}

		[HttpPost]
		public ActionResult CreateStudent(FlightDetails flightDetails)
		{
			_repository.AddFlightData(flightDetails);
			_repository.SaveChanges();

			return CreatedAtRoute(nameof(GetFlightDataByFlightNumber), new { FlightNumber = flightDetails.Flight.FlightNumber }, flightDetails);
		}
	}
}
