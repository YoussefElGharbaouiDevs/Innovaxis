using Innovaxis.Domain.Models;

namespace Innovaxis.Domain.Services.Tasks;

public interface ITaskService
{
    Task<IEnumerable<TaskEntity>> FindAllTasksAsync();

    Task<TaskEntity?> FindATaskAsync(Guid id);

    Task AddTaskAsync(TaskEntity task);

    Task AddTasksAsync(IEnumerable<TaskEntity> tasks);

    Task UpdateTaskAsync(TaskEntity task);

    Task UpdateTasksAsync(IEnumerable<TaskEntity> tasks);

    Task RemoveTaskAsync(TaskEntity task);

    Task RemoveTasksRange(IEnumerable<TaskEntity> tasks);
}