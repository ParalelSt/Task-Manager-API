using Microsoft.AspNetCore.Mvc;
using Task_Manager_API.Data;
using Task_Manager_API.DTOs;
using Task_Manager_API.Services;

namespace Task_Manager_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet("get-tasks")]
    public async Task<ActionResult<List<TaskResponseDto>>> GetTasks()
        => await _taskService.getTasks();
    
    [HttpGet("get-task-by-id/{taskId}")]
    public async Task<ActionResult<TaskResponseDto>> GetTaskById(int taskId)
        => await _taskService.getTaskById(taskId);
    
    [HttpPost("create-task")]
    public async Task<ActionResult<CreateTaskResponseDto>> CreateTask(string taskTitle)
        => await _taskService.createTask(taskTitle);
    
    [HttpPatch("update-task/{taskId}")]
    public async Task<ActionResult<TaskResponseDto>> EditTask(int taskId, string taskTitle)
        => await _taskService.editTask(taskId, taskTitle);
    
    [HttpPatch("toggle-task-completion/{taskId}")]
    public async Task<ActionResult<TaskResponseDto>> ToggleCompletion(int taskId)
        => await _taskService.toggleCompletion(taskId);
    
    [HttpDelete("delete-task/{taskId}")]
    public async Task<ActionResult<string>> DeleteTask(int taskId)
        => await _taskService.deleteTask(taskId);
}