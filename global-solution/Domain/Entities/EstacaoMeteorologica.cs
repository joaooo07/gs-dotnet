using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace global_solution.Domain.Entities
{
    public class EstacaoMeteorologica
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter até 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A localização é obrigatória.")]
        [StringLength(200, ErrorMessage = "A localização deve ter até 200 caracteres.")]
        public string Localizacao { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public ICollection<LeituraTemperatura> Leituras { get; set; } = new List<LeituraTemperatura>();
    }
}
