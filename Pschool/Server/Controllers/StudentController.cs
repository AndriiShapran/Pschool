using Microsoft.AspNetCore.Mvc;
using Pschool.Services;
using Pschool.Shared.DTOs;

namespace Pschool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> GetAll()
        {
            return await studentService.GetAllStudents();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> Get(int id)
        {
            return new ObjectResult(await studentService.GetSudent(id));
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<StudentDto>> Post(StudentDto student)
        {
            return Ok(await studentService.Add(student));
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<StudentDto>> Put(StudentDto student)
        {
            return await studentService.Edit(student);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentDto>> Delete(int id)
        {
            return await studentService.Delete(id);
        }
    }
}
