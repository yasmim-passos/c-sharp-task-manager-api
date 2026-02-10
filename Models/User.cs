namespace TaskManager.Models;

/// <summary>
/// Classe base Person
/// Demonstra: Herança, Polimorfismo
/// </summary>
public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // Método virtual (pode ser sobrescrito)
    public virtual string GetInfo()
    {
        return $"{Name} ({Email})";
    }
}

/// <summary>
/// User herda de Person
/// Demonstra: Herança, Override
/// </summary>
public class User : Person
{
    public string Role { get; set; } = "Developer";
    public DateTime CreatedAt { get; set; }
    public List<Task> Tasks { get; set; } = new();

    public User()
    {
        CreatedAt = DateTime.Now;
    }

    // Override do método da classe base
    public override string GetInfo()
    {
        return $"{Name} - {Role} ({Email})";
    }

    // Método específico de User
    public int GetPendingTasksCount()
    {
        return Tasks.Count(t => t.Status == TaskStatus.Pending);
    }

    public int GetCompletedTasksCount()
    {
        return Tasks.Count(t => t.Status == TaskStatus.Completed);
    }
}
