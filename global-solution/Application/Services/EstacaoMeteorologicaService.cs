using global_solution.Application.Interfaces;
using global_solution.Domain.Entities;
using global_solution.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace global_solution.Application.Services
{
    public class EstacaoMeteorologicaService : IEstacaoMeteorologicaService
    {
        private readonly AppDbContext _context;

        public EstacaoMeteorologicaService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EstacaoMeteorologica> GetAll()
        {
            return _context.Estacoes
                .Include(e => e.Leituras)
                .ToList();
        }

        public EstacaoMeteorologica GetById(int id)
        {
            return _context.Estacoes
                .Include(e => e.Leituras)
                .FirstOrDefault(e => e.Id == id);
        }

        public void Add(EstacaoMeteorologica estacao)
        {
            estacao.DataCadastro = DateTime.Now;
            _context.Estacoes.Add(estacao);
            _context.SaveChanges();
        }

        public void Update(EstacaoMeteorologica estacao)
        {
            _context.Estacoes.Update(estacao);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var estacao = _context.Estacoes.Find(id);
            if (estacao != null)
            {
                _context.Estacoes.Remove(estacao);
                _context.SaveChanges();
            }
        }
    }
}
