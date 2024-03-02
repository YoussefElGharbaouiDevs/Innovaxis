using Innovaxis.Infrastructure.Common;

namespace Innovaxis.Infrastructure.Models;

public class UserEntity : BaseEntity
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Acitivity { get; set; }

    public Guid TaskId { get; set; }
    public ICollection<TaskEntity> Tasks { get; set; } = new List<TaskEntity>();
}