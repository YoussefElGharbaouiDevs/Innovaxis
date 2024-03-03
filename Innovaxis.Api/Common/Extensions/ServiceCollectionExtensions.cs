using Innovaxis.Domain.Services.Categeries;
using Innovaxis.Domain.Services.Tasks;
using Innovaxis.Domain.Services.Users;

namespace Innovaxis.Api.Common.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTaskManagementServices(this IServiceCollection services)
    {
        // Register your services here
        services.AddScoped<ITaskService, TaskService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICategoryService, CategoryService>();

        // Add more service registrations as needed

        return services;
    }
}