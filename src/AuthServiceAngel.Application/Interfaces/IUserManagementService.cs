using AuthServiceAngel.Application.DTOs;
using AuthServiceAngel.Domain.Entities;
namespace AuthServiceAngel.Application.Interfaces;

public interface IUserManagementService
{
    Task<UserResponseDto> UpdateUserRoleAsync(string userId, string roleName);
    Task<IReadOnlyList<string>> GetUserRolesAsync(string userId);
    Task<IReadOnlyList<UserResponseDto>> GetUserByRoleAsync(string roleName);
}