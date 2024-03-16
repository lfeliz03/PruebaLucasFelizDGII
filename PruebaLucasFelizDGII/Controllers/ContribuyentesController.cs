using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaLucasFelizDGII.Models;

namespace PruebaLucasFelizDGII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuyentesController : ControllerBase
    {

        private readonly DGIIDbContext _dbContext;

        public ContribuyentesController(DGIIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contribuyentes>>> GetContribuyentes()
        {
            return await _dbContext.Contribuyentes.ToListAsync();
        }

        [HttpGet("{rncCedula}")]
        public async Task<ActionResult<IEnumerable<Comprobantes>>> GetComprobantes(long rncCedula)
        {
            return await _dbContext.Comprobantes.Where(c => c.RNCCedula.Equals(rncCedula)).ToListAsync();
        }
    }
}
