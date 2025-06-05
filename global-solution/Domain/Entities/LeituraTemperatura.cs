using System;

namespace global_solution.Domain.Entities
{
    public class LeituraTemperatura
    {
        public int Id { get; set; }

        public int EstacaoId { get; set; }
        public EstacaoMeteorologica Estacao { get; set; }

        public DateTime DataHora { get; set; }
        public double Temperatura { get; set; }
        public double UmidadeRelativa { get; set; }

        // "FrioExtremo", "CalorExtremo" , "Normal"
        public string CondicaoExtrema { get; set; }
    }
}
