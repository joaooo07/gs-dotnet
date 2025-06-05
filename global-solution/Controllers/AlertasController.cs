using global_solution.Application.DTOs;
using global_solution.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace global_solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertasController : ControllerBase
    {
        private readonly ILeituraTemperaturaService _leituraService;

        public AlertasController(ILeituraTemperaturaService leituraService)
        {
            _leituraService = leituraService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlertaMeteorologicoDto>>> Get()
        {
            var alertas = await _leituraService.ObterAlertasAsync();
            return Ok(alertas);
        }
    }
}
