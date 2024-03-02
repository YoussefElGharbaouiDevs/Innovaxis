using Innovaxis.Domain.Models;
using Innovaxis.Domain.Repositories.Tasks;

namespace Innovaxis.Domain.Services.Tasks;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    //TODO : Implement the service methods
    public Task<IEnumerable<TaskEntity>> FindAllTasksAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TaskEntity?> FindATaskAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddTaskAsync(TaskEntity task)
    {
        throw new NotImplementedException();
    }

    public Task AddTasksAsync(IEnumerable<TaskEntity> tasks)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTaskAsync(TaskEntity task)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTasksAsync(IEnumerable<TaskEntity> tasks)
    {
        throw new NotImplementedException();
    }

    public Task RemoveTaskAsync(TaskEntity task)
    {
        throw new NotImplementedException();
    }

    public Task RemoveTasksRange(IEnumerable<TaskEntity> tasks)
    {
        throw new NotImplementedException();
    }
}