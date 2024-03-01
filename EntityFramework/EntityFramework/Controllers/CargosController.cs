using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargosController : ControllerBase
    {
        private editorialContext _context;
        public CargosController(editorialContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Cargos> Get() => _context.Cargos.ToList();
    }
}
