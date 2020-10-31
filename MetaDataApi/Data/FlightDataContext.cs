using HoneyWell.Flight.Stream.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace SampleStudentAPI.Data
{
	public class FlightDataContext : DbContext
	{		
		public FlightDataContext(DbContextOptions<FlightDataContext> opt) : base(opt)
		{

		}

		public DbSet<FlightDetails> Students { get; set; }
	}
}
