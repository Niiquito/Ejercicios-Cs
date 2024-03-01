using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tituloController : ControllerBase
    {
        private editorialContext _context;
        public tituloController(editorialContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<titulos> Get() => _context.titulos.ToList();
    }
}
