using Microsoft.EntityFrameworkCore;
using RazorCrud_.Tarefas;

namespace RazorCrud_.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Tarefa> Tarefas { get; set; }
}