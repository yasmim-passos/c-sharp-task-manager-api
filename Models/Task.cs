namespace TaskManager.Models;

/// <summary>
/// Representa uma tarefa no sistema
/// Demonstra: Encapsulamento, Properties, Construtores
/// </summary>
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DueDate { get; set; }
    public int? AssignedUserId { get; set; }
    public User? AssignedUser { get; set; }

    // Construtor padrão
    public Task()
    {
        CreatedAt = DateTime.Now;
        Status = TaskStatus.Pending;
    }

    // Construtor com parâmetros (sobrecarga)
    public Task(string title, string description)
    {
        Title = title;
        Description = description;
        CreatedAt = DateTime.Now;
        Status = TaskStatus.Pending;
    }

    // Método para verificar se está atrasada
    public bool IsOverdue()
    {
        if (DueDate == null) return false;
        return DueDate < DateTime.Now && Status != TaskStatus.Completed;
    }

    // Método para completar tarefa
    public void Complete()
    {
        Status = TaskStatus.Completed;
    }
}

/// <summary>
/// Enum para status da tarefa
/// </summary>
public enum TaskStatus
{
    Pending,
    InProgress,
    Completed,
    Cancelled
}

/// <summary>
/// Enum para prioridade
/// </summary>
public enum TaskPriority
{
    Low,
    Medium,
    High,
    Urgent
}
