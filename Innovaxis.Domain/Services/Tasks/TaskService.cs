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

    public async Task<IEnumerable<TaskEntity>> FindAllTasksAsync()
    {
        return await _taskRepository.FindAllAsync();
    }

    public async Task<TaskEntity?> FindATaskAsync(Guid id)
    {
        return await _taskRepository.FindAsync(id);
    }

    public async Task AddTaskAsync(TaskEntity task)
    {
        await _taskRepository.AddAsync(task);
    }

    public async Task AddTasksAsync(IEnumerable<TaskEntity> tasks)
    {
        await _taskRepository.AddRangeAsync(tasks);
    }

    public async Task UpdateTaskAsync(TaskEntity task)
    {
        await _taskRepository.UpdateAsync(task);
    }

    public async Task UpdateTasksAsync(IEnumerable<TaskEntity> tasks)
    {
        await _taskRepository.UpdateRangeAsync(tasks);
    }

    public async Task RemoveTaskAsync(TaskEntity task)
    {
        await _taskRepository.RemoveAsync(task);
    }

    public async Task RemoveTasksRange(IEnumerable<TaskEntity> tasks)
    {
        await _taskRepository.RemoveRange(tasks);
    }
}