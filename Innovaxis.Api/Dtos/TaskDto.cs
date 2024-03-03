using Innovaxis.Domain.Models;

namespace Innovaxis.Api.Dtos;

public class TaskDto
{
    public required string Title { get; set; }

    public required string Description { get; set; }

    public DateTime DueDate { get; set; }

    public required CategoryEntity Category { get; set; }
}