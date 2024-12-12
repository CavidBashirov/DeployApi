using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeployApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> students = new()
            { "Eldar","Fadile","Samir","Nergiz","Elshad","Ferdi","Valeh","Aqil","Terxan","Nihat","Tukezban"};

            return Ok(students);
        }
    }
}
