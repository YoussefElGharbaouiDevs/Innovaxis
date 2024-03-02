using Innovaxis.Domain.Models.Common;

namespace Innovaxis.Domain.Models;

public class CategoryEntity : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<TaskEntity> Tasks { get; set; } = new List<TaskEntity>();
}