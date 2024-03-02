using Innovaxis.Domain.Models;
using Innovaxis.Domain.Repositories.Users;
using Innovaxis.Infrastructure.Common;
using Innovaxis.Infrastructure.Context;

namespace Innovaxis.Infrastructure.Repositories.Users;

public class UserRepository : GenericRepository<UserEntity>, IUserRepository
{
    public UserRepository(InnovaxisDbContext innovaxisDbContext) : base(innovaxisDbContext)
    {
    }
}