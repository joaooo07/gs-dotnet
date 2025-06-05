using System.Collections.Generic;
using global_solution.Domain.Entities;

namespace global_solution.Application.Interfaces
{
    public interface IEstacaoMeteorologicaService
    {
        IEnumerable<EstacaoMeteorologica> GetAll();
        EstacaoMeteorologica GetById(int id);
        void Add(EstacaoMeteorologica estacao);
        void Update(EstacaoMeteorologica estacao);
        void Delete(int id);
    }
}
