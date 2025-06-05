using global_solution.Application.DTOs;
using global_solution.Domain.Entities;
using System.Collections.Generic;

namespace global_solution.Application.Interfaces
{
    public interface ILeituraTemperaturaService
    {
        IEnumerable<LeituraTemperatura> GetAll();
        LeituraTemperatura GetById(int id);
        void Add(LeituraTemperatura leitura);
        void Update(LeituraTemperatura leitura);
        void Delete(int id);
        Task<IEnumerable<AlertaMeteorologicoDto>> ObterAlertasAsync();

    }
}
