using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet,Route("GetStudents")]
        public IActionResult GetStudents()
        {
            string[] students = { "Rohan", "karan", "jeson" };
            return StatusCode(200, students);
        }
        //public IActionResult GetFirstStudent()
        //{
        //    string[] students = { "karan", "rohan", "jeson" };
        //    return StatusCode(200, students);
        //}

        [HttpPost,Route("add")]
        public IActionResult Add(string name)
        {
            return Ok("Student Added");
        }
    }
    
}
