using global_solution.Application.Dtos;
using global_solution.Application.Interfaces;
using global_solution.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace global_solution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstacaoMeteorologicaController : ControllerBase
    {
        private readonly IEstacaoMeteorologicaService _service;

        public EstacaoMeteorologicaController(IEstacaoMeteorologicaService service)
        {
            _service = service;
        }
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var estacoes = _service.GetAll();
        //    return Ok(estacoes);
        //}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var estacao = _service.GetById(id);
            if (estacao == null)
                return NotFound();
            return Ok(estacao);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateEstacaoDto dto)
        {
            if (dto == null)
                return BadRequest();

            var estacao = new EstacaoMeteorologica
            {
                Nome = dto.Nome,
                Localizacao = dto.Localizacao,
                DataCadastro = DateTime.Now
            };

            _service.Add(estacao);
            return CreatedAtAction(nameof(GetById), new { id = estacao.Id }, estacao);
        }

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, [FromBody] EstacaoMeteorologica estacao)
        //{
        //    if (estacao == null || estacao.Id != id)
        //        return BadRequest();

        //    var existente = _service.GetById(id);
        //    if (existente == null)
        //        return NotFound();

        //    _service.Update(estacao);
        //    return NoContent();
        //}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existente = _service.GetById(id);
            if (existente == null)
                return NotFound();

            _service.Delete(id);
            return NoContent();
        }
    }
}
