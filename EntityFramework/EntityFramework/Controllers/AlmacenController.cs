using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {
        private editorialContext _context { get; set; }
        public AlmacenController(editorialContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Almacenes> Get() => _context.Almacenes.ToList();

    }
}
