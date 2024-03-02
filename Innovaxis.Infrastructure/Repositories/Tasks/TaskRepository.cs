using Innovaxis.Domain.Models;
using Innovaxis.Domain.Repositories.Tasks;
using Innovaxis.Infrastructure.Common;
using Innovaxis.Infrastructure.Context;

namespace Innovaxis.Infrastructure.Repositories.Tasks;

public class TaskRepository: GenericRepository<TaskEntity>, ITaskRepository
{
    public TaskRepository(InnovaxisDbContext innovaxisDbContext) : base(innovaxisDbContext)
    {
    }
}