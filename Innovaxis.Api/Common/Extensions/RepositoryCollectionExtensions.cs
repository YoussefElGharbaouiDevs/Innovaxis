using Innovaxis.Domain.Repositories.Categories;
using Innovaxis.Domain.Repositories.Tasks;
using Innovaxis.Domain.Repositories.Users;
using Innovaxis.Infrastructure.Repositories.Categories;
using Innovaxis.Infrastructure.Repositories.Tasks;
using Innovaxis.Infrastructure.Repositories.Users;

namespace Innovaxis.Api.Common.Extensions;

public static class RepositoryCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // Register your repositories here
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        // Add more repository registrations as needed

        return services;
    }
}