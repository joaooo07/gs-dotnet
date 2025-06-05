using global_solution.Application.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;

namespace global_solution.Pages
{
    public class AlertasModel : PageModel
    {
        public List<AlertaMeteorologicoDto> Alertas { get; set; } = new();

        public async Task OnGetAsync()
        {
            var baseUrl = "http://localhost:5164";

            using var http = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            });

            try
            {
                var result = await http.GetFromJsonAsync<List<AlertaMeteorologicoDto>>($"{baseUrl}/api/alertas");
                Alertas = result ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar alertas: " + ex.Message);
            }
        }
    }
}
