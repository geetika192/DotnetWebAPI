using Microsoft.AspNetCore.Mvc;
namespace RD.Controllers
{
    [ApiController]
     [Route("Taaza/[controller]")]
  
    public class UserController: ControllerBase
    {
        [HttpGet]
        [Route("Fetch/{id:int}")]
        public IActionResult FetchData(int? id)
        {
           return(Ok(id));
        }
    }
}