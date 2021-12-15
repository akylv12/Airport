using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Airport.Models;

namespace Airport.Data
{
    public class AirportContext : DbContext
    {
        public AirportContext (DbContextOptions<AirportContext> options)
            : base(options)
        {
        }

        public DbSet<Airport.Models.User> User { get; set; }
    }
}
