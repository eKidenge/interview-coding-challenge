using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace serverside.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // GET api/movie/popular
        [HttpGet("popular")]
        public ActionResult<IEnumerable<string>> GetPopularMovies()
        {
            // Implement logic to retrieve popular movies
            var popularMovies = new string[] { "Movie1", "Movie2" };
            return Ok(popularMovies);
        }

        // GET api/movie/search?query=your_query
        [HttpGet("search")]
        public ActionResult<IEnumerable<string>> SearchMovies([FromQuery] string query)
        {
            // Implement logic to search for movies based on the query
            var searchResults = new string[] { $"Search Result 1 for {query}", $"Search Result 2 for {query}" };
            return Ok(searchResults);
        }

        // GET api/movie/{id}
        [HttpGet("{id}")]
        public ActionResult<string> GetMovieById(int id)
        {
            // Implement logic to retrieve a specific movie by ID
            var movie = $"Movie with ID {id}";
            return Ok(movie);
        }

        // Additional actions for creating, updating, and deleting movies can be added

        // POST api/movie
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            // Implement logic to add a new movie
            return Ok($"Movie created with value: {value}");
        }

        // PUT api/movie/{id}
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            // Implement logic to update a movie
            return Ok($"Movie with ID {id} updated with value: {value}");
        }

        // DELETE api/movie/{id}
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            // Implement logic to delete a movie
            return Ok($"Movie with ID {id} deleted");
        }
    }
}
