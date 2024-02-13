using ASPAPI.Models;
using ASPAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class MovieController : ControllerBase
    {
        public MovieController()
        {
            // something
        }

        [HttpGet] // GET ALL
        public ActionResult<List<Movie>> GetAll() => MovieServices.GetAll();

        [HttpGet("{id}")] // GET ID
        public ActionResult<Movie?> Get(int id) => MovieServices.Get(id);
        
        [HttpPost] // POST
        public void Post(Movie movie) => MovieServices.Add(movie);
        
        [HttpPatch] // PATCH
        public void Patch(Movie movie) => MovieServices.Update(movie);
        
        [HttpDelete] // DELETE
        public void Delete(int id) => MovieServices.Delete(id);
        
    }
}
