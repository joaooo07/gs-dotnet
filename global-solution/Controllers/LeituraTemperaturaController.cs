using global_solution.Application.Dtos;
using global_solution.Application.Interfaces;
using global_solution.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace global_solution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeituraTemperaturaController : ControllerBase
    {
        private readonly ILeituraTemperaturaService _service;

        public LeituraTemperaturaController(ILeituraTemperaturaService service)
        {
            _service = service;
        }

        //// GET: api/LeituraTemperatura
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var leituras = _service.GetAll();
        //    return Ok(leituras);
        //}

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var leitura = _service.GetById(id);
            if (leitura == null)
                return NotFound();

            var leituraDto = new LeituraTemperaturaDto
            {
                Id = leitura.Id,
                EstacaoId = leitura.EstacaoId,
                DataHora = leitura.DataHora,
                Temperatura = leitura.Temperatura,
                UmidadeRelativa = leitura.UmidadeRelativa,
                CondicaoExtrema = leitura.CondicaoExtrema
            };

            return Ok(leituraDto);
        }


        // POST: api/LeituraTemperatura
        [HttpPost]
        public IActionResult Create([FromBody] CreateLeituraDto dto)
        {
            if (dto == null)
                return BadRequest();

            var leitura = new LeituraTemperatura
            {
                EstacaoId = dto.EstacaoId,
                DataHora = dto.DataHora,
                Temperatura = dto.Temperatura,
                UmidadeRelativa = dto.UmidadeRelativa
                // Condição extrema será calculada no service
            };

            _service.Add(leitura);
            return CreatedAtAction(nameof(GetById), new { id = leitura.Id }, leitura);
        }

        // PUT: api/LeituraTemperatura/5
        //[HttpPut("{id}")]
        //public IActionResult Update(int id, [FromBody] LeituraTemperatura leitura)
        //{
        //    if (leitura == null || leitura.Id != id)
        //        return BadRequest();

        //    var existente = _service.GetById(id);
        //    if (existente == null)
        //        return NotFound();

        //    _service.Update(leitura);
        //    return NoContent();
        //}


        // DELETE: api/LeituraTemperatura/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var leitura = _service.GetById(id);
            if (leitura == null)
                return NotFound();

            _service.Delete(id);
            return NoContent();
        }
    }
}
    