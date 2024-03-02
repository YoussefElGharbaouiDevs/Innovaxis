using Innovaxis.Infrastructure.Common;

namespace Innovaxis.Infrastructure.Models;

public class CategoryEntity : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}