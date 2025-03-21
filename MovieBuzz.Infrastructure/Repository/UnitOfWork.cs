using MovieBuzz.Application.Common.Interfaces;
using MovieBuzz.Infrastructure.Data;

namespace MovieBuzz.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _db;
        public IMovieRepository Movie { get; private set; }

        //public IMovieNumberRepository MovieNumber { get; private set; }

        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            Movie = new MovieRepository(_db);
            //MovieNumber = new MovieNumberRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
