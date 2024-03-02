using Innovaxis.Infrastructure.Common;

namespace Innovaxis.Infrastructure.Models;

public class TaskEntity : BaseEntity
{
    public required string Title { get; set; }

    public required string Description { get; set; }

    public DateTime DueDate { get; set; }

    public Guid CategoryId { get; set; }
    public required CategoryEntity Category { get; set; }

    public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
}