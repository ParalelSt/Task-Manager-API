using Task_Manager_API.DTOs;

namespace Task_Manager_API.Services;

public class TaskService: ITaskService
{
    public Task<CreateTaskResponseDto> createTask(string taskTitle)
    {
        throw new NotImplementedException();
    }

    public Task<List<TaskResponseDto>> getTasks()
    {
        throw new NotImplementedException();
    }

    public Task<TaskResponseDto> getTaskById(int taskId)
    {
        throw new NotImplementedException();
    }

    public Task<TaskResponseDto> editTask(int taskId, string taskTitle)
    {
        throw new NotImplementedException();
    }

    public Task<TaskResponseDto> toggleCompletion(int taskId)
    {
        throw new NotImplementedException();
    }

    public Task<string> deleteTask(int taskId)
    {
        throw new NotImplementedException();
    }
}