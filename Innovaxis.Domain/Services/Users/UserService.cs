using Innovaxis.Domain.Models;
using Innovaxis.Domain.Repositories.Users;

namespace Innovaxis.Domain.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    //TODO : Implement the service methods
    public Task<IEnumerable<UserEntity>> FindAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity?> FindAUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddUserAsync(UserEntity user)
    {
        throw new NotImplementedException();
    }

    public Task AddUsersAsync(IEnumerable<UserEntity> users)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(UserEntity user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUsersAsync(IEnumerable<UserEntity> users)
    {
        throw new NotImplementedException();
    }

    public Task RemoveUserAsync(UserEntity user)
    {
        throw new NotImplementedException();
    }

    public Task RemoveUsersRange(IEnumerable<UserEntity> users)
    {
        throw new NotImplementedException();
    }
}