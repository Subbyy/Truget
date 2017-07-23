using Microsoft.EntityFrameworkCore;
using Truget.Data.Models;

namespace Truget.Data
{
    public class TrucksContext : DbContext
    {
        public TrucksContext(DbContextOptions options) : 
            base(options) {}

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckType> TruckTypes { get; set; }
        public DbSet<TruckSize> TruckSizes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
