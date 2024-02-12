using System.Collections.Generic;

namespace serverside.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<string> GetPopularMovies();
        IEnumerable<string> SearchMovies(string query);
        string GetMovieById(int id);
    }
}
