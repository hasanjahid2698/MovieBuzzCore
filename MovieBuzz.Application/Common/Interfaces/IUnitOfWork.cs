namespace MovieBuzz.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IMovieRepository Movie { get; }
        void Save();
    }
}
