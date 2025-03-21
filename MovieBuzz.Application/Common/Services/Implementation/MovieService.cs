using MovieBuzz.Application.Common.Interfaces;
using MovieBuzz.Application.Common.Services.Interfaces;
using MovieBuzz.Domain.Entities;

namespace MovieBuzz.Application.Common.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateMovie(Movie movie)
        {
            _unitOfWork.Movie.Add(movie);
            _unitOfWork.Save();
        }

        public bool DeleteMovie(int id)
        {
            Movie? objFromDb = _unitOfWork.Movie.Get(u => u.Id == id);
            _unitOfWork.Movie.Remove(objFromDb);
            _unitOfWork.Save();
            return true;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _unitOfWork.Movie.GetAll();
        }

        public Movie GetMovieById(int id)
        {
            return _unitOfWork.Movie.Get(u => u.Id == id);
        }

        public void UpdateMovie(Movie movie)
        {
            _unitOfWork.Movie.Update(movie);
            _unitOfWork.Save();
        }
    }
}
