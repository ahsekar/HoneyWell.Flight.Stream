using HoneyWell.Flight.Stream.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetaDataApi.Data
{
	public class FlightDataContext : DbContext
	{		
		public FlightDataContext(DbContextOptions<FlightDataContext> opt) : base(opt)
		{

		}

		public DbSet<FlightDetails> FlightDetail { get; set; }
		public DbSet<Flight> Flight { get; set; }
	}
}
