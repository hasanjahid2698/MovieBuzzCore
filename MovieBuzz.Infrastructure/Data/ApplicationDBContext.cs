using Microsoft.EntityFrameworkCore;
using MovieBuzz.Domain.Entities;

namespace MovieBuzz.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
