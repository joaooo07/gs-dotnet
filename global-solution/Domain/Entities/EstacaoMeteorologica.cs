using System;
using System.Collections.Generic;

namespace global_solution.Domain.Entities
{
    public class EstacaoMeteorologica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public ICollection<LeituraTemperatura> Leituras { get; set; }
    }
}
