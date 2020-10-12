using Microsoft.EntityFrameworkCore;
using RestDotnet.Models;

namespace RestDotnet.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> optionsBuilder) : base(optionsBuilder)
        { }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Car> Cars { get; set; }


    }
}