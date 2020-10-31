using HoneyWell.Flight.Stream.PriorityService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HoneyWell.Flight.Stream.PriorityService.Data
{
    public class PriorityServiceDbContext : DbContext
    {
        public PriorityServiceDbContext(DbContextOptions<PriorityServiceDbContext> context) : base(context)
        {

        }
        public DbSet<FlightMetadata> FlightMetadata { get; set; }
    }
}
