using MovieManagementService.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MovieManagementService.Models;
using System;

namespace MovieManagementService.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class MovieController : ControllerBase
    {
        IMovieRepository _imovierepository;
        public MovieController(IMovieRepository imovierepository)
        {
            _imovierepository = imovierepository;
        }
        [HttpPost]
        [Route("Create")]

        public IActionResult CreateMovie(Movie movie)
        {
            var result = _imovierepository.AddMovie(movie);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteMovie(int id)
        {
            var del = _imovierepository.DeleteMovie(id);
            return Ok("Record deleted");
        }
         [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie( Movie mov)
        {
            _imovierepository.UpdateMovie( mov);
            return Ok("Record Updated");
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var get = _imovierepository.GetAllMovie();
            return Ok(get);
        }
    }
}