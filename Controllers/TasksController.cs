using Microsoft.AspNetCore.Mvc;
using TaskManager.Services;

namespace TaskManager.Controllers;

/// <summary>
/// Controller para gerenciar tarefas via API REST
/// Demonstra: REST API, HTTP Methods, Async/Await
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    /// <summary>
    /// GET api/tasks - Retorna todas as tarefas
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<List<Models.Task>>> GetAll()
    {
        var tasks = await _taskService.GetAllTasksAsync();
        return Ok(tasks);
    }

    /// <summary>
    /// GET api/tasks/{id} - Retorna tarefa específica
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<Models.Task>> GetById(int id)
    {
        var task = await _taskService.GetTaskByIdAsync(id);
        if (task == null)
            return NotFound(new { message = $"Tarefa {id} não encontrada" });

        return Ok(task);
    }

    /// <summary>
    /// POST api/tasks - Cria nova tarefa
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<Models.Task>> Create([FromBody] CreateTaskDto dto)
    {
        var task = new Models.Task
        {
            Title = dto.Title,
            Description = dto.Description,
            Priority = dto.Priority,
            DueDate = dto.DueDate,
            AssignedUserId = dto.AssignedUserId
        };

        var created = await _taskService.CreateTaskAsync(task);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    /// <summary>
    /// PUT api/tasks/{id} - Atualiza tarefa
    /// </summary>
    [HttpPut("{id}")]
    public async Task<ActionResult<Models.Task>> Update(int id, [FromBody] UpdateTaskDto dto)
    {
        var task = new Models.Task
        {
            Title = dto.Title,
            Description = dto.Description,
            Status = dto.Status,
            Priority = dto.Priority,
            DueDate = dto.DueDate,
            AssignedUserId = dto.AssignedUserId
        };

        var updated = await _taskService.UpdateTaskAsync(id, task);
        if (updated == null)
            return NotFound(new { message = $"Tarefa {id} não encontrada" });

        return Ok(updated);
    }

    /// <summary>
    /// DELETE api/tasks/{id} - Remove tarefa
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _taskService.DeleteTaskAsync(id);
        if (!deleted)
            return NotFound(new { message = $"Tarefa {id} não encontrada" });

        return NoContent();
    }

    /// <summary>
    /// GET api/tasks/user/{userId} - Retorna tarefas de um usuário
    /// </summary>
    [HttpGet("user/{userId}")]
    public async Task<ActionResult<List<Models.Task>>> GetByUser(int userId)
    {
        var tasks = await _taskService.GetTasksByUserAsync(userId);
        return Ok(tasks);
    }

    /// <summary>
    /// GET api/tasks/overdue - Retorna tarefas atrasadas
    /// </summary>
    [HttpGet("overdue")]
    public async Task<ActionResult<List<Models.Task>>> GetOverdue()
    {
        var tasks = await _taskService.GetOverdueTasksAsync();
        return Ok(tasks);
    }
}

// DTOs para Request
public record CreateTaskDto(
    string Title,
    string Description,
    Models.TaskPriority Priority,
    DateTime? DueDate,
    int? AssignedUserId
);

public record UpdateTaskDto(
    string Title,
    string Description,
    Models.TaskStatus Status,
    Models.TaskPriority Priority,
    DateTime? DueDate,
    int? AssignedUserId
);
