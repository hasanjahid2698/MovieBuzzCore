using MovieBuzz.Domain.Entities;

namespace MovieBuzz.Application.Common.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void CreateMovie(Movie movie);
        void UpdateMovie(Movie movie);
        bool DeleteMovie(int id);
    }
}
