using global_solution.Domain.Entities;
using global_solution.Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace global_solution.Pages
{
    public class CreateEstacaoModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public EstacaoMeteorologica Estacao { get; set; } = new();

        public bool Sucesso { get; set; }

        public CreateEstacaoModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            Estacao.DataCadastro = DateTime.Now;
            _context.Estacoes.Add(Estacao);
            await _context.SaveChangesAsync();

            Sucesso = true;
            Estacao = new(); 
            return Page();
        }
    }
}
