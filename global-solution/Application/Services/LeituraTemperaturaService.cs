using global_solution.Application.DTOs;
using global_solution.Application.Interfaces;
using global_solution.Domain.Entities;
using global_solution.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace global_solution.Application.Services
{
    public class LeituraTemperaturaService : ILeituraTemperaturaService
    {
        private readonly AppDbContext _context;

        public LeituraTemperaturaService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AlertaMeteorologicoDto>> ObterAlertasAsync()
        {
            var alertas = await _context.Leituras
                .Include(l => l.Estacao)
                .Where(l => l.CondicaoExtrema != "Normal")
                .Select(l => new AlertaMeteorologicoDto
                {
                    LeituraId = l.Id,
                    EstacaoNome = l.Estacao.Nome,
                    DataHora = l.DataHora,
                    Temperatura = l.Temperatura,
                    UmidadeRelativa = l.UmidadeRelativa,
                    CondicaoExtrema = l.CondicaoExtrema
                })
                .ToListAsync();

            return alertas;
        }


        public IEnumerable<LeituraTemperatura> GetAll()
        {
            return _context.Leituras
                .Include(l => l.Estacao)
                .ToList();
        }

        public LeituraTemperatura GetById(int id)
        {
            return _context.Leituras
                .Include(l => l.Estacao)
                .FirstOrDefault(l => l.Id == id);
        }

        public void Add(LeituraTemperatura leitura)
        {
            leitura.CondicaoExtrema = CalcularCondicao(leitura.Temperatura);
            _context.Leituras.Add(leitura);
            _context.SaveChanges();
        }

        public void Update(LeituraTemperatura leitura)
        {
            leitura.CondicaoExtrema = CalcularCondicao(leitura.Temperatura);
            _context.Leituras.Update(leitura);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var leitura = _context.Leituras.Find(id);
            if (leitura != null)
            {
                _context.Leituras.Remove(leitura);
                _context.SaveChanges();
            }
        }

        private string CalcularCondicao(double temperatura)
        {
            if (temperatura <= 5) return "FrioExtremo";
            if (temperatura >= 38) return "CalorExtremo";
            return "Normal";
        }
    }
}

