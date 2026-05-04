using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud_.Data;
using RazorCrud_.Tarefas;

namespace RazorCrud_.Pages.Tarefas;
public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public List<Tarefa> Tarefas { get; set; } = new();

    [BindProperty]
    public Tarefa NovaTarefa { get; set; } = new();

    [BindProperty]
    public Tarefa TarefaEditada { get; set; } = new();

    public async Task OnGetAsync()
    {
        Tarefas = await _context.Tarefas
                .AsNoTracking()
                .OrderBy(t => t.Id)
                .ToListAsync();
    }
    public async Task<IActionResult> OnPostCreateAsync()
    {
        var tarefa = new Tarefa
        {
            Titulo = NovaTarefa.Titulo,
            Status = NovaTarefa.Status
        };
        
        _context.Tarefas.Add(tarefa);
        await _context.SaveChangesAsync();

        return RedirectToPage();
    }
    public async Task<IActionResult> OnPostEditAsync()
    {
        var tarefa = await _context.Tarefas.FindAsync(TarefaEditada.Id);
        if (tarefa == null)
        {
            return NotFound();
        }
        
        await _context.SaveChangesAsync();

        return RedirectToPage();
    }
    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var tarefa = await _context
                .Tarefas
                .FindAsync(id);

        if (tarefa == null)
        {
            return NotFound();
        }

        _context.Tarefas.Remove(tarefa);
        await _context.SaveChangesAsync();

        return RedirectToPage();
    }


}
