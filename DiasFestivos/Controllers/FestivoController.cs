using DiasFestivos.Core.Interfaces.Servicios;
using DiasFestivos.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DiasFestivos.Controllers
{
    [ApiController]
    [Route("api/festivos")]
    public class FestivoController : ControllerBase
    {
        private readonly IFestivoServicio servicio;
        public FestivoController(IFestivoServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<TBFestivos>>> ObtenerTodos()
        {
            return Ok(await servicio.ObtenerTodos());
        }
    }
}
