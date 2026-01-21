using AuthServiceAngel.Domain.Entities;
namespace AuthServiceAngel.Application.DTOs;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}