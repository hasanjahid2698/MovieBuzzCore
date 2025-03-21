using MovieBuzz.Application.Common.Interfaces;
using MovieBuzz.Domain.Entities;
using MovieBuzz.Infrastructure.Data;

namespace MovieBuzz.Infrastructure.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public MovieRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }
        public void Update(Movie entity)
        {
            _dbContext.Update(entity);
        }
    }
}
