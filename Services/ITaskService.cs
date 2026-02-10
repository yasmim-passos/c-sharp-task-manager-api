namespace TaskManager.Services;

/// <summary>
/// Interface para serviço de tarefas
/// Demonstra: Abstração, Interfaces, Contratos
/// </summary>
public interface ITaskService
{
    Task<List<Models.Task>> GetAllTasksAsync();
    Task<Models.Task?> GetTaskByIdAsync(int id);
    Task<Models.Task> CreateTaskAsync(Models.Task task);
    Task<Models.Task?> UpdateTaskAsync(int id, Models.Task task);
    Task<bool> DeleteTaskAsync(int id);
    Task<List<Models.Task>> GetTasksByUserAsync(int userId);
    Task<List<Models.Task>> GetOverdueTasksAsync();
}
