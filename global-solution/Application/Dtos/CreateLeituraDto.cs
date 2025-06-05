using System;

namespace global_solution.Application.Dtos
{
    public class CreateLeituraDto
    {
        public int EstacaoId { get; set; }
        public DateTime DataHora { get; set; }
        public double Temperatura { get; set; }
        public double UmidadeRelativa { get; set; }
    }
}
