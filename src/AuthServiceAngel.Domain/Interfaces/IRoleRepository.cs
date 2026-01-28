
using AuthServiceAngel.Domain.Entities;

namespace AuthServiceAngel.Domain.Interfaces;
public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyCollection<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyCollection<string>> GetUserRoleNamesAsync(string userId);
    
}