using Microsoft.AspNetCore.Mvc;
using Pschool.Services;
using Pschool.Shared.DTOs;

namespace Pschool.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotiController : Controller
    {
        private INotiService notiService;
        public NotiController(INotiService notiService)
        {
            this.notiService = notiService;
        }
        [HttpGet]
        public async Task<ActionResult<List<NotiDto>>> GetAll()
        {
            return await notiService.GetAllNotis();
        }
    }
}
