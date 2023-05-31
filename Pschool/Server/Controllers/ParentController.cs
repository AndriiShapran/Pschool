using Microsoft.AspNetCore.Mvc;
using Pschool.Services;
using Pschool.Shared.DTOs;

namespace Pschool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : Controller
    {
        private IParentService parentService;
        public ParentController(IParentService parentService)
        {
            this.parentService = parentService;
        }
        [HttpGet]
        public async Task<ActionResult<List<ParentDto>>> GetAll()
        {
            return await parentService.GetAllParents();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParentDto>> Get(int id)
        {
            return new ObjectResult(await parentService.GetParent(id));
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<ParentDto>> Post(ParentDto parent)
        {

            return Ok(await parentService.Add(parent));
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<ParentDto>> Put(ParentDto parent)
        {
            return await parentService.Edit(parent);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ParentDto>> Delete(int id)
        {
            return await parentService.Delete(id);
        }
    }
}
