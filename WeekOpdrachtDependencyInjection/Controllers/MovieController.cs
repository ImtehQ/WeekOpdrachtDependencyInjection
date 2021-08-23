using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService movieService;

        public MovieController()
        {
            movieService = new MovieService();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int value)
        {
            var movie = movieService.Get(value);
            return Ok(movie);
        }
        [HttpGet]
        [Route("{title}")]
        public IActionResult GetByTitle(string value)
        {
            var movie = movieService.Get(value);
            return Ok(movie);
        }
    }
}
