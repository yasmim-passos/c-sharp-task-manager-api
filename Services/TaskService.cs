using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

namespace TaskManager.Services;

/// <summary>
/// Implementação do serviço de tarefas
/// Demonstra: Implementação de interface, Async/Await, LINQ
/// </summary>
public class TaskService : ITaskService
{
    private readonly AppDbContext _context;

    // Injeção de dependência via construtor
    public TaskService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Models.Task>> GetAllTasksAsync()
    {
        return await _context.Tasks
            .Include(t => t.AssignedUser)
            .ToListAsync();
    }

    public async Task<Models.Task?> GetTaskByIdAsync(int id)
    {
        return await _context.Tasks
            .Include(t => t.AssignedUser)
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<Models.Task> CreateTaskAsync(Models.Task task)
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
        return task;
    }

    public async Task<Models.Task?> UpdateTaskAsync(int id, Models.Task updatedTask)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task == null) return null;

        task.Title = updatedTask.Title;
        task.Description = updatedTask.Description;
        task.Status = updatedTask.Status;
        task.Priority = updatedTask.Priority;
        task.DueDate = updatedTask.DueDate;
        task.AssignedUserId = updatedTask.AssignedUserId;

        await _context.SaveChangesAsync();
        return task;
    }

    public async Task<bool> DeleteTaskAsync(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task == null) return false;

        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Models.Task>> GetTasksByUserAsync(int userId)
    {
        return await _context.Tasks
            .Where(t => t.AssignedUserId == userId)
            .Include(t => t.AssignedUser)
            .ToListAsync();
    }

    public async Task<List<Models.Task>> GetOverdueTasksAsync()
    {
        var now = DateTime.Now;
        return await _context.Tasks
            .Where(t => t.DueDate < now && t.Status != Models.TaskStatus.Completed)
            .Include(t => t.AssignedUser)
            .ToListAsync();
    }
}
