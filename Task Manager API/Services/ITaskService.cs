using Task_Manager_API.DTOs;
using Task_Manager_API.Entities;

namespace Task_Manager_API.Services;

public interface ITaskService
{
    Task<CreateTaskResponseDto> createTask(string taskTitle);
    Task<List<TaskResponseDto>> getTasks();
    Task<TaskResponseDto> getTaskById(int taskId);
    Task<TaskResponseDto> editTask(int taskId, string taskTitle);
    Task<TaskResponseDto> toggleCompletion(int taskId);
    Task<string> deleteTask(int taskId);
}