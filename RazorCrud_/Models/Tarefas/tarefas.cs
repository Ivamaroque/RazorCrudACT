namespace RazorCrud_.Tarefas;

public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Status { get; set; } = "Pendente";
    
}
