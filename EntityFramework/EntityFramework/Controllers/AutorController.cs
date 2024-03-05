using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private editorialContext _context { get; set; }
        public AutorController(editorialContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Autores> Get() => _context.Autores.ToList();
    }
}
