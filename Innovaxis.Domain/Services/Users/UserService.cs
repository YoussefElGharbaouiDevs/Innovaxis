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

    public async Task<IEnumerable<UserEntity>> FindAllUsersAsync()
    {
        return await _userRepository.FindAllAsync();
    }

    public async Task<UserEntity?> FindAUserAsync(Guid id)
    {
        return await _userRepository.FindAsync(id);
    }

    public async Task AddUserAsync(UserEntity user)
    {
        await _userRepository.AddAsync(user);
    }

    public async Task AddUsersAsync(IEnumerable<UserEntity> users)
    {
        await _userRepository.AddRangeAsync(users);
    }

    public async Task UpdateUserAsync(UserEntity user)
    {
        await _userRepository.UpdateAsync(user);
    }

    public async Task UpdateUsersAsync(IEnumerable<UserEntity> users)
    {
        await _userRepository.UpdateRangeAsync(users);
    }

    public async Task RemoveUserAsync(UserEntity user)
    {
        await _userRepository.RemoveAsync(user);
    }

    public async Task RemoveUsersRange(IEnumerable<UserEntity> users)
    {
        await _userRepository.RemoveRange(users);
    }
}