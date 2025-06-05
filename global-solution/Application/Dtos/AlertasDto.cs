namespace global_solution.Application.DTOs
{
    public class AlertaMeteorologicoDto
    {
        public int LeituraId { get; set; }
        public string EstacaoNome { get; set; }
        public DateTime DataHora { get; set; }
        public double Temperatura { get; set; }
        public double UmidadeRelativa { get; set; }
        public string CondicaoExtrema { get; set; }
    }
}
