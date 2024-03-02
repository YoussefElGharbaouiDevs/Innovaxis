using Innovaxis.Domain.Models;

namespace Innovaxis.Domain.Services.Users;

public interface IUserService
{
    Task<IEnumerable<UserEntity>> FindAllUsersAsync();

    Task<UserEntity?> FindAUserAsync(Guid id);

    Task AddUserAsync(UserEntity user);

    Task AddUsersAsync(IEnumerable<UserEntity> users);

    Task UpdateUserAsync(UserEntity user);

    Task UpdateUsersAsync(IEnumerable<UserEntity> users);

    Task RemoveUserAsync(UserEntity user);

    Task RemoveUsersRange(IEnumerable<UserEntity> users);
}