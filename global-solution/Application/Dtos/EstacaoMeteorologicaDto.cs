using System;

namespace global_solution.Application.Dtos
{
    public class EstacaoMeteorologicaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
