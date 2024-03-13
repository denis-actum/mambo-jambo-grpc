using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Movies.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static readonly List<Movie> _topMovies = new List<Movie>
    {
        new Movie { Title = "The Shawshank Redemption", Year = 1994, Director = "Frank Darabont" },
        new Movie { Title = "The Godfather", Year = 1972, Director = "Francis Ford Coppola" },
        new Movie { Title = "The Godfather: Part II", Year = 1974, Director = "Francis Ford Coppola" },
        new Movie { Title = "The Dark Knight", Year = 2008, Director = "Christopher Nolan" },
        new Movie { Title = "12 Angry Men", Year = 1957, Director = "Sidney Lumet" },
        new Movie { Title = "Schindler's List", Year = 1993, Director = "Steven Spielberg" },
        new Movie { Title = "The Lord of the Rings: The Return of the King", Year = 2003, Director = "Peter Jackson" },
        new Movie { Title = "Pulp Fiction", Year = 1994, Director = "Quentin Tarantino" },
        new Movie { Title = "The Good, the Bad and the Ugly", Year = 1966, Director = "Sergio Leone" },
        new Movie { Title = "The Lord of the Rings: The Fellowship of the Ring", Year = 2001, Director = "Peter Jackson" },
        new Movie { Title = "Fight Club", Year = 1999, Director = "David Fincher" },
        new Movie { Title = "Forrest Gump", Year = 1994, Director = "Robert Zemeckis" },
        new Movie { Title = "Inception", Year = 2010, Director = "Christopher Nolan" },
        new Movie { Title = "The Lord of the Rings: The Two Towers", Year = 2002, Director = "Peter Jackson" },
        new Movie { Title = "Star Wars: Episode V - The Empire Strikes Back", Year = 1980, Director = "Irvin Kershner" },
        new Movie { Title = "The Matrix", Year = 1999, Director = "Lana and Lilly Wachowski" },
        new Movie { Title = "Goodfellas", Year = 1990, Director = "Martin Scorsese" },
        new Movie { Title = "One Flew Over the Cuckoo's Nest", Year = 1975, Director = "Milos Forman" },
        new Movie { Title = "Seven Samurai", Year = 1954, Director = "Akira Kurosawa" },
        new Movie { Title = "City of God", Year = 2002, Director = "Fernando Meirelles and Kátia Lund" },
    };

        [HttpPost]
        public Task<TopMoviesResponse> GetTopMovies(TopMoviesRequest request)
        {
            var response = new TopMoviesResponse();
            response.Movies = _topMovies.Take(request.Count).ToList();
            return Task.FromResult(response);
        }
    }
}
