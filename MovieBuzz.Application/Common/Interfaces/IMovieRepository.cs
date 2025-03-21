using MovieBuzz.Domain.Entities;

namespace MovieBuzz.Application.Common.Interfaces
{
    public interface IMovieRepository : IRepository<Movie> 
    {
        void Update(Movie entity);
    }
}
